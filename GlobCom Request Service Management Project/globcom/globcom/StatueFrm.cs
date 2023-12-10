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
    public partial class StatueFrm : Form
    {
        SqlConnection con;

        public StatueFrm()
        {
            InitializeComponent();
        }

        private void StatueFrm_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);
            showData();

        }

        void showData()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Companies c left JOIN Request r ON c.company_id = r.company_id left join Services s on r.request_id=s.request_id", con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = item["company_name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["service_name"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["request_date"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["request_time"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["description"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["service_startDate"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["service_endDate"].ToString();
                dataGridView1.Rows[n].Cells[7].Value = item["status"].ToString();
                dataGridView1.Rows[n].Cells[8].Value = item["email"].ToString();
                dataGridView1.Rows[n].Cells[9].Value = item["phone1"].ToString();
                dataGridView1.Rows[n].Cells[10].Value = item["phone2"].ToString();
                dataGridView1.Rows[n].Cells[11].Value = item["location"].ToString();
                dataGridView1.Rows[n].Cells[12].Value = item["request_id"].ToString();

            }

        }

        private void edtstatbtn_Click(object sender, EventArgs e)
        {
            string stat;

            stat = this.statuscombo.Text.Trim().Replace("'", "''");


            string edtstatus = "update Request set status='" + stat + "' where request_id='" + this.reqidlbl.Text + "'";


            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand(edtstatus, con);
            int cnt = 0;

            try
            {
                cnt = cmd.ExecuteNonQuery();
                if (cnt > 0)
                {
                    this.infolbl.Text = "Record updated Successfully !";

                    //cleartext();

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

        private void srchbtn_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Companies c left JOIN Request r ON c.company_id = r.company_id left join Services s on r.request_id=s.request_id where status='" + statuscombo.Text + "'", con);
            DataTable dt = new DataTable();

            try
            {

                da.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    int m = dataGridView1.Rows.Add();

                    dataGridView1.Rows[m].Cells[0].Value = item["company_name"].ToString();
                    dataGridView1.Rows[m].Cells[1].Value = item["service_name"].ToString();
                    dataGridView1.Rows[m].Cells[2].Value = item["request_date"].ToString();
                    dataGridView1.Rows[m].Cells[3].Value = item["request_time"].ToString();
                    dataGridView1.Rows[m].Cells[4].Value = item["description"].ToString();
                    dataGridView1.Rows[m].Cells[5].Value = item["service_startDate"].ToString();
                    dataGridView1.Rows[m].Cells[6].Value = item["service_endDate"].ToString();
                    dataGridView1.Rows[m].Cells[7].Value = item["status"].ToString();
                    dataGridView1.Rows[m].Cells[8].Value = item["email"].ToString();
                    dataGridView1.Rows[m].Cells[9].Value = item["phone1"].ToString();
                    dataGridView1.Rows[m].Cells[10].Value = item["phone2"].ToString();
                    dataGridView1.Rows[m].Cells[11].Value = item["location"].ToString();
                    dataGridView1.Rows[m].Cells[12].Value = item["request_id"].ToString();
                }
            }
            catch (Exception ex)
            {
                this.infolbl.Text = ex.Message;
            }
            finally
            {
                con.Close();
                da.Dispose();
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.compnmlbl.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            this.compemaillbl.Text = this.dataGridView1.SelectedRows[0].Cells[8].Value.ToString().Trim();
            this.comphonlbl.Text = this.dataGridView1.SelectedRows[0].Cells[9].Value.ToString().Trim() + " / " + this.dataGridView1.SelectedRows[0].Cells[10].Value.ToString().Trim();
            this.complocationlbl.Text = this.dataGridView1.SelectedRows[0].Cells[11].Value.ToString().Trim();
            this.reqidlbl.Text = this.dataGridView1.SelectedRows[0].Cells[12].Value.ToString().Trim();

        }

        private void statuscombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
