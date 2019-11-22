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
    public partial class Add_product : Form
    {
      
        string category, pname;
        int price, quantity;

        public Add_product()
        {
            InitializeComponent();
        }

        private void Add_product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productmanageDataSet.tble_addcategory' table. You can move, or remove it, as needed.
            this.tble_addcategoryTableAdapter.Fill(this.productmanageDataSet.tble_addcategory);

        }

        private void Add_product_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linklbl_productgotohome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Admin_home home =new Admin_home();
            this.Hide();
            home.Show();
        }

        private void btn_addproduct_Click(object sender, EventArgs e)
        {
            category = combobox_category.Text;
            pname = txt_productname.Text;
            price = Convert.ToInt32(txt_price.Text);
            quantity = Convert.ToInt32(txt_quality.Text);
            //sqlconnection
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=productmanage;Integrated Security=true");
            // call stored procedure
            SqlCommand cmd = new SqlCommand("add_product", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //pass value to the stored procedure
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            //execute
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Productdetails added");
            Reset();
        }
        public void Reset()
        {
            combobox_category.Text = "";
            txt_productname.Text = "";
            txt_price.Text = "";
            txt_quality.Text = ""; 
        }





        
    }
}
