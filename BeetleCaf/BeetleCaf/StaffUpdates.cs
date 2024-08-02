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
    public partial class StaffUpdates : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;  //declare global variables
        SqlDataReader dataReader;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jlbeg\OneDrive\Documents\BeetleCaf\BeetleCaf\BeetleCaf\Database1.mdf;Integrated Security=True";
        public StaffUpdates()
        {
            InitializeComponent();
        }

        public void CloseForms()
        {
            // Find the first form to open
            Form firstFormToOpen = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1) // close all forms and show welcome form
                {
                    firstFormToOpen = form;
                    break;
                }
            }

            // Close all forms except the first form
            List<Form> formsToClose = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                if (form != firstFormToOpen)
                {
                    formsToClose.Add(form);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            // Open the first form again if it was found
            if (firstFormToOpen != null)
            {
                firstFormToOpen.Show();
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
             //call method to clear forms
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSpecials_Click(object sender, EventArgs e)
        {
            
        }

        private void DisplayAll()  //method to display all items in tables
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "Specials")
                {
                    listBox1.Items.Clear();  //clear listbox


                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Specials", connection); //select all items from specials
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString(1);
                        decimal price = dataReader.GetDecimal(2); 


                        listBox1.Items.Add($"{name}   \t R {price}");  //get values from tables
                    }

                    connection.Close();


                }
                else if (comboBox1.SelectedItem.ToString() == "Coffee")  //Coffe table
                {
                    listBox1.Items.Clear();


                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Coffee", connection);  //select values from table
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString(1);
                        decimal price = dataReader.GetDecimal(2);


                        listBox1.Items.Add($"{name}   \t R {price}");  //get values
                    }

                    connection.Close();

                }
                else if (comboBox1.SelectedItem.ToString() == "Pastries")  //pastries table
                {
                    listBox1.Items.Clear();


                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Pastries", connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString(1);
                        decimal price = dataReader.GetDecimal(2);

                        listBox1.Items.Add($"{name}   \t R {price}");  //get values
                    }

                    connection.Close();
                }
                else if (comboBox1.SelectedItem.ToString() == "Tea")  //tea table
                {
                    listBox1.Items.Clear();

                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Tea", connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString(1);
                        decimal price = dataReader.GetDecimal(2);


                        listBox1.Items.Add($"{name}   \t R {price}"); //get values
                    }

                    connection.Close();



                }
                else if (comboBox1.SelectedItem.ToString() == "Sandwiches")  //sandwhiches table
                {
                    listBox1.Items.Clear();

                    connection = new SqlConnection(connectionString);
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Sandwiches", connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        string name = dataReader.GetString(1);
                        decimal price = dataReader.GetDecimal(2);


                        listBox1.Items.Add($"{name}   \t R {price}");  //get values from table
                    }

                    connection.Close();
                }
            }

            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.ToString());  //show error message
            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void deleteSpecials()  //method to delete items 
                                       //comments are the same for all deleteFunctions
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string item = listBox1.SelectedItem.ToString().Split(new[] { "   \t " }, StringSplitOptions.None)[0];  //split items to name from price

                string query = "DELETE FROM Specials WHERE special_name = @special_name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@special_name", item);

                command.ExecuteNonQuery();

                // Remove the coffee item from the ListBox
                listBox1.Items.Remove(item);  //remove item from listbox

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.Message.ToString());  //show error message
            }
        }

        private void deleteCoffee()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string item = listBox1.SelectedItem.ToString().Split(new[] { "   \t " }, StringSplitOptions.None)[0];

                string query = "DELETE FROM Coffee WHERE coffee_name = @coffee_name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@coffee_name", item);

                command.ExecuteNonQuery();

                // Remove the coffee item from the ListBox
                listBox1.Items.Remove(item);

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.Message.ToString());
            }
        }
        private void deletePastries()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string item = listBox1.SelectedItem.ToString().Split(new[] { "   \t " }, StringSplitOptions.None)[0];

                string query = "DELETE FROM Pastries WHERE pastry_name = @pastry_name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@pastry_name", item);

                command.ExecuteNonQuery();

                // Remove the coffee item from the ListBox
                listBox1.Items.Remove(item);

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.Message.ToString());
            }
        }

        private void deleteTea()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string item = listBox1.SelectedItem.ToString().Split(new[] { "   \t " }, StringSplitOptions.None)[0];

                string query = "DELETE FROM Tea WHERE tea_name = @tea_name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@tea_name", item);

                command.ExecuteNonQuery();

                // Remove the coffee item from the ListBox
                listBox1.Items.Remove(item);

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.Message.ToString());
            }
        }

        private void deleteSandwhices()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                string item = listBox1.SelectedItem.ToString().Split(new[] { "   \t " }, StringSplitOptions.None)[0];

                string query = "DELETE FROM Sandwhices WHERE sandwhices_name = @sandwhices_name";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@sandwhices_name", item);

                command.ExecuteNonQuery();

                // Remove the coffee item from the ListBox
                listBox1.Items.Remove(item);

                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.Message.ToString());
            }
        }




        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox2.SelectedItem.ToString() == "Specials")  //if statements to load tables
            //{
            //    LoadTable("Specials");
            //}
            //else if (comboBox2.SelectedItem.ToString() == "Coffee")
            //{
            //    LoadTable("Coffee");
            //}
            //else if (comboBox2.SelectedItem.ToString() == "Tea")
            //{
            //    LoadTable("Tea");
            //}
            //else if (comboBox2.SelectedItem.ToString() == "Pastries")
            //{
            //    LoadTable("Pastries");
            //}
            //else if (comboBox2.SelectedItem.ToString() == "Sandwhices")
            //{
            //    LoadTable("Sandwhiches");
            //}
        }
        private void LoadTable(string tableName)
        {
            //connection = new SqlConnection(connectionString);  //load items into the datagridview
            //{
            //    connection.Open();

            //    // Fetch the data from the specified table
            //    string query = $"SELECT * FROM {tableName}";
            //    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //    DataTable table = new DataTable();
            //    adapter.Fill(table);

            //    // Set the DataGridView's DataSource to the retrieved data table
            //    dataGridView1.DataSource = table;
            //    connection.Close();
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //connection = new SqlConnection(connectionString);
            //{
            //    connection.Open();

            //    // Fetch the data from the specified table
            //    string query = $"SELECT * FROM {comboBox2.Text} WHERE {comboBox2.Text + "_id"} LIKE '%{textBox1.Text}%";
            //    command = new SqlCommand(query, connection);
            //    adapter = new SqlDataAdapter();
            //    adapter.SelectCommand = command;

            //    DataSet dataset = new DataSet();
            //    adapter.Fill(dataset, $"'{comboBox2.Text}'");
            //    dataGridView1.DataSource = dataset;
            //    dataGridView1.DataMember = comboBox2.Text;

            //}
            //connection.Open();

            //// Fetch the data from the specified table
            //string query = $"SELECT * FROM {comboBox2.Text} WHERE {comboBox2.Text + "_id"} LIKE '%{textBox1.Text}%";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //// Set the DataGridView's DataSource to the retrieved data table
            //dataGridView1.DataSource = table;
            //connection.Close();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DisplayAll();
        }

       

     

        private void btnRemove_Click_2(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)  //use if statements to determine table to work with
            {
                if (comboBox1.SelectedItem.ToString() == "Specials")
                {
                    deleteSpecials();
                }
                else if (comboBox1.SelectedItem.ToString() == "Coffee")
                {
                    deleteCoffee();
                }
                else if (comboBox1.SelectedItem.ToString() == "Tea")
                {
                    deleteTea();
                }
                else if (comboBox1.SelectedItem.ToString() == "Pastries")
                {
                    deletePastries();
                }
                else if (comboBox1.SelectedItem.ToString() == "Sandwhices")
                {
                    deleteSandwhices();
                }

                DisplayAll();
                lblRemove.Text = "Item Successfully Removed !";  //label indicating item is successfully removed
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string insertSql = $"INSERT INTO Coffee(coffee_name,coffee_price) VALUES('{txtAddCoffeeName.Text}','{txtAddCoffeePrice.Text}')";  //add new coffee with details from textbox
                command = new SqlCommand(insertSql, connection);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                lblCofee.Text = "Item added successfully";  //label indicating item was added succsessfully

                connection.Close();
                txtAddCoffeeName.Text = "";
                txtAddCoffeePrice.Text = "";  //clear textboxes
                txtAddCoffeeName.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.Message.ToString()); //show error message
            }
        }

        private void btnSpecials_Click_1(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                string insertSql = $"INSERT INTO Specials(special_name,special_price) VALUES('{txtSpecialName.Text}','{txtSpecialPrice.Text}')";  //add specials with values from textboxes
                command = new SqlCommand(insertSql, connection);

                adapter = new SqlDataAdapter();
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                lblSpecial.Text = "Special added successfully";  //label indicating item was added successfully


                txtSpecialName.Text = "";
                txtSpecialPrice.Text = "";  //clear items in textboxes
                txtSpecialName.Focus();
                connection.Close();

            }
            catch (Exception er)
            {
                MessageBox.Show("Error occured: " + er.Message.ToString());  //show error message
            }
        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            CloseForms();
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            DisplayAll();  //call the display method
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
