using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_management
{
    public partial class Addc_category : Form
    {
        string category;

        public Addc_category()
        {
            InitializeComponent();
        }

        private void Addc_category_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_home home = new Admin_home();
            this.Hide();
            home.Show();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            category = txt_category.Text;
            //sqlconnection
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=productmanage;Integrated Security=true");
            //to call stored procedure
            SqlCommand cmd = new SqlCommand("insertdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //pass value
            cmd.Parameters.AddWithValue("@category", category);
            //execute 
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("insert sucessfully");
            reset();

        }
        public void reset()
        {
            txt_category.Text = "";
        }
    }
}
