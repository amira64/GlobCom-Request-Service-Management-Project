using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace globcom
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            lblPro.Visible = true;
            lblReq.Visible = false;
            lbllogout.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            panelProfile.Visible = true;
            Reqiestpnl.Visible = false;
            updatePanel.Visible = false;
            HomePanel.Visible = false;
          
            UpdateProfile prfile = new UpdateProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelProfile.Controls.Add(prfile);
            prfile.Show();
           


        }

        private void btnReq_Click(object sender, EventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = true;
            lbllogout.Visible = false;
            label4.Visible = false;
            panelProfile.Visible = true;
            updatePanel.Visible = true;
            Reqiestpnl.Visible = false;
            HomePanel.Visible = false;

           RequestFrm reqfrm = new RequestFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            updatePanel.Controls.Add(reqfrm);
            reqfrm.Show();
           

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = false;
            label4.Visible = false;
            lbllogout.Visible = true;
            Form1 log = new Form1();
            log.Show();
            this.Hide();
            log.logoutmsglbl.Text = "You logged out successfuly!";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;


        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
           pictureBox9.BackColor = Color.Red;
        }

        private void pictureBox9_Move(object sender, EventArgs e)
        {

        }

        private void Reqiestpnl_Paint(object sender, PaintEventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = false;
            lbllogout.Visible = false;
            label4.Visible = false;
            panelProfile.Visible = true;
            Reqiestpnl.Visible = false;
            updatePanel.Visible = false;

            UpdateProfile profile = new UpdateProfile() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            panelProfile.Controls.Add(profile);
            profile.Show();
            lblUser.Text=profile.companynmtxt.Text;
            lblstat.Text = profile.typlbl.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible =false;
            label4.Visible = true;
            lbllogout.Visible = false;
            label5.Visible = false;

            panelProfile.Visible = false;
            HomePanel.Visible = false;
            Reqiestpnl.Visible = true;

            MyReqFrm myreqfrm = new MyReqFrm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Reqiestpnl.Controls.Add(myreqfrm);
            myreqfrm.Show();
        }

        private void panelManu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Hombtn_Click(object sender, EventArgs e)
        {
            lblPro.Visible = false;
            lblReq.Visible = false;
            lbllogout.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            panelProfile.Visible = false;
            HomePanel.Visible = true;
            Reqiestpnl.Visible = false;

            HomeFrm homefrm = new HomeFrm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomePanel.Controls.Add(homefrm);
            homefrm.Show();
        }

        private void HomePanel_Paint(object sender, PaintEventArgs e)
        {
            HomeFrm homefrm = new HomeFrm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            HomePanel.Controls.Add(homefrm);
            homefrm.Show();
        }
    }
}
