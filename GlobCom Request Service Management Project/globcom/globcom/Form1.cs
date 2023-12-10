using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace globcom
{
    public partial class Form1 : Form
    {
        public static string UN;
        public static string EmailId;
        public static string companyname;
        public static string pwd;
        string ut;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);

        }

        private void usertxt_Click(object sender, EventArgs e)
        {


        }

        private void textBox3_Click(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forgebttton_Click(object sender, EventArgs e)
        {

        }

        private void btnsing_Click(object sender, EventArgs e)
        {


            if (this.txtUserName.Text.Trim().Length == 0 || this.txtUserName.Text == "Username")
            {
                this.txtUserName.Focus();
                this.usrnminfotxt.Text = "*Please type username!";
                return;
            }
            if (this.txtPassword.Text.Trim().Length == 0 || this.txtPassword.Text == "Password")
            {
                this.txtPassword.Focus();
                this.usrnminfotxt.Text = "*Please type password!";
                return;
            }

            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);


            EmailId = txtUserName.Text.Trim().Replace("'", "''");
            string Password = txtPassword.Text.Trim().Replace("'", "''");

            string qry = "select type from Login where usrnm_email='" + txtUserName.Text.Trim() + "' and pwd= '" + txtPassword.Text.Trim() + "'";
            //string qry = "select type, company_name from Login l left join Companies c on l.usrnm_email = c.email where usrnm_email = '"+txtPassword.Text.Trim()+"' and pwd = '"+txtPassword.Text.Trim() + "'";
            using (SqlCommand command = new SqlCommand(qry, con))
            {
                command.Parameters.AddWithValue("@EmailId", EmailId);
                command.Parameters.AddWithValue("@Password", Password);
                //command.Parameters.AddWithValue("@companyname", companyname);
                con.Open();

                SqlDataAdapter sda = new SqlDataAdapter(qry, con);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                try
                {
                    //SqlConnection con = new SqlConnection();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        ut = dt.Rows[0][0].ToString();
                        if (ut == "admin")
                        {
                            AdminFM fm = new AdminFM();
                            fm.ShowDialog();
                            this.Hide();


                        }
                        else if (ut == "user")
                        {
                            Main fm = new Main();
                            fm.ShowDialog();
                            this.Hide();

                        }





                    }
                    else
                    {

                        MessageBox.Show("check username and password");
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();

                }
            }
        
            //////////////////////////////////////////

            /*{
                command.Parameters.AddWithValue("@EmailId", EmailId);
                command.P);arameters.AddWithValue("@password", Password
               con.Open();



                SqlDataAdapter sda = new SqlDataAdapter(qry, con);
                if(con.State==ConnectionState.Closed)
                {
                    con.Open();
                }

                try
                {
          
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        ut = dt.Rows[0][0].ToString();
                        if (ut == "admin")
                        {
                            AdminFM admnfrm = new AdminFM();
                            admnfrm.ShowDialog();
                            this.Hide();
                        }
                        else if (ut == "user")
                        {
                            UpdateProfile profrm = new UpdateProfile();
                            profrm.ShowDialog();
                            this.Hide();

                        }

                    }
                    else
                    {

                        MessageBox.Show("check username and password");
                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();

                }*/
            }
            

        private void usertxt_Click_1(object sender, EventArgs e)
        {
            txtUserName.Clear();
            pictureBox1.BackgroundImage = Properties.Resources._11111;
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            panel3.BackColor = Color.WhiteSmoke;
            txtUserName.ForeColor = Color.WhiteSmoke;

            pictureBox5.BackgroundImage = Properties.Resources.p;
            txtUserName.ForeColor = Color.FromArgb(78, 184, 206);

        }

        private void textBox3_Click_1(object sender, EventArgs e)
        {
            txtPassword.Clear();
            pictureBox5.BackgroundImage = Properties.Resources.p;
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            txtPassword.ForeColor = Color.WhiteSmoke;


            pictureBox1.BackgroundImage = Properties.Resources._11111;
            txtPassword.ForeColor = Color.FromArgb(78, 184, 206);
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            RegesFrm regfrm = new RegesFrm();
            regfrm.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Forgebttton_Click_1(object sender, EventArgs e)
        {
            ForgetPass fpwd = new ForgetPass();
            fpwd.Show();
            this.Hide();
        }
    }
}
