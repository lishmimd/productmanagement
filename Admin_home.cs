using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_management
{
    public partial class Admin_home : Form
    {
        public Admin_home()
        {
            InitializeComponent();
        }

        private void Admin_home_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linklbl_addcategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Addc_category addcgy = new Addc_category();
            this.Hide();
            addcgy.Show();
        }

        private void linklbl_addproduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_product addpdt = new Add_product();
            this.Hide();
            addpdt.Show();
        }

        private void linklbl_viewcustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Viewcustomer vcust = new Viewcustomer();
            this.Hide();
            vcust.Show();
        }

        private void linklbl_viewph_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Viewpurachsehistory vph = new Viewpurachsehistory();
            this.Hide();
            vph.Show();
        }

        private void linklbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void Admin_home_Load(object sender, EventArgs e)
        {

        }
    }
}
