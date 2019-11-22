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
    public partial class Viewcustomer : Form
    {
        string name, address, phone, email;
        public Viewcustomer()
        {
            InitializeComponent();
          
        }

        private void linklbl_gotohome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_home home = new Admin_home();
            this.Hide();
            home.Show();
        }

        private void Viewcustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Viewcustomer_Load(object sender, EventArgs e)
        {
            //sql coonection
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=productmanage;Integrated Security=true");
            //call stored procedure
            SqlCommand cmd = new SqlCommand("viewdata", con);
            cmd.CommandType = CommandType.StoredProcedure;
          
            //execute 

            DataTable dt = new DataTable();
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;


        }
    }
}
