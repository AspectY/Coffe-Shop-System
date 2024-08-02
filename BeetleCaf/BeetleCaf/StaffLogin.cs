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
    public partial class StaffLogin : Form
    {
        SqlConnection connection;
        SqlCommand command;  //declare global variables
        SqlDataReader dataReader;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\jlbeg\OneDrive\Documents\BeetleCaf\BeetleCaf\BeetleCaf\Database1.mdf;Integrated Security=True";
        public StaffLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Find the first form to open
            Form firstFormToOpen = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1) //close form and open the welcome form
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


       
        private void btnLogin_Click(object sender, EventArgs e)
        {
                try
                {
                    if (txtUsername.Text == "")
                    {
                        errorProviderUsername.SetError(txtUsername, "Please enter a username");
                        txtUsername.Text = "";
                        txtPassword.Text = "";  //show error and clear textboxes
                        txtUsername.Focus();
                    }
                    else if (txtPassword.Text == "")
                    {
                        errorProviderUsername.Clear();
                        errorProviderUsername.SetError(txtPassword, "Please enter a password");
                        txtPassword.Text = "";  //show error and clear textboxes
                        txtPassword.Focus();
                    }
                    else
                    {
                        connection = new SqlConnection(connectionString);
                        connection.Open();

                        string sql = "SELECT * FROM Staff";
                        command = new SqlCommand(sql, connection); 
                        dataReader = command.ExecuteReader();

                        bool matchFound = false;  //check to see if details match the details in the table

                        while (dataReader.Read())
                        {
                            if (txtUsername.Text == dataReader.GetValue(1).ToString() && txtPassword.Text == dataReader.GetValue(2).ToString())  //get the value from the textboxes
                            {
                                matchFound = true;
                                break;
                            }
                        }

                        connection.Close();

                        if (matchFound)
                        {
                            this.Close();
                        }
                        else
                        {
                            lblError.Text = "Username or Password is Incorrect!";
                            txtUsername.Text = "";
                            txtPassword.Text = "";  //show error
                            txtUsername.Focus();
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("The following error occurred:\t" + er.ToString());  //show error message
                }
        }

        private void StaffLogin_Load(object sender, EventArgs e)
        {
            // Set cursor to start at username texrbox as soon as form load
            txtUsername.Focus();
            txtUsername.TabIndex = 0;
            txtPassword.TabIndex = 1;
        }
    }
}
