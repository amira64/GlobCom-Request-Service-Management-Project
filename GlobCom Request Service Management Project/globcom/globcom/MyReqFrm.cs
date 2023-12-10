using System;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
using System.Drawing.Printing;
using System.IO;
using System.Xml.Linq;

namespace globcom
{
    public partial class MyReqFrm : Form
    {
        SqlConnection con;

        public MyReqFrm()
        {
            InitializeComponent();
        }

        private void MyReqFrm_Load(object sender, EventArgs e)
        {

            string strcon = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
            con = new SqlConnection(strcon);

            showcmpId();
        }

        void showall()
        {

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            string slctreq = "SELECT c.company_id[Cmompany ID], company_name[Cmompany Name],request_id[Request ID],request_name [Request Name],description [Description],request_date[Request Date],request_time[Request Time],status[Status] FROM Request r left join Companies c  on r.company_id=c.company_id where r.company_id=" + this.cmpidlbl.Text;

            SqlDataAdapter da = new SqlDataAdapter(slctreq, con);


            DataSet ds = new DataSet();

            try
            {
                da.Fill(ds, "req");

                this.dataGridView1.DataSource = ds;
                this.dataGridView1.DataMember = "req";
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

            this.infolbl.Text = this.dataGridView1.Rows.Count - 0 + " Record(s) Found...!";
        }

        void showcmpId()
        {
            string sql = "SELECT company_id FROM Companies c, Login l  where  c.email=l.usrnm_email and l.usrnm_email='" + Form1.EmailId + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    cmpidlbl.Text = dr[0].ToString();
                }

            }
            con.Close();
            cmd.Dispose();
        }

        private void shwbtn_Click(object sender, EventArgs e)
        {
            showall();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = cmpidlbl.Text+".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGridView1.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    //pdfTable.AddCell(cell.Value.ToString());
                                    pdfTable.AddCell(Convert.ToString(cell.Value));
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
