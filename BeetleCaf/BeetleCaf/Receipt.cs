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
    public partial class Receipt : Form
    {
        private decimal totalPrice = 0.0m;

        public Receipt()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();

            // close the main form
            Menu frmMenu = Application.OpenForms.OfType<Menu>().FirstOrDefault();
            if (frmMenu != null)
            {
                frmMenu.Close();
            }

            Form1 frmMain = new Form1();
            frmMain.Show();
        }

        public void AddItemsToReceipt(List<string> items)
        {
            foreach (string item in items)
            {
                listBox1.Items.Add(item);
                string[] itemData = item.Split(' ');  //add the items purchased to the receipt
                decimal price = Decimal.Parse(itemData[itemData.Length - 1]);
                totalPrice += price;
            }
            listBox1.Items.Add("------------------------------------------------------\n");
            listBox1.Items.Add($"Total:\t\t R {totalPrice}");
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

        }
    }
}
