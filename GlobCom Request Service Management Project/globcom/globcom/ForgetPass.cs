using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace globcom
{
    public partial class ForgetPass : Form
    {
        string OTPCode;
        public static string to;
        public static string eml;
        public ForgetPass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            txtverfiy.Clear();
            panelver.BackColor = Color.FromArgb(78, 184, 206);
            txtverfiy.ForeColor = Color.FromArgb(78, 184, 206);
            panelemail.BackColor = Color.WhiteSmoke;
            txtEmail.ForeColor = Color.WhiteSmoke;

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtverfiy.Visible = true;
            pictureBox7.Visible = true;
            panelver.Visible = true;
            btnverifiy.Visible = true;
            txtEmail.Visible = false;
            panelemail.Visible = false;
            pictureBox3.Visible = false;
            btnsend.Visible = false;

            string from, pass, messageBody;
            Random rend = new Random();
            OTPCode = (rend.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "zainabkhalifa95@gmail.com";
            pass = "nltglnbkebgrhcdg";
            messageBody = "Your Rest OTP Code is " + OTPCode;
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Forgot Password";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("code send successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtemil_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            panelemail.BackColor = Color.FromArgb(78, 184, 206);
            txtEmail.ForeColor = Color.FromArgb(78, 184, 206);
            panelver.BackColor = Color.WhiteSmoke;
            txtverfiy.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {
            eml = txtEmail.Text;
        }

        private void btnverifiy_Click(object sender, EventArgs e)
        {
            if (OTPCode == (txtverfiy.Text).ToString())
            {
                to = txtEmail.Text;
                ChangePass cp = new ChangePass();
                this.Hide();
                cp.Show();

            }
            else
            {
                MessageBox.Show("wrong code");
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Hide();
        }
    }
}
