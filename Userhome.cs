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
    public partial class lbl_fullname : Form
    {
        public static string uname="";
        public lbl_fullname()
        {
            InitializeComponent();
        }

        private void linklbl_logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void linklbl_eprofile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Editregister ereg = new Editregister();
            this.Hide();
            ereg.Show();
        }

        private void lbl_fullname_Load(object sender, EventArgs e)
        {
            string un = Login.u;
            uname = un;
        }

        private void linklbl_purchasepdt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Purchasepdt pdt = new Purchasepdt();
            pdt.ShowDialog();
                 
        }
    }
}
