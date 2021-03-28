namespace EvilLimiter.Windows.Forms
{
    partial class FrmAddHost
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
            this.tbIpAddress = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.tbMacAddress = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 13);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "IP address";
            // 
            // tbIpAddress
            // 
            this.tbIpAddress.Location = new System.Drawing.Point(23, 50);
            this.tbIpAddress.Name = "tbIpAddress";
            this.tbIpAddress.Size = new System.Drawing.Size(191, 20);
            this.tbIpAddress.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 13);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "MAC address";
            // 
            // tbMacAddress
            // 
            this.tbMacAddress.Location = new System.Drawing.Point(23, 107);
            this.tbMacAddress.Name = "tbMacAddress";
            this.tbMacAddress.Size = new System.Drawing.Size(191, 20);
            this.tbMacAddress.TabIndex = 1;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 142);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(101, 13);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Hostname (optional)";
            // 
            // tbHostName
            // 
            this.tbHostName.Location = new System.Drawing.Point(23, 164);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(191, 20);
            this.tbHostName.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(133, 208);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmAddHost
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 257);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbHostName);
            this.Controls.Add(this.tbMacAddress);
            this.Controls.Add(this.tbIpAddress);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddHost";
            this.Text = "Add Host";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.TextBox tbIpAddress;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.TextBox tbMacAddress;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.Button btnAdd;
    }
}