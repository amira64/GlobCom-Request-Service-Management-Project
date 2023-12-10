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
    public partial class EMPFM : Form
    {
        SqlConnection con;

        public EMPFM()
        {
            InitializeComponent();
        }

        private void EMPFM_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);

            showPendingService();
            dept();
            //admnName();
        }

        void showPendingService()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string slcsrv = "select s.service_id[Service ID],s.service_name[Service Name],s.service_startDate[Service Start Date],s.service_endDate [Service end Date],r.description [Description],c.company_name [Company Name],r.status [Status]  from Services s inner join Request r on s.request_id=r.request_id inner join Companies c on r.company_id=c.company_id where r.status='Pending...'";

            SqlDataAdapter da = new SqlDataAdapter(slcsrv, con);


            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds, "srv");

                this.srvdtgrid.DataSource = ds;
                this.srvdtgrid.DataMember = "srv";
            }
            catch (Exception ex)
            {
                this.infolbl.Text = ex.Message;
            }
            finally
            {
                con.Close();
                da.Dispose();
                ds.Dispose();
            }
        }

        /*void admnName()
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
        }*/

        private void srvdtgrid_Click(object sender, EventArgs e)
        {
            this.srvidlbl.Text = this.srvdtgrid.SelectedRows[0].Cells[0].Value.ToString();
            this.srvnmlbl.Text = this.srvdtgrid.SelectedRows[0].Cells[1].Value.ToString().Trim();
            this.cmpnmlbl.Text = this.srvdtgrid.SelectedRows[0].Cells[5].Value.ToString().Trim();
        }

        void showEmpbydept(string SN)
        {


            if (this.deptcombox.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "Please Choose dept..!";
                this.Focus();
                return;
            }
            else
            {
                this.infolbl.Text = "";
            }


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string slctemp = "select * from Employees where department='" + SN + "'";

            SqlDataAdapter da = new SqlDataAdapter(slctemp, con);
            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds, "emp");
                this.empdtgrid.DataSource = ds;
                this.empdtgrid.DataMember = "emp";
            }
            catch (Exception ex)
            {
                this.infolbl.Text = ex.Message;
            }
            finally
            {
                con.Close();
                da.Dispose();
                ds.Dispose();
            }
        }

        private void deptcombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dept = this.deptcombox.Text.Trim().Replace("'", "''");
            showEmpbydept(dept);
        }

        void dept()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string deptqry = "select distinct department from Employees order by department";

            SqlCommand cmd = new SqlCommand(deptqry, con);
            SqlDataReader sr;

            try
            {
                sr = cmd.ExecuteReader();
                while (sr.Read())
                {
                    deptcombox.Items.Add(sr["department"]);
                }
                sr.Close();
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

        private void empdtgrid_Click(object sender, EventArgs e)
        {
            this.empidlbl.Text = this.empdtgrid.SelectedRows[0].Cells[0].Value.ToString().Trim();
            this.empnmlbl.Text = this.empdtgrid.SelectedRows[0].Cells[1].Value.ToString().Trim() + " " + this.empdtgrid.SelectedRows[0].Cells[2].Value.ToString().Trim() + " " + this.empdtgrid.SelectedRows[0].Cells[3].Value.ToString().Trim();
        }

        private void applybtn_Click(object sender, EventArgs e)
        {
            if (srvidlbl.Text.Trim().Length == 0 || srvnmlbl.Text.Trim().Length == 0 || cmpnmlbl.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "Please Choose a Service..!";
            }
            else if (empidlbl.Text.Trim().Length == 0 || empnmlbl.Text.Trim().Length == 0)
            {
                this.infolbl.Text = "Please Choose an Employee..!";
            }
            else
            {
                this.infolbl.Text = "";
            }

            string empid;
            int srvid;

            srvid = int.Parse(this.srvidlbl.Text);
            empid = this.empidlbl.Text.Trim().Replace("'", "''");

            string svEmpSrv = "insert into EmpService(emp_id,service_id) values('" + empid + "'," + srvid + ")";


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(svEmpSrv, con);
            int cnt = 0;

            try
            {
                cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    this.infolbl.Text = "Record of Service no. " + srvid + " is Applies Successfully !";
                    clearCntrls();
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

        void clearCntrls()
        {
            srvidlbl.Text = "";
            srvnmlbl.Text = "";
            cmpnmlbl.Text = "";
            empidlbl.Text = "";
            empnmlbl.Text = "";
        }
    }
}
