//Jeanluc Begue 40779173
//Danika Le Roux 41049764

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeetleCaf
{
    public partial class Menu : Form
    {
        SqlConnection connection;
        SqlDataReader dataReader; //declare global variables
        SqlCommand command;
         //connection string
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jlbeg\OneDrive\Documents\BeetleCaf\BeetleCaf\BeetleCaf\Database1.mdf;Integrated Security=True";
        public Menu()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 frmWelcome = new Form1();
            frmWelcome.Show();  //show the welcome form and close this form 
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            decimal totalPrice = 0;

            foreach (string item in listBox2.Items)
            {
                int priceIndex = item.LastIndexOf("R ") + 2; // Find the index of the price
                decimal price = decimal.Parse(item.Substring(priceIndex)); // Extract the price from the string
                totalPrice += price; // Add the price to the total
            }
          
            List<string> selectedItems = GetSelectedItems();
            Receipt receiptForm = new Receipt();
            receiptForm.AddItemsToReceipt(selectedItems);
            receiptForm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Specials();
            Coffee();
            Tea();      //call methods and add all the tables to the listbox to display the menu
            Pastries();
            Sandwiches();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.SelectedItem.ToString();

            if (listBox1.SelectedItem.ToString() == "Specials: \t Price:\n")
            {
                //Do not add headline
            }
            else if (selectedItem.StartsWith("\n\nTea: \t \t Price:\n"))
            {
                //Do not add headline
            }
            else if (selectedItem.StartsWith("Coffee: \t \t Price:\n"))
            {
                //Do not add headline
            }
            else if (selectedItem.StartsWith("\n\nSandwiches: \t Price:\n"))
            {
                //Do not add headline
            }
            else if (selectedItem.StartsWith("\n\nPastries: \t \t Price:\n"))
            {
                //Do not add headline
            }
            else if (selectedItem.StartsWith("\n"))
            {
                //Do not add empty space
            }
            else
            {
                // Add the selected item from listbox 1 to listBox2
                listBox2.Items.Add(selectedItem);
            }
        }
        public List<string> GetSelectedItems()
        {
            List<string> items = new List<string>();

            foreach (string item in listBox2.Items) //get the selected items
            {
                items.Add(item);
            }

            return items;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string selectedItem = listBox2.SelectedItem.ToString();

            // Add the selected item to remove from listBox2
            listBox2.Items.Remove(selectedItem);
        }

        private void Coffee()
        {
            listBox1.Items.Add("\n");
            listBox1.Items.Add("COFFEE: \t \t PRICE:\n");  //add headings
            listBox1.Items.Add("\n");
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Coffee", connection);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    string name = dataReader.GetString(1);
                    decimal price = dataReader.GetDecimal(2);  //add the items in tables
                    listBox1.Items.Add($"{name}   \t R {price}");
                }



                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.ToString());
            }
        }

        private void Tea()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                listBox1.Items.Add("\n");
                listBox1.Items.Add("\n\nTEA: \t\t PRICE:\n");  //add headings
                listBox1.Items.Add("\n");
                SqlCommand command = new SqlCommand("SELECT * FROM Tea", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string name = dataReader.GetString(1);  
                    decimal price = dataReader.GetDecimal(2);


                    listBox1.Items.Add($"{name}   \t R {price}"); //add values in table
                }

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.ToString());
            }
        }

        private void Pastries()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                listBox1.Items.Add("\n");
                listBox1.Items.Add("\n\nPASTRIES: \t PRICE:\n"); //add headings
                listBox1.Items.Add("\n");
                SqlCommand command = new SqlCommand("SELECT * FROM Pastries", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string name = dataReader.GetString(1);
                    decimal price = dataReader.GetDecimal(2);


                    listBox1.Items.Add($"{name}   \t R {price}");  //add values from table
                }

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.ToString());  //show error message
            }
        }

        private void Sandwiches()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                listBox1.Items.Add("\n");
                listBox1.Items.Add("\n\nSANDWHICHES:\t PRICE:\n");  //add headings
                listBox1.Items.Add("\n");
                SqlCommand command = new SqlCommand("SELECT * FROM Sandwiches", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string name = dataReader.GetString(1);
                    decimal price = dataReader.GetDecimal(2);


                    listBox1.Items.Add($"{name}   \t R {price}");  //add values from tables
                }

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.ToString()); //show error message
            }
        }
        private void Specials()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                
                listBox1.Items.Add("SPECIALS: \t PRICE:\n");  //add headings
                listBox1.Items.Add("\n");
                SqlCommand command = new SqlCommand("SELECT * FROM Specials", connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string name = dataReader.GetString(1);
                    decimal price = dataReader.GetDecimal(2);


                    listBox1.Items.Add($"{name}   \t R {price}");  //add values
                }

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.ToString()); //show message
            }
        }
    }
}
