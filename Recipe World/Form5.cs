using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Net.Mail;

namespace Recipe_World
{
   
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            sql con8 = new sql();
            SqlConnection connectionobj = new SqlConnection(con8.connect);
            connectionobj.Open();
            string query = "select * from login1 where username1='" + Username.Text.Trim() + "' and password1='" + Password.Text.Trim() + "'";
            SqlDataAdapter sda=new SqlDataAdapter(query, connectionobj);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count ==1)
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Check Your Username or Password!!!");
            }
            //string username = Username.Text;
            // string password = Password.Text;
            // if( username == "admin" && password== "123" )
            // {
            //     this.Hide();
            //    Form2 f2 = new Form2();
            //    f2.ShowDialog();

            // }
            // else
            // { 
            //    MessageBox.Show("Invalid Username or Password"); 
            //}
        }

        public void Username_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            try
            {

                string number = "1234";
                string send = "dinalrandika10104@gmail.com";
                string reciver = "dinalrandika40@gmail.com";
                string mailpassword = "elgjhamlpebnyhco";
                string subject = "Security Code for Password Reset";
                string body = "Security Code:" + number;

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(send);
                msg.Subject = subject;
                msg.Body = body;
                //msg.IsBodyHtml = true;
                msg.To.Add(new MailAddress(reciver));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                System.Net.NetworkCredential nc = new NetworkCredential("dinalrandika10104@gmail.com",mailpassword);
                smtp.Credentials = nc;
                smtp.EnableSsl = true;
                smtp.Send(msg);
                MessageBox.Show("Check Your Email for security code!!!");
                Form4 f8 = new Form4();
                f8.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"Error sending Email");
            }


            
        }
    }
}
