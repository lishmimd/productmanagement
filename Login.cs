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
    public partial class Login : Form
    {
        public static string u = "";
        string username, password;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linklbl_newuser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            username = txt_username.Text;
            u = username;
            password = txt_password.Text;
            if (username == "admin" && password == "admin")
            {
                Admin_home ahome = new Admin_home();
                this.Hide();
                ahome.Show();

            }
            else
            {

                //sql coonection
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=productmanage;Integrated Security=true");
                //to call stored procedure
                SqlCommand cmd = new SqlCommand("logindata", con);
                cmd.CommandType = CommandType.StoredProcedure;
                //pass values
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                //execute stored procedure
                con.Open();
                int i = (int)cmd.ExecuteScalar();
                if (i > 0)
                {
                    lbl_fullname ahom = new lbl_fullname();
                    this.Hide();
                    ahom.Show();
                }


                else
                {
                    MessageBox.Show("Invalid username&password");

                }
            }
        }
    }
}

