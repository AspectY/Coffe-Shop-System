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
    public partial class StaffMdi : Form
    {
        public StaffMdi()
        {
            InitializeComponent();
        }

        private void StaffMdi_Load(object sender, EventArgs e)
        {
            StaffLogin frmStaff = new StaffLogin();
            frmStaff.MdiParent = this;
            frmStaff.FormClosed += StaffLogin_FormClosed;
            frmStaff.Show();
            
        }
        private void StaffLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Create a new instance of the target form and open it
            // this.MdiParent = true;
            this.Size = new Size(1000, 460);
            StaffUpdates frmStaffUpdate = new StaffUpdates();
            frmStaffUpdate.MdiParent = this;
            frmStaffUpdate.Show();
        }


    }
}
