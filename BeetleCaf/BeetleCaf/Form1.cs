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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserMdi frmMdi = new UserMdi();
            //frmMdi.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffMdi frmStaffMdi = new StaffMdi();
            frmStaffMdi.Show();  //show the staff login
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu frmMenu = new Menu();
            frmMenu.Show();   //show the menu form
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exit the application
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnUserLogin.Hide();
        }
    }
}
