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

namespace BeetleCaf
{
    public partial class UserMdi : Form
    {
        public UserMdi()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            UserLogin frmUser = new UserLogin(this);
            frmUser.MdiParent = this;  
            frmUser.Show();
        }
        public void ShowNewForm()
        {           
            
                // Close all open forms except for the MDI parent form
                foreach (Form form in MdiChildren)
                {
                    if (form == this.ActiveMdiChild)
                    {
                        form.Close();
                    }
                }

                // Show the new form
                Menu form4 = new Menu();                 
                form4.Show();
            
            
            this.Close();  //close the form
        }
    }
}
