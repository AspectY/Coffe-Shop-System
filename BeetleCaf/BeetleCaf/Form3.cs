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
    public partial class UserLogin : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;  //declare global connections
        SqlDataReader dataReader;
        SqlCommand command;

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jlbeg\OneDrive\Desktop\BeetleCaf\BeetleCaf\Database1.mdf;Integrated Security=True";
        private UserMdi parentForm;
        public UserLogin(UserMdi parentForm)
        {
            InitializeComponent();
           // parentForm = (UserMdi)this.MdiParent;
            //this.parentForm = parentForm;
        }
        public void CloseForms()
        {
            // Find the first form to open
            Form firstFormToOpen = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1) // Replace with the appropriate type of your first form
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
        private void button2_Click(object sender, EventArgs e)
        {
            CloseForms();  //call method
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CloseForms(); //call method
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
                // Get the parent form (Form2)
                UserMdi parentForm = (UserMdi)this.MdiParent;

                // Close all open forms except for the MDI parent form
                foreach (Form form in parentForm.MdiChildren)
                {
                    if (form != parentForm.ActiveMdiChild)
                    {
                        form.Close();
                    }
                }
                parentForm.ShowNewForm();
           
            
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text;
            //string password = txtPassword.Text;  //set variables
            //string email = txtEmail.Text;
            //connection = new SqlConnection(connectionString);
            //try
            //{
            //    connection.Open();

            //    string insertSql = $"INSERT INTO Clients(client_name,password,email_adress) VALUES('{username}','{password}','{email}')";
            //    command = new SqlCommand(insertSql, connection);

            //    adapter = new SqlDataAdapter();
            //    adapter.InsertCommand = command;
            //    adapter.InsertCommand.ExecuteNonQuery();

            //    connection.Close();

            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show("Error occured: " + er.Message.ToString());
            //}
        }
    }
    
}
