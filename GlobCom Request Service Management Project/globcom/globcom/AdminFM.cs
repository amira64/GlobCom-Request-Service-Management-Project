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
    public partial class AdminFM : Form
    {
        SqlConnection con;

        public AdminFM()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinmizePic_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            lblPro.Visible = true;
            lblReq.Visible = false;
            lbllogout.Visible = false;
            label5.Visible = false;
            panelProfile.Visible = true;
            ConfirmPanel.Visible = false;
            HomePanel.Visible = false;

            EMPFM empsrvFrm = new EMPFM { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelProfile.Controls.Add(empsrvFrm);
            empsrvFrm.Show();
            //EMPFM mpfrm = new EMPFM();
            //lblUser.Text = empsrvFrm.adnm.Text;
        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = true;
            lbllogout.Visible = false;
            label5.Visible = false;
            panelProfile.Visible = true;
            ConfirmPanel.Visible = true;
            HomePanel.Visible = false;

            StatueFrm statuefrm =new StatueFrm   { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ConfirmPanel.Controls.Add(statuefrm);
            statuefrm.Show();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = false;
            lbllogout.Visible = true;

            Form1 log = new Form1();
            log.Show();
            this.Hide();
            log.logoutmsglbl.Text = "You logged out successfuly!";
        }

        private void panelProfile_Paint(object sender, PaintEventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = false;
            lbllogout.Visible = false;

        }

        private void ConfirmPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelManu_Paint(object sender, PaintEventArgs e)
        {
            /*EMPFM mpfrm = new EMPFM();
            lblUser.Text = mpfrm.adnm.Text;*/
        }

        private void Hombtn_Click(object sender, EventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = false;
            lbllogout.Visible = false;
            label5.Visible = true;
            panelProfile.Visible = false;
            ConfirmPanel.Visible = false;
            HomePanel.Visible = true;

            HomeFrm homefrm = new HomeFrm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomePanel.Controls.Add(homefrm);
            homefrm.Show();

            /*EMPFM mpfrm = new EMPFM();
            lblUser.Text = mpfrm.adnm.Text;*/
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);

            admnName();

            HomeFrm homefrm = new HomeFrm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomePanel.Controls.Add(homefrm);
            homefrm.Show();

            lblUser.Text = adnm.Text;
        }

        void admnName()
        {
            string sql = "SELECT employee_id,first_name FROM Employees e, Login l  where  e.email=l.usrnm_email and l.usrnm_email='" + Form1.EmailId + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    adnm.Text = dr[1].ToString();
                }


            }
            con.Close();
            cmd.Dispose();
        }

    }
}
