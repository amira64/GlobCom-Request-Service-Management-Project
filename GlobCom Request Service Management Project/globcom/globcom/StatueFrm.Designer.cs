namespace globcom
{
    partial class StatueFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatueFrm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statuscombo = new System.Windows.Forms.ComboBox();
            this.srchbtn = new System.Windows.Forms.Button();
            this.edtstatbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.company_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.service_endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infolbl = new System.Windows.Forms.Label();
            this.compnmlbl = new System.Windows.Forms.Label();
            this.compemaillbl = new System.Windows.Forms.Label();
            this.comphonlbl = new System.Windows.Forms.Label();
            this.complocationlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reqidlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picaddress = new System.Windows.Forms.PictureBox();
            this.pivphone = new System.Windows.Forms.PictureBox();
            this.picemail = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picaddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivphone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picemail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(67, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Company Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(67, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 56;
            this.label3.Text = "Company Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(67, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Company Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(496, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Status:";
            // 
            // statuscombo
            // 
            this.statuscombo.BackColor = System.Drawing.SystemColors.Menu;
            this.statuscombo.Font = new System.Drawing.Font("Arial", 10.2F);
            this.statuscombo.FormattingEnabled = true;
            this.statuscombo.Items.AddRange(new object[] {
            "Pending...",
            "Processing...",
            "Rejected",
            "Finished"});
            this.statuscombo.Location = new System.Drawing.Point(580, 162);
            this.statuscombo.Name = "statuscombo";
            this.statuscombo.Size = new System.Drawing.Size(251, 27);
            this.statuscombo.TabIndex = 59;
            this.statuscombo.Text = "Select..";
            this.statuscombo.SelectedIndexChanged += new System.EventHandler(this.statuscombo_SelectedIndexChanged);
            // 
            // srchbtn
            // 
            this.srchbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.srchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srchbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.srchbtn.Location = new System.Drawing.Point(580, 259);
            this.srchbtn.Name = "srchbtn";
            this.srchbtn.Size = new System.Drawing.Size(251, 35);
            this.srchbtn.TabIndex = 61;
            this.srchbtn.Text = "Search Request by Status";
            this.srchbtn.UseVisualStyleBackColor = false;
            this.srchbtn.Click += new System.EventHandler(this.srchbtn_Click);
            // 
            // edtstatbtn
            // 
            this.edtstatbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.edtstatbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edtstatbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtstatbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.edtstatbtn.Location = new System.Drawing.Point(580, 206);
            this.edtstatbtn.Name = "edtstatbtn";
            this.edtstatbtn.Size = new System.Drawing.Size(251, 35);
            this.edtstatbtn.TabIndex = 60;
            this.edtstatbtn.Text = "Edit ";
            this.edtstatbtn.UseVisualStyleBackColor = false;
            this.edtstatbtn.Click += new System.EventHandler(this.edtstatbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company_name,
            this.service_name,
            this.request_date,
            this.request_time,
            this.Description,
            this.service_startDate,
            this.service_endDate,
            this.Status,
            this.email,
            this.phone1,
            this.phone2,
            this.location,
            this.request_id});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(22, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1433, 358);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // company_name
            // 
            this.company_name.HeaderText = "Company Name";
            this.company_name.MinimumWidth = 6;
            this.company_name.Name = "company_name";
            this.company_name.ReadOnly = true;
            this.company_name.Width = 125;
            // 
            // service_name
            // 
            this.service_name.HeaderText = "Service Name";
            this.service_name.MinimumWidth = 6;
            this.service_name.Name = "service_name";
            this.service_name.ReadOnly = true;
            this.service_name.Width = 125;
            // 
            // request_date
            // 
            this.request_date.HeaderText = "Request Date";
            this.request_date.MinimumWidth = 6;
            this.request_date.Name = "request_date";
            this.request_date.ReadOnly = true;
            this.request_date.Width = 125;
            // 
            // request_time
            // 
            this.request_time.HeaderText = "Request Time";
            this.request_time.MinimumWidth = 6;
            this.request_time.Name = "request_time";
            this.request_time.ReadOnly = true;
            this.request_time.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 125;
            // 
            // service_startDate
            // 
            this.service_startDate.HeaderText = "Service Start Date";
            this.service_startDate.MinimumWidth = 6;
            this.service_startDate.Name = "service_startDate";
            this.service_startDate.ReadOnly = true;
            this.service_startDate.Width = 125;
            // 
            // service_endDate
            // 
            this.service_endDate.HeaderText = "Service End Date";
            this.service_endDate.MinimumWidth = 6;
            this.service_endDate.Name = "service_endDate";
            this.service_endDate.ReadOnly = true;
            this.service_endDate.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Company Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            this.email.Width = 125;
            // 
            // phone1
            // 
            this.phone1.HeaderText = "Company phone1";
            this.phone1.MinimumWidth = 6;
            this.phone1.Name = "phone1";
            this.phone1.ReadOnly = true;
            this.phone1.Visible = false;
            this.phone1.Width = 125;
            // 
            // phone2
            // 
            this.phone2.HeaderText = "Company phone2";
            this.phone2.MinimumWidth = 6;
            this.phone2.Name = "phone2";
            this.phone2.ReadOnly = true;
            this.phone2.Visible = false;
            this.phone2.Width = 125;
            // 
            // location
            // 
            this.location.HeaderText = "Company Location";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Visible = false;
            this.location.Width = 125;
            // 
            // request_id
            // 
            this.request_id.HeaderText = "Request ID";
            this.request_id.MinimumWidth = 6;
            this.request_id.Name = "request_id";
            this.request_id.ReadOnly = true;
            this.request_id.Visible = false;
            this.request_id.Width = 125;
            // 
            // infolbl
            // 
            this.infolbl.AutoSize = true;
            this.infolbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolbl.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.infolbl.Location = new System.Drawing.Point(67, 343);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(0, 21);
            this.infolbl.TabIndex = 63;
            // 
            // compnmlbl
            // 
            this.compnmlbl.AutoSize = true;
            this.compnmlbl.Location = new System.Drawing.Point(261, 168);
            this.compnmlbl.Name = "compnmlbl";
            this.compnmlbl.Size = new System.Drawing.Size(44, 16);
            this.compnmlbl.TabIndex = 64;
            this.compnmlbl.Text = "label6";
            // 
            // compemaillbl
            // 
            this.compemaillbl.AutoSize = true;
            this.compemaillbl.Location = new System.Drawing.Point(261, 217);
            this.compemaillbl.Name = "compemaillbl";
            this.compemaillbl.Size = new System.Drawing.Size(44, 16);
            this.compemaillbl.TabIndex = 65;
            this.compemaillbl.Text = "label7";
            // 
            // comphonlbl
            // 
            this.comphonlbl.AutoSize = true;
            this.comphonlbl.Location = new System.Drawing.Point(261, 261);
            this.comphonlbl.Name = "comphonlbl";
            this.comphonlbl.Size = new System.Drawing.Size(44, 16);
            this.comphonlbl.TabIndex = 66;
            this.comphonlbl.Text = "label8";
            // 
            // complocationlbl
            // 
            this.complocationlbl.AutoSize = true;
            this.complocationlbl.Location = new System.Drawing.Point(261, 301);
            this.complocationlbl.Name = "complocationlbl";
            this.complocationlbl.Size = new System.Drawing.Size(44, 16);
            this.complocationlbl.TabIndex = 67;
            this.complocationlbl.Text = "label9";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(238, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(736, 99);
            this.label6.TabIndex = 69;
            this.label6.Text = "Confirm Request for a Service";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reqidlbl
            // 
            this.reqidlbl.AutoSize = true;
            this.reqidlbl.Location = new System.Drawing.Point(861, 32);
            this.reqidlbl.Name = "reqidlbl";
            this.reqidlbl.Size = new System.Drawing.Size(0, 16);
            this.reqidlbl.TabIndex = 70;
            this.reqidlbl.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(67, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "Company Name:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::globcom.Properties.Resources._61d2a28aa6934fd0b9193fd6_Cartoon_tiny_analysts_and_giant_research_dashboard_with_data_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(864, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // picaddress
            // 
            this.picaddress.Image = ((System.Drawing.Image)(resources.GetObject("picaddress.Image")));
            this.picaddress.Location = new System.Drawing.Point(35, 291);
            this.picaddress.Name = "picaddress";
            this.picaddress.Size = new System.Drawing.Size(27, 27);
            this.picaddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picaddress.TabIndex = 51;
            this.picaddress.TabStop = false;
            // 
            // pivphone
            // 
            this.pivphone.Image = ((System.Drawing.Image)(resources.GetObject("pivphone.Image")));
            this.pivphone.Location = new System.Drawing.Point(34, 250);
            this.pivphone.Name = "pivphone";
            this.pivphone.Size = new System.Drawing.Size(27, 27);
            this.pivphone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pivphone.TabIndex = 45;
            this.pivphone.TabStop = false;
            // 
            // picemail
            // 
            this.picemail.Image = ((System.Drawing.Image)(resources.GetObject("picemail.Image")));
            this.picemail.Location = new System.Drawing.Point(34, 206);
            this.picemail.Name = "picemail";
            this.picemail.Size = new System.Drawing.Size(27, 27);
            this.picemail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picemail.TabIndex = 42;
            this.picemail.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // StatueFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1461, 768);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reqidlbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.complocationlbl);
            this.Controls.Add(this.comphonlbl);
            this.Controls.Add(this.compemaillbl);
            this.Controls.Add(this.compnmlbl);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.srchbtn);
            this.Controls.Add(this.edtstatbtn);
            this.Controls.Add(this.statuscombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picaddress);
            this.Controls.Add(this.pivphone);
            this.Controls.Add(this.picemail);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatueFrm";
            this.Text = "StatueFrm";
            this.Load += new System.EventHandler(this.StatueFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picaddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivphone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picemail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picaddress;
        private System.Windows.Forms.PictureBox pivphone;
        private System.Windows.Forms.PictureBox picemail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox statuscombo;
        private System.Windows.Forms.Button srchbtn;
        private System.Windows.Forms.Button edtstatbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Label compnmlbl;
        private System.Windows.Forms.Label compemaillbl;
        private System.Windows.Forms.Label comphonlbl;
        private System.Windows.Forms.Label complocationlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label reqidlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn request_id;
    }
}