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
    public partial class Purchasepdt : Form
    {
        string product;
        int currentqty,txtqty,price,totalcost;
        //sql connection
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=productmanage;Integrated Security=true");
        SqlCommand cmd;
        public Purchasepdt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datetime=DateTime.UtcNow.Date;
            string s = datetime.ToString("dd/MM/yyyy");
            MessageBox.Show(s);
        }

        private void Purchasepdt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productmanageDataSet1.tble_addproduct' table. You can move, or remove it, as needed.
            this.tble_addproductTableAdapter.Fill(this.productmanageDataSet1.tble_addproduct);

        }

        private void cmb_product_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Close();
            product = cmb_product.Text;
            cmd = new SqlCommand("fetchpname", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pname", product);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                txt_price.Text = sdr["price"].ToString();
                currentqty = (int)sdr["quantity"];
            }

            
        }

        private void txt_quatity_TextChanged(object sender, EventArgs e)
        {
            con.Close();
            txtqty = Convert.ToInt32(txt_quatity.Text);
            if(txtqty>currentqty)
            {
                lbl_rquatity.Text = "out of stock";
            }
            else
            {
                lbl_rquatity.Text = "";
                price = Convert.ToInt32(txt_price.Text);
                totalcost = price * txtqty;
                txt_totalcost.Text = totalcost.ToString();


                
               
            }
         

       
        }
    }
}
