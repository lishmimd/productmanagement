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
    public partial class Editregister : Form
    {
        string phone, email;
        string user;
        //sql connection
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=productmanage;Integrated Security=true");
        SqlCommand cmd;
        public Editregister()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Close();
            phone = txt_phone.Text;
            email = txt_email.Text;

            //to call stored procedure
            SqlCommand cmd = new SqlCommand("edit_data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //pass value
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@username", user);
            //exeute
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data updated");
            lbl_fullname uh = new lbl_fullname();
            uh.ShowDialog();


        }

        private void Editregister_Load(object sender, EventArgs e)
        {
            user = lbl_fullname.uname;
            cmd = new SqlCommand("select_data", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", user);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                txt_email.Text = sdr["email"].ToString();
                txt_phone.Text = sdr["phone"].ToString();

            }




        }

  
    }
}
