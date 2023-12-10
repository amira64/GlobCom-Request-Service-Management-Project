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
using System.Reflection.Emit;
using System.Reflection;

namespace globcom
{
    public partial class UpdateProfile : Form
    {
        SqlConnection con;

        public UpdateProfile()
        {
            InitializeComponent();
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);

            cnbtn.Hide();
            savebtn.Hide();
            companynmtxt.ForeColor=Color.Gray;
            phonetxt.ForeColor = Color.Gray;
            phone2txt.ForeColor = Color.Gray;
            emailtxt.ForeColor = Color.Gray;
            location.ForeColor = Color.Gray;
            txtpass.ForeColor = Color.Gray;

            panel1.Hide();
            panelemail.Hide();
            panelphone1.Hide();
            panelphone2.Hide();
            paneladdress.Hide();
            panel3.Hide();

            showAllRecords();
        }

        void showAllRecords()
        {
            string sql = "SELECT company_id,company_name,email,phone1,phone2,location,pwd,type FROM Companies c, Login l  where  c.email=l.usrnm_email and l.usrnm_email='" + Form1.EmailId + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    cmpidlbl.Text= dr[0].ToString();
                    companynmtxt.Text = dr[1].ToString();
                    emailtxt.Text = dr[2].ToString();
                    phonetxt.Text = dr[3].ToString();
                    phone2txt.Text = dr[4].ToString();
                    location.Text = dr[5].ToString();
                    txtpass.Text = dr[6].ToString();
                    typlbl.Text= dr[7].ToString();
                }


            }
            con.Close();
            cmd.Dispose();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            companynmtxt.ReadOnly = false;
            phonetxt.ReadOnly = false;
            phone2txt.ReadOnly = false;
            emailtxt.ReadOnly = false;
            location.ReadOnly = false;
            txtpass.ReadOnly = false;
            updatebtn.Hide();
            savebtn.Show();
            cnbtn.Show();
            companynmtxt.ForeColor = Color.DimGray;
            phonetxt.ForeColor = Color.DimGray;
            phone2txt.ForeColor = Color.DimGray;
            emailtxt.ForeColor = Color.DimGray;
            location.ForeColor = Color.DimGray;
            txtpass.ForeColor = Color.DimGray;

            panel1.Show();
            panelemail.Show();
            panelphone1.Show();
            panelphone2.Show();
            paneladdress.Show();
            panel3.Show();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (this.companynmtxt.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "* Please type mandatory fields!";
                this.cmpnmlbl.Text = "*";
                cmpnmlbl.ForeColor = Color.Red;
                this.companynmtxt.Focus();
                return;
            }
            else
            {
                this.cmpnmlbl.Text = "";
                this.infolbl.Text = "";
            }
            if (this.phonetxt.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "* Please type mandatory fields!";
                this.phn1lbl.Text = "*";
                phn1lbl.ForeColor = Color.Red;
                this.phonetxt.Focus();
                return;
            }
            else
            {
                this.phn1lbl.Text = "";
                this.infolbl.Text = "";
            }

            if (this.phone2txt.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "* Please type mandatory fields!";
                this.phn2lbl.Text = "*";
                phn2lbl.ForeColor = Color.Red;
                this.phone2txt.Focus();
                return;
            }
            else
            {
                this.phn2lbl.Text = "";
                this.infolbl.Text = "";
            }

            if (this.emailtxt.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "* Please type mandatory fields!";
                this.emllbl.Text = "*";
                emllbl.ForeColor = Color.Red;
                this.emailtxt.Focus();
                return;
            }
            else
            {
                this.emllbl.Text = "";
                this.infolbl.Text = "";
            }

            if (this.location.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "* Please type mandatory fields!";
                this.adrslbl.Text = "*";
                adrslbl.ForeColor = Color.Red;
                this.location.Focus();
                return;
            }
            else
            {
                this.adrslbl.Text = "";
                this.infolbl.Text = "";
            }

            if (this.txtpass.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "* Please type mandatory fields!";
                this.pwdlbl.Text = "*";
                pwdlbl.ForeColor = Color.Red;
                this.location.Focus();
                return;
            }
            else
            {
                this.pwdlbl.Text = "";
                this.infolbl.Text = "";
            }


            string companyname, email, location,pwd;
            int cmpanyid, phone1, phone2;

            companyname = this.companynmtxt.Text.Trim().Replace("'", "''");
            email = this.emailtxt.Text.Trim().Replace("'", "''");
            location = this.location.Text.Trim().Replace("'", "''");
            cmpanyid = Convert.ToInt32(this.cmpidlbl.Text);
            phone1 = Convert.ToInt32(this.phonetxt.Text);
            phone2 = Convert.ToInt32(this.phone2txt.Text);
            pwd = this.txtpass.Text.Trim().Replace("'", "''");

            string sqlUPDATEQuery = "UPDATE Companies SET company_name='" + companyname + "', location='" + location + "',email='" + email + "',phone1=" + phone1 + ",  phone2=" + phone2 + "  Where company_id=" + Convert.ToInt32(cmpidlbl.Text);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(sqlUPDATEQuery, con);

            int cnt = 0;

            try
            {
                cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    string pwdUPDATEQuery = "UPDATE Login SET pwd = '" + pwd + "'from Companies c inner join Login l ON c.email = l.usrnm_email Where company_id = '" + Convert.ToInt32(cmpidlbl.Text) + "'";

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd2 = new SqlCommand(pwdUPDATEQuery, con);

                    int cnt2 = 0;

                    try
                    {
                        cnt2 = cmd2.ExecuteNonQuery();
                        if (cnt2 > 0)
                        {
                            this.infolbl.Text = "Records Updated Succesfully..!";
                        }
                        else
                        {
                            this.infolbl.Text = "Process Aborted...!";
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
                    this.infolbl.Text = "Records Updated Succesfully..!";
                    updatebtn.Show();
                    savebtn.Hide();


                }
                else
                {
                    this.infolbl.Text = "Process Aborted...!";
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

        private void typlbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showAllRecords();
            savebtn.Hide();
            updatebtn.Show();
            infolbl.Text = "";
            this.Hide();
        }
    }
}
