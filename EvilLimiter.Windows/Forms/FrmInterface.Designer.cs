namespace EvilLimiter.Windows.Forms
{
    partial class FrmInterface
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInterfaceAddress = new System.Windows.Forms.Label();
            this.metroLabel4 = new System.Windows.Forms.Label();
            this.tbNetmask = new System.Windows.Forms.TextBox();
            this.tbGatewayMac = new System.Windows.Forms.TextBox();
            this.tbGatewayIp = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new System.Windows.Forms.Label();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.cbInterfaces = new System.Windows.Forms.ComboBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.metroLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(198, 316);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 318);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(19, 13);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = ">_";
            this.lblStatus.Visible = false;
            // 
            // lblInterfaceAddress
            // 
            this.lblInterfaceAddress.AutoSize = true;
            this.lblInterfaceAddress.Location = new System.Drawing.Point(142, 92);
            this.lblInterfaceAddress.Name = "lblInterfaceAddress";
            this.lblInterfaceAddress.Size = new System.Drawing.Size(67, 13);
            this.lblInterfaceAddress.TabIndex = 6;
            this.lblInterfaceAddress.Text = "Not selected";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 248);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(49, 13);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Netmask";
            // 
            // tbNetmask
            // 
            this.tbNetmask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNetmask.Enabled = false;
            this.tbNetmask.Location = new System.Drawing.Point(23, 270);
            this.tbNetmask.Name = "tbNetmask";
            this.tbNetmask.ReadOnly = true;
            this.tbNetmask.Size = new System.Drawing.Size(250, 20);
            this.tbNetmask.TabIndex = 3;
            // 
            // tbGatewayMac
            // 
            this.tbGatewayMac.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGatewayMac.Enabled = false;
            this.tbGatewayMac.Location = new System.Drawing.Point(23, 213);
            this.tbGatewayMac.Name = "tbGatewayMac";
            this.tbGatewayMac.ReadOnly = true;
            this.tbGatewayMac.Size = new System.Drawing.Size(250, 20);
            this.tbGatewayMac.TabIndex = 3;
            // 
            // tbGatewayIp
            // 
            this.tbGatewayIp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGatewayIp.Enabled = false;
            this.tbGatewayIp.Location = new System.Drawing.Point(23, 156);
            this.tbGatewayIp.Name = "tbGatewayIp";
            this.tbGatewayIp.ReadOnly = true;
            this.tbGatewayIp.Size = new System.Drawing.Size(250, 20);
            this.tbGatewayIp.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 191);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 13);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Gateway MAC";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 134);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 13);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Gateway IP";
            // 
            // cbInterfaces
            // 
            this.cbInterfaces.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInterfaces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterfaces.FormattingEnabled = true;
            this.cbInterfaces.ItemHeight = 13;
            this.cbInterfaces.Location = new System.Drawing.Point(23, 51);
            this.cbInterfaces.Name = "cbInterfaces";
            this.cbInterfaces.Size = new System.Drawing.Size(250, 21);
            this.cbInterfaces.TabIndex = 1;
            this.cbInterfaces.SelectedIndexChanged += new System.EventHandler(this.CbInterfaces_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 92);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(93, 13);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Interface Address:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(23, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(49, 13);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Interface";
            // 
            // FrmInterface
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(296, 351);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInterfaceAddress);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tbNetmask);
            this.Controls.Add(this.tbGatewayMac);
            this.Controls.Add(this.tbGatewayIp);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbInterfaces);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmInterface";
            this.Text = "Network Interface...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label metroLabel1;
        private System.Windows.Forms.ComboBox cbInterfaces;
        private System.Windows.Forms.TextBox tbGatewayIp;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.TextBox tbGatewayMac;
        private System.Windows.Forms.Label metroLabel5;
        private System.Windows.Forms.Label metroLabel4;
        private System.Windows.Forms.TextBox tbNetmask;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label lblInterfaceAddress;
        private System.Windows.Forms.Label lblStatus;
    }
}