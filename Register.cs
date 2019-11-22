using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_management
{
    public partial class Register : Form
    {
        string name, address, phone, email, username, password;

       

        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linklbl_gotologin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            name = txt_name.Text;
            address= name = txt_address.Text;
            phone = txt_phone.Text;
            email = txt_email.Text;
            username=txt_reguname.Text;
            password = txt_regpwd.Text;
            //sql connection

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=productmanage;Integrated Security=true");

            //to call stored procedure

            SqlCommand cmd = new SqlCommand("insert_register", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //to pass value
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password",password);
            //execute procedure
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registeration sucessfully");
            sendMail();
            reset();
           
        }
        public void reset()
        {
            txt_name.Text = "";
            txt_address.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_reguname.Text = "";
            txt_regpwd.Text = "";
        }
        void sendMail()
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("lishmidavis@gmail.com");
            mail.To.Add(email);
            mail.Subject ="Conformation mail";
            mail.Body = "username : "+ username + "\n" + "password : " +password;
            SmtpClient smt = new SmtpClient();
            smt.Host = "smtp.gmail.com";
            System.Net.NetworkCredential ntwd = new System.Net.NetworkCredential();
            ntwd.UserName = "lishmidavis@gmail.com"; //Your Email ID  
            ntwd.Password = "lishmimol26"; // Your Password  
            smt.UseDefaultCredentials = true;
            smt.Credentials = ntwd;
            smt.Port = 587;
            smt.EnableSsl = true;
            smt.Send(mail);
        }
    }
}
