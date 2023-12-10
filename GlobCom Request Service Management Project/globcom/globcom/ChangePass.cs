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

namespace globcom
{
    public partial class ChangePass : Form
    {
        string username = ForgetPass.to;

        SqlConnection con;

        public ChangePass()
        {
            InitializeComponent();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            newpass.Clear();
            panelemail.BackColor = Color.FromArgb(78, 184, 206);
            newpass.ForeColor = Color.FromArgb(78, 184, 206);
            panelver.BackColor = Color.WhiteSmoke;
            confirmpass.ForeColor = Color.WhiteSmoke;
        }

        private void txtconpass_Click(object sender, EventArgs e)
        {
            confirmpass.Clear();
            panelver.BackColor = Color.FromArgb(78, 184, 206);
            confirmpass.ForeColor = Color.FromArgb(78, 184, 206);
            panelemail.BackColor = Color.WhiteSmoke;
            newpass.ForeColor = Color.WhiteSmoke;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);

        }

        private void restbtn_Click(object sender, EventArgs e)
        {
          string cnfrmpwd, newpwd;
            

         cnfrmpwd = this.confirmpass.Text.Trim().Replace("'", "''");
            newpwd = this.newpass.Text.Trim().Replace("'", "''");

            con.Open();

            if (newpass.Text == confirmpass.Text)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Login SET pwd='"+ cnfrmpwd+"' where usrnm_email='"+username+"'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Password Reset Successfully");
                confirmpass.Clear();
                newpass.Clear();
                Form1 lognFrm = new Form1();
                lognFrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Passwords are not matching..!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
