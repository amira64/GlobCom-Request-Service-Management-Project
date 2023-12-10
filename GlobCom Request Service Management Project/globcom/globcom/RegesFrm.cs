using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace globcom
{
    public partial class RegesFrm : Form
    {
        SqlConnection con;

        public RegesFrm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegesFrm_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);

            joindtlbl.Text = DateTime.Now.ToString("dd-MM-yyyy");
            jointimelbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtcompany_Click(object sender, EventArgs e)
        {
            txtcompany.Clear();
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            txtcompany.ForeColor = Color.FromArgb(78, 184, 206);
            panelemail.BackColor = Color.WhiteSmoke;
           txtemail.ForeColor = Color.WhiteSmoke;
            panelphone1.BackColor = Color.WhiteSmoke;
            txtphon1.ForeColor = Color.WhiteSmoke;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtphone2.ForeColor = Color.WhiteSmoke;
            paneladdress.BackColor = Color.WhiteSmoke;
            txtaddres.ForeColor = Color.WhiteSmoke;
            panelpass.BackColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            panelrepass.BackColor = Color.WhiteSmoke;
           txtrepass.ForeColor = Color.WhiteSmoke;
        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            txtemail.Clear();
            panelemail.BackColor = Color.FromArgb(78, 184, 206);
            txtemail.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor= Color.WhiteSmoke;
            txtcompany.ForeColor = Color.WhiteSmoke;
            panelphone1.BackColor = Color.WhiteSmoke;
            txtphon1.ForeColor = Color.WhiteSmoke;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtphone2.ForeColor = Color.WhiteSmoke;
            paneladdress.BackColor = Color.WhiteSmoke;
            txtaddres.ForeColor = Color.WhiteSmoke;
            panelpass.BackColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            panelrepass.BackColor = Color.WhiteSmoke;
            txtrepass.ForeColor = Color.WhiteSmoke;
        }

        private void txtphon1_Click(object sender, EventArgs e)
        {
            txtphon1.Clear();
            panelphone1.BackColor = Color.FromArgb(78, 184, 206);
            txtphon1.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            txtcompany.ForeColor = Color.WhiteSmoke;
            panelemail.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtphone2.ForeColor = Color.WhiteSmoke;
            paneladdress.BackColor = Color.WhiteSmoke;
            txtaddres.ForeColor = Color.WhiteSmoke;
            panelpass.BackColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            panelrepass.BackColor = Color.WhiteSmoke;
            txtrepass.ForeColor = Color.WhiteSmoke;
        }

        private void txtphone2_Click(object sender, EventArgs e)
        {
            txtphone2.Clear();
            panelphone2.BackColor = Color.FromArgb(78, 184, 206);
            txtphon1.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            txtcompany.ForeColor = Color.WhiteSmoke;
            panelemail.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            panelphone1.BackColor = Color.WhiteSmoke;
            txtphon1.ForeColor = Color.WhiteSmoke;
            paneladdress.BackColor = Color.WhiteSmoke;
            txtaddres.ForeColor = Color.WhiteSmoke;
            panelpass.BackColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            panelrepass.BackColor = Color.WhiteSmoke;
            txtrepass.ForeColor = Color.WhiteSmoke;
        }

        private void txtaddres_Click(object sender, EventArgs e)
        {
           txtaddres.Clear();
            paneladdress.BackColor = Color.FromArgb(78, 184, 206);
            txtaddres.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            txtcompany.ForeColor = Color.WhiteSmoke;
            panelemail.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            panelphone1.BackColor = Color.WhiteSmoke;
            txtphon1.ForeColor = Color.WhiteSmoke;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtphone2.ForeColor = Color.WhiteSmoke;
            panelpass.BackColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
            panelrepass.BackColor = Color.WhiteSmoke;
            txtrepass.ForeColor = Color.WhiteSmoke;
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            panelpass.BackColor = Color.FromArgb(78, 184, 206);
            txtpass.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            txtcompany.ForeColor = Color.WhiteSmoke;
            panelemail.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            panelphone1.BackColor = Color.WhiteSmoke;
            txtphon1.ForeColor = Color.WhiteSmoke;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtphone2.ForeColor = Color.WhiteSmoke;
            paneladdress.BackColor = Color.WhiteSmoke;
            txtaddres.ForeColor = Color.WhiteSmoke;
            panelrepass.BackColor = Color.WhiteSmoke;
            txtrepass.ForeColor = Color.WhiteSmoke;
        }

        private void txtrepass_Click(object sender, EventArgs e)
        {
            txtrepass.Clear();
            panelrepass.BackColor = Color.FromArgb(78, 184, 206);
            txtpass.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.WhiteSmoke;
            txtcompany.ForeColor = Color.WhiteSmoke;
            panelemail.BackColor = Color.WhiteSmoke;
            txtemail.ForeColor = Color.WhiteSmoke;
            panelphone1.BackColor = Color.WhiteSmoke;
            txtphon1.ForeColor = Color.WhiteSmoke;
            panelphone2.BackColor = Color.WhiteSmoke;
            txtphone2.ForeColor = Color.WhiteSmoke;
            paneladdress.BackColor = Color.WhiteSmoke;
            txtaddres.ForeColor = Color.WhiteSmoke;
            panelpass.BackColor = Color.WhiteSmoke;
            txtpass.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
         

            if (txtrepass.Text == txtpass.Text)
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string compname, email, address, pwd, repwd, type = "user", joindt, jointime;
                int phon1, phon2;

                compname = this.txtcompany.Text.Trim().Replace("'", "''");
                email = this.txtemail.Text.Trim().Replace("'", "''");
                phon1 = Convert.ToInt32(this.txtphon1.Text);
                phon2 = Convert.ToInt32(this.txtphone2.Text);
                address = this.txtaddres.Text.Trim().Replace("'", "''");
                pwd = this.txtpass.Text.Trim().Replace("'", "''");
                repwd = this.txtrepass.Text.Trim().Replace("'", "''");
                joindt = this.joindtlbl.Text.Trim().Replace("'", "''");
                jointime = this.jointimelbl.Text.Trim().Replace("'", "''");


                string sqlinserquery2 = "insert into Login(usrnm_email,pwd,type) " +
                     "values('" + email + "','" + repwd + "','" + type + "')";


                SqlCommand cmd2 = new SqlCommand(sqlinserquery2, con);

                int cnt2 = 0;
                try
                {
                    cnt2 = cmd2.ExecuteNonQuery();
                    if (cnt2 > 0)
                    {
                        this.infolbl.Text = "Company account has been registered !";

                    }
                    else
                    {
                        this.infolbl.Text = "Process Aborted..!";
                    }
                }
                catch (Exception ex)
                {
                    this.infolbl.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                    cmd2.Dispose();
                }

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string sqlinserquery;
                sqlinserquery = "insert into Companies(company_name,email,phone1,phone2,location,Joining_date,Joining_time) " +
                    "values('" + compname + "','" + email + "'," + phon1 + "," + phon2 + ",'" + address + "','" + joindt + "','" + jointime + "')";

                SqlCommand cmd = new SqlCommand(sqlinserquery, con);

                int cnt = 0;
                try
                {
                    cnt = cmd.ExecuteNonQuery();
                    if (cnt > 0)
                    {
                        this.infolbl.Text = "Company account has been registered !";

                    }
                    else
                    {
                        this.infolbl.Text = "Process Aborted..!";
                    }
                }
                catch (Exception ex)
                {
                    this.infolbl.Text = ex.Message;
                }
                finally
                {
                    con.Close();
                    cmd.Dispose();
                }
            }
            else
            {
                infolbl.Text = "Passwords are not matching..!";
                pwdlbl.Text = "*";
                repwdlbl.Text = "*";
            }

            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loglbl_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void cmpnmlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
