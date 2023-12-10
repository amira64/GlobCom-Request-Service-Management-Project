namespace globcom
{
    partial class RequestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.srvtypecomb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.desctxt = new System.Windows.Forms.TextBox();
            this.sndbtn = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reqID = new System.Windows.Forms.Label();
            this.timeNowlbl = new System.Windows.Forms.Label();
            this.dtNowlbl = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.reqsrvlbl = new System.Windows.Forms.Label();
            this.dtolbl = new System.Windows.Forms.Label();
            this.dtfromlbl = new System.Windows.Forms.Label();
            this.dsclbl = new System.Windows.Forms.Label();
            this.cmpnyid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(685, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Request For Service:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // srvtypecomb
            // 
            this.srvtypecomb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.srvtypecomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.srvtypecomb.FormattingEnabled = true;
            this.srvtypecomb.Items.AddRange(new object[] {
            "Create an applicaton",
            "Networking Problem",
            "Provide Trainee"});
            this.srvtypecomb.Location = new System.Drawing.Point(688, 121);
            this.srvtypecomb.Name = "srvtypecomb";
            this.srvtypecomb.Size = new System.Drawing.Size(308, 24);
            this.srvtypecomb.TabIndex = 18;
            this.srvtypecomb.Text = "Select..";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(685, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 33);
            this.label2.TabIndex = 26;
            this.label2.Text = "From:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(688, 184);
            this.dateTimePickerFrom.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(308, 22);
            this.dateTimePickerFrom.TabIndex = 27;
            this.dateTimePickerFrom.Value = new System.DateTime(2023, 4, 3, 12, 30, 7, 0);
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePickerFrom_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(685, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 33);
            this.label3.TabIndex = 28;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(688, 245);
            this.dateTimePickerTo.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(308, 22);
            this.dateTimePickerTo.TabIndex = 29;
            this.dateTimePickerTo.Value = new System.DateTime(2023, 4, 3, 12, 30, 13, 0);
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePickerTo_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(685, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "Description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // desctxt
            // 
            this.desctxt.BackColor = System.Drawing.Color.LightGray;
            this.desctxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.desctxt.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desctxt.ForeColor = System.Drawing.Color.Gray;
            this.desctxt.Location = new System.Drawing.Point(688, 306);
            this.desctxt.Multiline = true;
            this.desctxt.Name = "desctxt";
            this.desctxt.Size = new System.Drawing.Size(308, 97);
            this.desctxt.TabIndex = 31;
            this.desctxt.Text = "Enter Your Description";
            this.desctxt.Click += new System.EventHandler(this.txtdesc_Click);
            // 
            // sndbtn
            // 
            this.sndbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.sndbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sndbtn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sndbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.sndbtn.Location = new System.Drawing.Point(688, 450);
            this.sndbtn.Name = "sndbtn";
            this.sndbtn.Size = new System.Drawing.Size(308, 35);
            this.sndbtn.TabIndex = 32;
            this.sndbtn.Text = "Send Request";
            this.sndbtn.UseVisualStyleBackColor = false;
            this.sndbtn.Click += new System.EventHandler(this.sndbtn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::globcom.Properties.Resources.cjrufc17v02f1crg0zsp9gcq7_how_is_it_issue_tracking_software_used_2x_one_half;
            this.pictureBox6.Location = new System.Drawing.Point(316, 121);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(363, 363);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(793, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // reqID
            // 
            this.reqID.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reqID.ForeColor = System.Drawing.Color.Teal;
            this.reqID.Location = new System.Drawing.Point(994, 12);
            this.reqID.Name = "reqID";
            this.reqID.Size = new System.Drawing.Size(76, 28);
            this.reqID.TabIndex = 49;
            this.reqID.Text = "REQ-";
            this.reqID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeNowlbl
            // 
            this.timeNowlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNowlbl.ForeColor = System.Drawing.Color.Teal;
            this.timeNowlbl.Location = new System.Drawing.Point(313, 16);
            this.timeNowlbl.Name = "timeNowlbl";
            this.timeNowlbl.Size = new System.Drawing.Size(128, 21);
            this.timeNowlbl.TabIndex = 50;
            this.timeNowlbl.Text = "Time";
            this.timeNowlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.timeNowlbl.Visible = false;
            // 
            // dtNowlbl
            // 
            this.dtNowlbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNowlbl.ForeColor = System.Drawing.Color.Teal;
            this.dtNowlbl.Location = new System.Drawing.Point(313, 51);
            this.dtNowlbl.Name = "dtNowlbl";
            this.dtNowlbl.Size = new System.Drawing.Size(128, 21);
            this.dtNowlbl.TabIndex = 51;
            this.dtNowlbl.Text = "Date";
            this.dtNowlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtNowlbl.Visible = false;
            // 
            // infolbl
            // 
            this.infolbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infolbl.Location = new System.Drawing.Point(685, 406);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(369, 33);
            this.infolbl.TabIndex = 52;
            this.infolbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reqsrvlbl
            // 
            this.reqsrvlbl.AutoSize = true;
            this.reqsrvlbl.Location = new System.Drawing.Point(1007, 127);
            this.reqsrvlbl.Name = "reqsrvlbl";
            this.reqsrvlbl.Size = new System.Drawing.Size(0, 16);
            this.reqsrvlbl.TabIndex = 57;
            // 
            // dtolbl
            // 
            this.dtolbl.AutoSize = true;
            this.dtolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtolbl.Location = new System.Drawing.Point(1022, 249);
            this.dtolbl.Name = "dtolbl";
            this.dtolbl.Size = new System.Drawing.Size(0, 17);
            this.dtolbl.TabIndex = 56;
            // 
            // dtfromlbl
            // 
            this.dtfromlbl.AutoSize = true;
            this.dtfromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtfromlbl.Location = new System.Drawing.Point(1019, 186);
            this.dtfromlbl.Name = "dtfromlbl";
            this.dtfromlbl.Size = new System.Drawing.Size(0, 17);
            this.dtfromlbl.TabIndex = 55;
            // 
            // dsclbl
            // 
            this.dsclbl.AutoSize = true;
            this.dsclbl.Location = new System.Drawing.Point(1007, 312);
            this.dsclbl.Name = "dsclbl";
            this.dsclbl.Size = new System.Drawing.Size(0, 16);
            this.dsclbl.TabIndex = 58;
            // 
            // cmpnyid
            // 
            this.cmpnyid.AutoSize = true;
            this.cmpnyid.ForeColor = System.Drawing.Color.Teal;
            this.cmpnyid.Location = new System.Drawing.Point(316, 505);
            this.cmpnyid.Name = "cmpnyid";
            this.cmpnyid.Size = new System.Drawing.Size(77, 16);
            this.cmpnyid.TabIndex = 59;
            this.cmpnyid.Text = "company id";
            this.cmpnyid.Visible = false;
            // 
            // RequestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1082, 533);
            this.Controls.Add(this.cmpnyid);
            this.Controls.Add(this.dsclbl);
            this.Controls.Add(this.reqsrvlbl);
            this.Controls.Add(this.dtolbl);
            this.Controls.Add(this.dtfromlbl);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.dtNowlbl);
            this.Controls.Add(this.timeNowlbl);
            this.Controls.Add(this.reqID);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.sndbtn);
            this.Controls.Add(this.desctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.srvtypecomb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RequestFrm";
            this.Load += new System.EventHandler(this.RequestFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox srvtypecomb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desctxt;
        private System.Windows.Forms.Button sndbtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label reqID;
        private System.Windows.Forms.Label timeNowlbl;
        private System.Windows.Forms.Label dtNowlbl;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Label reqsrvlbl;
        private System.Windows.Forms.Label dtolbl;
        private System.Windows.Forms.Label dtfromlbl;
        private System.Windows.Forms.Label dsclbl;
        private System.Windows.Forms.Label cmpnyid;
    }
}