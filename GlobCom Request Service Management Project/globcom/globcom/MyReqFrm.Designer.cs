namespace globcom
{
    partial class MyReqFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.infolbl = new System.Windows.Forms.Label();
            this.cmpidlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shwbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1272, 474);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 35;
            this.label1.Text = "Show All  Requests";
            // 
            // infolbl
            // 
            this.infolbl.AutoSize = true;
            this.infolbl.Location = new System.Drawing.Point(27, 507);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(0, 16);
            this.infolbl.TabIndex = 36;
            // 
            // cmpidlbl
            // 
            this.cmpidlbl.AutoSize = true;
            this.cmpidlbl.Location = new System.Drawing.Point(14, 20);
            this.cmpidlbl.Name = "cmpidlbl";
            this.cmpidlbl.Size = new System.Drawing.Size(44, 16);
            this.cmpidlbl.TabIndex = 37;
            this.cmpidlbl.Text = "cmpid";
            this.cmpidlbl.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::globcom.Properties.Resources.icons8_send_to_printer_961;
            this.pictureBox1.Location = new System.Drawing.Point(1137, 587);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // shwbtn
            // 
            this.shwbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.shwbtn.Font = new System.Drawing.Font("Arial", 10.5F);
            this.shwbtn.Location = new System.Drawing.Point(300, 42);
            this.shwbtn.Name = "shwbtn";
            this.shwbtn.Size = new System.Drawing.Size(97, 49);
            this.shwbtn.TabIndex = 38;
            this.shwbtn.Text = "Show";
            this.shwbtn.UseVisualStyleBackColor = false;
            this.shwbtn.Click += new System.EventHandler(this.shwbtn_Click);
            // 
            // MyReqFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1294, 691);
            this.Controls.Add(this.shwbtn);
            this.Controls.Add(this.cmpidlbl);
            this.Controls.Add(this.infolbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyReqFrm";
            this.Text = "MyReqFrm";
            this.Load += new System.EventHandler(this.MyReqFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.Label cmpidlbl;
        private System.Windows.Forms.Button shwbtn;
    }
}