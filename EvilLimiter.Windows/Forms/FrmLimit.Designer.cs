namespace EvilLimiter.Windows.Forms
{
    partial class FrmLimit
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
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.tbUploadRate = new System.Windows.Forms.TextBox();
            this.cmbUploadRate = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.tbUploadBurst = new System.Windows.Forms.TextBox();
            this.cmbUploadBurst = new System.Windows.Forms.ComboBox();
            this.tglUpload = new System.Windows.Forms.CheckBox();
            this.tglDownload = new System.Windows.Forms.CheckBox();
            this.metroLabel5 = new System.Windows.Forms.Label();
            this.tbDownloadRate = new System.Windows.Forms.TextBox();
            this.metroLabel6 = new System.Windows.Forms.Label();
            this.tbDownloadBurst = new System.Windows.Forms.TextBox();
            this.cmbDownloadRate = new System.Windows.Forms.ComboBox();
            this.cmbDownloadBurst = new System.Windows.Forms.ComboBox();
            this.cbUploadBurst = new System.Windows.Forms.CheckBox();
            this.cbDownloadBurst = new System.Windows.Forms.CheckBox();
            this.btnLimit = new System.Windows.Forms.Button();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.pnlDownload = new System.Windows.Forms.Panel();
            this.pnlUpload.SuspendLayout();
            this.pnlDownload.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Enabled = false;
            this.metroLabel1.Location = new System.Drawing.Point(1, 1);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(30, 13);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Rate";
            // 
            // tbUploadRate
            // 
            this.tbUploadRate.Location = new System.Drawing.Point(1, 26);
            this.tbUploadRate.Name = "tbUploadRate";
            this.tbUploadRate.Size = new System.Drawing.Size(120, 20);
            this.tbUploadRate.TabIndex = 1;
            // 
            // cmbUploadRate
            // 
            this.cmbUploadRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUploadRate.FormattingEnabled = true;
            this.cmbUploadRate.ItemHeight = 13;
            this.cmbUploadRate.Location = new System.Drawing.Point(127, 26);
            this.cmbUploadRate.Name = "cmbUploadRate";
            this.cmbUploadRate.Size = new System.Drawing.Size(82, 21);
            this.cmbUploadRate.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(1, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 13);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Burst (optional)";
            // 
            // tbUploadBurst
            // 
            this.tbUploadBurst.Enabled = false;
            this.tbUploadBurst.Location = new System.Drawing.Point(1, 88);
            this.tbUploadBurst.Name = "tbUploadBurst";
            this.tbUploadBurst.Size = new System.Drawing.Size(120, 20);
            this.tbUploadBurst.TabIndex = 1;
            // 
            // cmbUploadBurst
            // 
            this.cmbUploadBurst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUploadBurst.Enabled = false;
            this.cmbUploadBurst.FormattingEnabled = true;
            this.cmbUploadBurst.ItemHeight = 13;
            this.cmbUploadBurst.Location = new System.Drawing.Point(127, 87);
            this.cmbUploadBurst.Name = "cmbUploadBurst";
            this.cmbUploadBurst.Size = new System.Drawing.Size(82, 21);
            this.cmbUploadBurst.TabIndex = 2;
            // 
            // tglUpload
            // 
            this.tglUpload.AutoSize = true;
            this.tglUpload.Location = new System.Drawing.Point(21, 18);
            this.tglUpload.Name = "tglUpload";
            this.tglUpload.Size = new System.Drawing.Size(60, 17);
            this.tglUpload.TabIndex = 4;
            this.tglUpload.Text = "Upload";
            this.tglUpload.CheckedChanged += new System.EventHandler(this.TglUpload_CheckedChanged);
            // 
            // tglDownload
            // 
            this.tglDownload.AutoSize = true;
            this.tglDownload.Location = new System.Drawing.Point(259, 18);
            this.tglDownload.Name = "tglDownload";
            this.tglDownload.Size = new System.Drawing.Size(74, 17);
            this.tglDownload.TabIndex = 4;
            this.tglDownload.Text = "Download";
            this.tglDownload.CheckedChanged += new System.EventHandler(this.TglDownload_CheckedChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(2, 2);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(30, 13);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Rate";
            // 
            // tbDownloadRate
            // 
            this.tbDownloadRate.Location = new System.Drawing.Point(1, 26);
            this.tbDownloadRate.Name = "tbDownloadRate";
            this.tbDownloadRate.Size = new System.Drawing.Size(120, 20);
            this.tbDownloadRate.TabIndex = 1;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(2, 64);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(77, 13);
            this.metroLabel6.TabIndex = 0;
            this.metroLabel6.Text = "Burst (optional)";
            // 
            // tbDownloadBurst
            // 
            this.tbDownloadBurst.Enabled = false;
            this.tbDownloadBurst.Location = new System.Drawing.Point(1, 88);
            this.tbDownloadBurst.Name = "tbDownloadBurst";
            this.tbDownloadBurst.Size = new System.Drawing.Size(120, 20);
            this.tbDownloadBurst.TabIndex = 1;
            // 
            // cmbDownloadRate
            // 
            this.cmbDownloadRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownloadRate.FormattingEnabled = true;
            this.cmbDownloadRate.ItemHeight = 13;
            this.cmbDownloadRate.Location = new System.Drawing.Point(127, 26);
            this.cmbDownloadRate.Name = "cmbDownloadRate";
            this.cmbDownloadRate.Size = new System.Drawing.Size(83, 21);
            this.cmbDownloadRate.TabIndex = 2;
            // 
            // cmbDownloadBurst
            // 
            this.cmbDownloadBurst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDownloadBurst.Enabled = false;
            this.cmbDownloadBurst.FormattingEnabled = true;
            this.cmbDownloadBurst.ItemHeight = 13;
            this.cmbDownloadBurst.Location = new System.Drawing.Point(127, 87);
            this.cmbDownloadBurst.Name = "cmbDownloadBurst";
            this.cmbDownloadBurst.Size = new System.Drawing.Size(83, 21);
            this.cmbDownloadBurst.TabIndex = 2;
            // 
            // cbUploadBurst
            // 
            this.cbUploadBurst.AutoSize = true;
            this.cbUploadBurst.Location = new System.Drawing.Point(84, 64);
            this.cbUploadBurst.Name = "cbUploadBurst";
            this.cbUploadBurst.Size = new System.Drawing.Size(29, 17);
            this.cbUploadBurst.TabIndex = 5;
            this.cbUploadBurst.Text = " ";
            this.cbUploadBurst.CheckedChanged += new System.EventHandler(this.CbUploadBurst_CheckedChanged);
            // 
            // cbDownloadBurst
            // 
            this.cbDownloadBurst.AutoSize = true;
            this.cbDownloadBurst.Location = new System.Drawing.Point(84, 64);
            this.cbDownloadBurst.Name = "cbDownloadBurst";
            this.cbDownloadBurst.Size = new System.Drawing.Size(29, 17);
            this.cbDownloadBurst.TabIndex = 5;
            this.cbDownloadBurst.Text = " ";
            this.cbDownloadBurst.CheckedChanged += new System.EventHandler(this.CbDownloadBurst_CheckedChanged);
            // 
            // btnLimit
            // 
            this.btnLimit.Location = new System.Drawing.Point(394, 209);
            this.btnLimit.Name = "btnLimit";
            this.btnLimit.Size = new System.Drawing.Size(83, 23);
            this.btnLimit.TabIndex = 6;
            this.btnLimit.Text = "Limit";
            this.btnLimit.Click += new System.EventHandler(this.BtnLimit_Click);
            // 
            // pnlUpload
            // 
            this.pnlUpload.Controls.Add(this.cmbUploadRate);
            this.pnlUpload.Controls.Add(this.cbUploadBurst);
            this.pnlUpload.Controls.Add(this.metroLabel1);
            this.pnlUpload.Controls.Add(this.tbUploadRate);
            this.pnlUpload.Controls.Add(this.metroLabel2);
            this.pnlUpload.Controls.Add(this.tbUploadBurst);
            this.pnlUpload.Controls.Add(this.cmbUploadBurst);
            this.pnlUpload.Enabled = false;
            this.pnlUpload.Location = new System.Drawing.Point(20, 48);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(219, 147);
            this.pnlUpload.TabIndex = 7;
            // 
            // pnlDownload
            // 
            this.pnlDownload.Controls.Add(this.tbDownloadRate);
            this.pnlDownload.Controls.Add(this.cbDownloadBurst);
            this.pnlDownload.Controls.Add(this.metroLabel5);
            this.pnlDownload.Controls.Add(this.metroLabel6);
            this.pnlDownload.Controls.Add(this.tbDownloadBurst);
            this.pnlDownload.Controls.Add(this.cmbDownloadRate);
            this.pnlDownload.Controls.Add(this.cmbDownloadBurst);
            this.pnlDownload.Enabled = false;
            this.pnlDownload.Location = new System.Drawing.Point(259, 48);
            this.pnlDownload.Name = "pnlDownload";
            this.pnlDownload.Size = new System.Drawing.Size(218, 146);
            this.pnlDownload.TabIndex = 8;
            // 
            // FrmLimit
            // 
            this.AcceptButton = this.btnLimit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 249);
            this.Controls.Add(this.pnlDownload);
            this.Controls.Add(this.pnlUpload);
            this.Controls.Add(this.btnLimit);
            this.Controls.Add(this.tglDownload);
            this.Controls.Add(this.tglUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLimit";
            this.ShowInTaskbar = false;
            this.Text = "Limit";
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            this.pnlDownload.ResumeLayout(false);
            this.pnlDownload.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.TextBox tbUploadRate;
        private System.Windows.Forms.ComboBox cmbUploadRate;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.TextBox tbUploadBurst;
        private System.Windows.Forms.ComboBox cmbUploadBurst;
        private System.Windows.Forms.CheckBox tglUpload;
        private System.Windows.Forms.CheckBox tglDownload;
        private System.Windows.Forms.Label metroLabel5;
        private System.Windows.Forms.TextBox tbDownloadRate;
        private System.Windows.Forms.Label metroLabel6;
        private System.Windows.Forms.TextBox tbDownloadBurst;
        private System.Windows.Forms.ComboBox cmbDownloadRate;
        private System.Windows.Forms.ComboBox cmbDownloadBurst;
        private System.Windows.Forms.CheckBox cbUploadBurst;
        private System.Windows.Forms.CheckBox cbDownloadBurst;
        private System.Windows.Forms.Button btnLimit;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.Panel pnlDownload;
    }
}