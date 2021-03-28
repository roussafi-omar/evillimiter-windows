namespace EvilLimiter.Windows.Forms
{
    partial class FrmScan
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
            this.tbIpRange = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.metroLabel4 = new System.Windows.Forms.Label();
            this.lblSubnetRange = new System.Windows.Forms.Label();
            this.rbtnCustomRange = new System.Windows.Forms.RadioButton();
            this.rbtnEntireRange = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.pbScan = new System.Windows.Forms.ProgressBar();
            this.btnScan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIpRange
            // 
            this.tbIpRange.Location = new System.Drawing.Point(96, 105);
            this.tbIpRange.Name = "tbIpRange";
            this.tbIpRange.Size = new System.Drawing.Size(171, 20);
            this.tbIpRange.TabIndex = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel3.Location = new System.Drawing.Point(38, 110);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(50, 13);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "IP range:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel2.Location = new System.Drawing.Point(38, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 13);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "IP range:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.metroLabel4.Location = new System.Drawing.Point(96, 131);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(178, 39);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "e.g. 192.168.0.0 - 192.168.178.0.50\r\n        192.168.0.0/24\r\n        192.168.0.0/" +
    "255.255.255.0";
            // 
            // lblSubnetRange
            // 
            this.lblSubnetRange.AutoSize = true;
            this.lblSubnetRange.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSubnetRange.Location = new System.Drawing.Point(96, 47);
            this.lblSubnetRange.Name = "lblSubnetRange";
            this.lblSubnetRange.Size = new System.Drawing.Size(150, 13);
            this.lblSubnetRange.TabIndex = 12;
            this.lblSubnetRange.Text = "192.168.178.0/255.255.255.0";
            // 
            // rbtnCustomRange
            // 
            this.rbtnCustomRange.AutoSize = true;
            this.rbtnCustomRange.Location = new System.Drawing.Point(21, 78);
            this.rbtnCustomRange.Name = "rbtnCustomRange";
            this.rbtnCustomRange.Size = new System.Drawing.Size(130, 17);
            this.rbtnCustomRange.TabIndex = 8;
            this.rbtnCustomRange.Text = "Scan custom IP range";
            // 
            // rbtnEntireRange
            // 
            this.rbtnEntireRange.AutoSize = true;
            this.rbtnEntireRange.Checked = true;
            this.rbtnEntireRange.Location = new System.Drawing.Point(21, 23);
            this.rbtnEntireRange.Name = "rbtnEntireRange";
            this.rbtnEntireRange.Size = new System.Drawing.Size(114, 17);
            this.rbtnEntireRange.TabIndex = 7;
            this.rbtnEntireRange.TabStop = true;
            this.rbtnEntireRange.Text = "Scan entire subnet";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(70, 183);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 20;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 183);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(40, 13);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Status:";
            // 
            // pbScan
            // 
            this.pbScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScan.Location = new System.Drawing.Point(23, 201);
            this.pbScan.Name = "pbScan";
            this.pbScan.Size = new System.Drawing.Size(165, 23);
            this.pbScan.TabIndex = 19;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(196, 201);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 18;
            this.btnScan.Text = "Scan";
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click_1);
            // 
            // FrmScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 244);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pbScan);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.tbIpRange);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lblSubnetRange);
            this.Controls.Add(this.rbtnCustomRange);
            this.Controls.Add(this.rbtnEntireRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmScan";
            this.ShowInTaskbar = false;
            this.Text = "Host Scan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIpRange;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label metroLabel4;
        private System.Windows.Forms.Label lblSubnetRange;
        private System.Windows.Forms.RadioButton rbtnCustomRange;
        private System.Windows.Forms.RadioButton rbtnEntireRange;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.ProgressBar pbScan;
        private System.Windows.Forms.Button btnScan;
    }
}