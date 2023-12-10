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

namespace globcom
{
    public partial class RequestFrm : Form
    {
        SqlConnection con;

        public RequestFrm()
        {
            InitializeComponent();
        }

        private void txtdesc_Click(object sender, EventArgs e)
        {
            desctxt.Clear();
            desctxt.ForeColor = Color.FromArgb(78, 184, 206);
        }

        private void RequestFrm_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);

            //desctxt.Text = "location, number of members, ...etc";

            dtNowlbl.Text = DateTime.Now.ToString("dd-MM-yyyy");
            timeNowlbl.Text = DateTime.Now.ToString("HH:mm:ss");

            getIncrementReqID();
            showcompID();
        }

        void showcompID()
        {
            string sql = "SELECT company_id FROM Companies c, Login l  where  c.email=l.usrnm_email and l.usrnm_email='" + Form1.EmailId + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    cmpnyid.Text = dr[0].ToString();
                }


            }
            con.Close();
            cmd.Dispose();
        }

        void getIncrementReqID()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string reqIDsql = "select MAX(request_id) from Request";
                SqlCommand cmdreqID = new SqlCommand(reqIDsql, con);
                var maxid = cmdreqID.ExecuteScalar() as string;

                if (maxid == null)
                {
                    reqID.Text = "REQ-1";
                }
                else
                {
                    int num = int.Parse(maxid.Substring(4, 1));
                    num++;
                    reqID.Text = string.Format("REQ-{0:0}", num);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                this.infolbl.Text = ex.Message;
            }
        }

        private void sndbtn_Click(object sender, EventArgs e)
        {
            if (srvtypecomb.Items.Equals("Select.."))
            {
                reqsrvlbl.Text = "*";
                reqsrvlbl.ForeColor = Color.Red;
                this.infolbl.Text = "* Please Fill mandatory fields!";
                infolbl.ForeColor = Color.Red;
            }
            else if (dtfromlbl.Text == "")
            {
                dtfromlbl.Text = "*";
                dtfromlbl.ForeColor = Color.Red;
                this.infolbl.Text = "* Please Fill mandatory fields!";
                infolbl.ForeColor = Color.Red;
            }
            else if (dtolbl.Text == "")
            {
                dtolbl.Text = "*";
                dtolbl.ForeColor = Color.Red;
                this.infolbl.Text = "* Please Fill mandatory fields!";
                infolbl.ForeColor = Color.Red;
            }

            else if (desctxt.Text == "")
            {
                dsclbl.Text = "*";
                dsclbl.ForeColor = Color.Red;
                this.infolbl.Text = "* Please Fill mandatory fields!";
                infolbl.ForeColor = Color.Red;
            }
            else
            {
                infolbl.Text = "";

                string srvtype = "Request for Service: " + srvtypecomb.Text + "\n\n Date From:" + dateTimePickerFrom.Text + "\n\n Date To:" + dateTimePickerTo.Text + "\n\n Service Description:\n" + desctxt.Text;
                string nm = "Confirm Request";
                MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                DialogResult res = MessageBox.Show(srvtype, nm, btn, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {


                    string srvctype, dsc, reqid;
                    string status = "Pending...";
                    string dtFrom, dtTo;
                    int cmpid;

                    srvctype = this.srvtypecomb.Text.Trim().Replace("'", "''");
                    reqid = this.reqID.Text.Trim().Replace("'", "''");
                    dtFrom = this.dtfromlbl.Text.Trim().Replace("'", "''");
                    dtTo = this.dtolbl.Text.Trim().Replace("'", "''");
                    dsc = this.desctxt.Text.Trim().Replace("'", "''");
                    cmpid = int.Parse(this.cmpnyid.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string insrtreq = "insert into Request(request_id,request_name,status,description,company_id, request_date, request_time) " +
                     "values('" + reqid + "','" + srvctype + "','" + status + "','" + dsc + "','"+ cmpid +"','"+ dtNowlbl.Text + "','" + timeNowlbl.Text + "')";


                    SqlCommand cmdreq = new SqlCommand(insrtreq, con);

                    int cntreq = 0;
                    try
                    {
                        cntreq = cmdreq.ExecuteNonQuery();
                        if (cntreq > 0)
                        {
                            this.infolbl.Text = "Request for a service has been sent !";
                            infolbl.ForeColor = Color.Blue;
                            desctxt.Clear();

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
                        cmdreq.Dispose();
                    }





                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string insrtsrv = "insert into Services(service_name,service_startDate,service_endDate,request_id) " +
                     "values('" + srvctype + "','" + dtFrom + "','" + dtTo + "','" + reqid + "')";


                    SqlCommand cmdsrv = new SqlCommand(insrtsrv, con);

                    int cntsrv = 0;
                    try
                    {
                        cntsrv = cmdsrv.ExecuteNonQuery();
                        if (cntsrv > 0)
                        {
                            this.infolbl.Text = "Request for a service has been sent !";
                            infolbl.ForeColor = Color.Blue;

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
                        cmdsrv.Dispose();
                    }

                    getIncrementReqID();

                }
                else
                {
                    this.Close();
                }
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
            dtfromlbl.Text = dateTimePickerFrom.Text;
            dtfromlbl.Visible = false;
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
            dtolbl.Text = dateTimePickerTo.Text;
            dtolbl.Visible = false;
        }
    }
}
