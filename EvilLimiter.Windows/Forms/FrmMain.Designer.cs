namespace EvilLimiter.Windows.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.cmsHosts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiLimit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBlock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFree = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnScan = new System.Windows.Forms.Button();
            this.tcHosts = new System.Windows.Forms.TabControl();
            this.tpHosts = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lvwHosts = new EvilLimiter.Windows.Controls.ListViewNF();
            this.chIp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMac = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chUpload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDownload = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.tpRoutingSettings = new System.Windows.Forms.TabPage();
            this.cbRoutingStartup = new System.Windows.Forms.CheckBox();
            this.metroLabel11 = new System.Windows.Forms.Label();
            this.tglRouting = new System.Windows.Forms.CheckBox();
            this.tpScanSettings = new System.Windows.Forms.TabPage();
            this.metroLabel6 = new System.Windows.Forms.Label();
            this.metroLabel5 = new System.Windows.Forms.Label();
            this.tbScanReplyTimeout = new System.Windows.Forms.TextBox();
            this.tbScanSendInterval = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new System.Windows.Forms.Label();
            this.metroLabel3 = new System.Windows.Forms.Label();
            this.tpSpoofSettings = new System.Windows.Forms.TabPage();
            this.metroLabel13 = new System.Windows.Forms.Label();
            this.metroLabel8 = new System.Windows.Forms.Label();
            this.tbSpoofRestoreSendInterval = new System.Windows.Forms.TextBox();
            this.metroLabel12 = new System.Windows.Forms.Label();
            this.tbSpoofRestoreSendCount = new System.Windows.Forms.TextBox();
            this.metroLabel10 = new System.Windows.Forms.Label();
            this.tbSpoofSendInterval = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new System.Windows.Forms.Label();
            this.tpOtherSettings = new System.Windows.Forms.TabPage();
            this.metroLabel7 = new System.Windows.Forms.Label();
            this.tbBandwidthMonitorUpdateInterval = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new System.Windows.Forms.Label();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.metroLabel17 = new System.Windows.Forms.Label();
            this.lnkCredits = new System.Windows.Forms.Label();
            this.metroLabel16 = new System.Windows.Forms.Label();
            this.lnkEvilLimiter = new System.Windows.Forms.Label();
            this.metroLabel14 = new System.Windows.Forms.Label();
            this.cmsHosts.SuspendLayout();
            this.tcHosts.SuspendLayout();
            this.tpHosts.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.tpRoutingSettings.SuspendLayout();
            this.tpScanSettings.SuspendLayout();
            this.tpSpoofSettings.SuspendLayout();
            this.tpOtherSettings.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsHosts
            // 
            this.cmsHosts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLimit,
            this.tsmiBlock,
            this.tsmiFree,
            this.toolStripMenuItem1,
            this.tsmiAdd,
            this.tsmiRemove,
            this.toolStripMenuItem2,
            this.tsmiSelectAll});
            this.cmsHosts.Name = "cmsHosts";
            this.cmsHosts.Size = new System.Drawing.Size(123, 148);
            this.cmsHosts.Opening += new System.ComponentModel.CancelEventHandler(this.CmsHosts_Opening);
            // 
            // tsmiLimit
            // 
            this.tsmiLimit.Name = "tsmiLimit";
            this.tsmiLimit.Size = new System.Drawing.Size(122, 22);
            this.tsmiLimit.Text = "Limit...";
            this.tsmiLimit.Click += new System.EventHandler(this.TsmiLimit_Click);
            // 
            // tsmiBlock
            // 
            this.tsmiBlock.Name = "tsmiBlock";
            this.tsmiBlock.Size = new System.Drawing.Size(122, 22);
            this.tsmiBlock.Text = "Block";
            this.tsmiBlock.Click += new System.EventHandler(this.TsmiBlock_Click);
            // 
            // tsmiFree
            // 
            this.tsmiFree.Name = "tsmiFree";
            this.tsmiFree.Size = new System.Drawing.Size(122, 22);
            this.tsmiFree.Text = "Free";
            this.tsmiFree.Click += new System.EventHandler(this.TsmiFree_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(122, 22);
            this.tsmiAdd.Text = "Add...";
            this.tsmiAdd.Click += new System.EventHandler(this.TsmiAdd_Click);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(122, 22);
            this.tsmiRemove.Text = "Remove";
            this.tsmiRemove.Click += new System.EventHandler(this.TsmiRemove_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(119, 6);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(122, 22);
            this.tsmiSelectAll.Text = "Select All";
            this.tsmiSelectAll.Click += new System.EventHandler(this.TsmiSelectAll_Click);
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(15, 234);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(65, 25);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.Click += new System.EventHandler(this.BtnScan_Click);
            // 
            // tcHosts
            // 
            this.tcHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcHosts.Controls.Add(this.tpHosts);
            this.tcHosts.Controls.Add(this.tpSettings);
            this.tcHosts.Controls.Add(this.tpAbout);
            this.tcHosts.Location = new System.Drawing.Point(12, 12);
            this.tcHosts.Name = "tcHosts";
            this.tcHosts.SelectedIndex = 0;
            this.tcHosts.Size = new System.Drawing.Size(532, 299);
            this.tcHosts.TabIndex = 4;
            // 
            // tpHosts
            // 
            this.tpHosts.Controls.Add(this.button2);
            this.tpHosts.Controls.Add(this.button6);
            this.tpHosts.Controls.Add(this.button5);
            this.tpHosts.Controls.Add(this.button4);
            this.tpHosts.Controls.Add(this.button3);
            this.tpHosts.Controls.Add(this.button1);
            this.tpHosts.Controls.Add(this.lvwHosts);
            this.tpHosts.Controls.Add(this.btnScan);
            this.tpHosts.Location = new System.Drawing.Point(4, 22);
            this.tpHosts.Name = "tpHosts";
            this.tpHosts.Size = new System.Drawing.Size(524, 273);
            this.tpHosts.TabIndex = 0;
            this.tpHosts.Text = "Hosts";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(228, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Add Host";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(157, 234);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 25);
            this.button6.TabIndex = 10;
            this.button6.Text = "Select All";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(299, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 25);
            this.button5.TabIndex = 9;
            this.button5.Text = "Block";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(370, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "Limit";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(441, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "Free";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(86, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Clear";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lvwHosts
            // 
            this.lvwHosts.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvwHosts.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvwHosts.AllowColumnReorder = true;
            this.lvwHosts.AllowDrop = true;
            this.lvwHosts.AutoArrange = false;
            this.lvwHosts.BackColor = System.Drawing.SystemColors.Window;
            this.lvwHosts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chIp,
            this.chMac,
            this.chHostName,
            this.chUpload,
            this.chDownload});
            this.lvwHosts.ContextMenuStrip = this.cmsHosts;
            this.lvwHosts.ForeColor = System.Drawing.Color.Black;
            this.lvwHosts.FullRowSelect = true;
            this.lvwHosts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvwHosts.HideSelection = false;
            this.lvwHosts.HoverSelection = true;
            this.lvwHosts.Location = new System.Drawing.Point(15, 18);
            this.lvwHosts.Name = "lvwHosts";
            this.lvwHosts.Size = new System.Drawing.Size(494, 205);
            this.lvwHosts.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lvwHosts.TabIndex = 4;
            this.lvwHosts.TileSize = new System.Drawing.Size(10, 10);
            this.lvwHosts.UseCompatibleStateImageBehavior = false;
            this.lvwHosts.View = System.Windows.Forms.View.Details;
            // 
            // chIp
            // 
            this.chIp.Text = "IP Address";
            this.chIp.Width = 86;
            // 
            // chMac
            // 
            this.chMac.Text = "MAC Address";
            this.chMac.Width = 110;
            // 
            // chHostName
            // 
            this.chHostName.Text = "Hostname";
            this.chHostName.Width = 111;
            // 
            // chUpload
            // 
            this.chUpload.Text = "Upload";
            this.chUpload.Width = 93;
            // 
            // chDownload
            // 
            this.chDownload.Text = "Download";
            this.chDownload.Width = 93;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.tcSettings);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Size = new System.Drawing.Size(524, 273);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSettings.Controls.Add(this.tpRoutingSettings);
            this.tcSettings.Controls.Add(this.tpScanSettings);
            this.tcSettings.Controls.Add(this.tpSpoofSettings);
            this.tcSettings.Controls.Add(this.tpOtherSettings);
            this.tcSettings.Location = new System.Drawing.Point(0, 13);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 4;
            this.tcSettings.Size = new System.Drawing.Size(710, 289);
            this.tcSettings.TabIndex = 2;
            // 
            // tpRoutingSettings
            // 
            this.tpRoutingSettings.Controls.Add(this.cbRoutingStartup);
            this.tpRoutingSettings.Controls.Add(this.metroLabel11);
            this.tpRoutingSettings.Controls.Add(this.tglRouting);
            this.tpRoutingSettings.Location = new System.Drawing.Point(4, 22);
            this.tpRoutingSettings.Name = "tpRoutingSettings";
            this.tpRoutingSettings.Size = new System.Drawing.Size(702, 263);
            this.tpRoutingSettings.TabIndex = 4;
            this.tpRoutingSettings.Text = "Routing";
            // 
            // cbRoutingStartup
            // 
            this.cbRoutingStartup.AutoSize = true;
            this.cbRoutingStartup.Location = new System.Drawing.Point(4, 87);
            this.cbRoutingStartup.Name = "cbRoutingStartup";
            this.cbRoutingStartup.Size = new System.Drawing.Size(168, 17);
            this.cbRoutingStartup.TabIndex = 5;
            this.cbRoutingStartup.Text = "Run routing service on startup";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(4, 22);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(89, 13);
            this.metroLabel11.TabIndex = 3;
            this.metroLabel11.Text = "IP routing service";
            // 
            // tglRouting
            // 
            this.tglRouting.AutoSize = true;
            this.tglRouting.Location = new System.Drawing.Point(4, 48);
            this.tglRouting.Name = "tglRouting";
            this.tglRouting.Size = new System.Drawing.Size(40, 17);
            this.tglRouting.TabIndex = 2;
            this.tglRouting.Text = "Off";
            this.tglRouting.CheckedChanged += new System.EventHandler(this.TglRouting_CheckedChanged);
            // 
            // tpScanSettings
            // 
            this.tpScanSettings.Controls.Add(this.metroLabel6);
            this.tpScanSettings.Controls.Add(this.metroLabel5);
            this.tpScanSettings.Controls.Add(this.tbScanReplyTimeout);
            this.tpScanSettings.Controls.Add(this.tbScanSendInterval);
            this.tpScanSettings.Controls.Add(this.metroLabel4);
            this.tpScanSettings.Controls.Add(this.metroLabel3);
            this.tpScanSettings.Location = new System.Drawing.Point(4, 22);
            this.tpScanSettings.Name = "tpScanSettings";
            this.tpScanSettings.Size = new System.Drawing.Size(702, 263);
            this.tpScanSettings.TabIndex = 0;
            this.tpScanSettings.Text = "Scan";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(170, 105);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(20, 13);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "ms";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(171, 47);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(20, 13);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "ms";
            // 
            // tbScanReplyTimeout
            // 
            this.tbScanReplyTimeout.Location = new System.Drawing.Point(3, 101);
            this.tbScanReplyTimeout.Name = "tbScanReplyTimeout";
            this.tbScanReplyTimeout.Size = new System.Drawing.Size(161, 20);
            this.tbScanReplyTimeout.TabIndex = 7;
            // 
            // tbScanSendInterval
            // 
            this.tbScanSendInterval.Location = new System.Drawing.Point(3, 44);
            this.tbScanSendInterval.Name = "tbScanSendInterval";
            this.tbScanSendInterval.Size = new System.Drawing.Size(161, 20);
            this.tbScanSendInterval.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 79);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 13);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Reply Timeout";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 22);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(70, 13);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Send Interval";
            // 
            // tpSpoofSettings
            // 
            this.tpSpoofSettings.Controls.Add(this.metroLabel13);
            this.tpSpoofSettings.Controls.Add(this.metroLabel8);
            this.tpSpoofSettings.Controls.Add(this.tbSpoofRestoreSendInterval);
            this.tpSpoofSettings.Controls.Add(this.metroLabel12);
            this.tpSpoofSettings.Controls.Add(this.tbSpoofRestoreSendCount);
            this.tpSpoofSettings.Controls.Add(this.metroLabel10);
            this.tpSpoofSettings.Controls.Add(this.tbSpoofSendInterval);
            this.tpSpoofSettings.Controls.Add(this.metroLabel9);
            this.tpSpoofSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSpoofSettings.Name = "tpSpoofSettings";
            this.tpSpoofSettings.Size = new System.Drawing.Size(702, 263);
            this.tpSpoofSettings.TabIndex = 1;
            this.tpSpoofSettings.Text = "Spoof";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(170, 162);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(20, 13);
            this.metroLabel13.TabIndex = 11;
            this.metroLabel13.Text = "ms";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(170, 48);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(20, 13);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "ms";
            // 
            // tbSpoofRestoreSendInterval
            // 
            this.tbSpoofRestoreSendInterval.Location = new System.Drawing.Point(3, 158);
            this.tbSpoofRestoreSendInterval.Name = "tbSpoofRestoreSendInterval";
            this.tbSpoofRestoreSendInterval.Size = new System.Drawing.Size(161, 20);
            this.tbSpoofRestoreSendInterval.TabIndex = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(3, 136);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(110, 13);
            this.metroLabel12.TabIndex = 9;
            this.metroLabel12.Text = "Restore Send Interval";
            // 
            // tbSpoofRestoreSendCount
            // 
            this.tbSpoofRestoreSendCount.Location = new System.Drawing.Point(3, 101);
            this.tbSpoofRestoreSendCount.Name = "tbSpoofRestoreSendCount";
            this.tbSpoofRestoreSendCount.Size = new System.Drawing.Size(161, 20);
            this.tbSpoofRestoreSendCount.TabIndex = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(3, 79);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(103, 13);
            this.metroLabel10.TabIndex = 9;
            this.metroLabel10.Text = "Restore Send Count";
            // 
            // tbSpoofSendInterval
            // 
            this.tbSpoofSendInterval.Location = new System.Drawing.Point(3, 44);
            this.tbSpoofSendInterval.Name = "tbSpoofSendInterval";
            this.tbSpoofSendInterval.Size = new System.Drawing.Size(161, 20);
            this.tbSpoofSendInterval.TabIndex = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(3, 22);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 13);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Send Interval";
            // 
            // tpOtherSettings
            // 
            this.tpOtherSettings.Controls.Add(this.metroLabel7);
            this.tpOtherSettings.Controls.Add(this.tbBandwidthMonitorUpdateInterval);
            this.tpOtherSettings.Controls.Add(this.metroLabel2);
            this.tpOtherSettings.Location = new System.Drawing.Point(4, 22);
            this.tpOtherSettings.Name = "tpOtherSettings";
            this.tpOtherSettings.Size = new System.Drawing.Size(702, 263);
            this.tpOtherSettings.TabIndex = 3;
            this.tpOtherSettings.Text = "Other";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(170, 48);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(20, 13);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "ms";
            // 
            // tbBandwidthMonitorUpdateInterval
            // 
            this.tbBandwidthMonitorUpdateInterval.Location = new System.Drawing.Point(3, 44);
            this.tbBandwidthMonitorUpdateInterval.Name = "tbBandwidthMonitorUpdateInterval";
            this.tbBandwidthMonitorUpdateInterval.Size = new System.Drawing.Size(161, 20);
            this.tbBandwidthMonitorUpdateInterval.TabIndex = 11;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 13);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Bandwidth Update Interval";
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.metroLabel17);
            this.tpAbout.Controls.Add(this.lnkCredits);
            this.tpAbout.Controls.Add(this.metroLabel16);
            this.tpAbout.Controls.Add(this.lnkEvilLimiter);
            this.tpAbout.Controls.Add(this.metroLabel14);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(524, 273);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(3, 123);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(220, 26);
            this.metroLabel17.TabIndex = 6;
            this.metroLabel17.Text = "by bitbrute\r\nCopyright © 2019 bitbrute. All rights reserved.";
            // 
            // lnkCredits
            // 
            this.lnkCredits.Location = new System.Drawing.Point(3, 191);
            this.lnkCredits.Name = "lnkCredits";
            this.lnkCredits.Size = new System.Drawing.Size(74, 23);
            this.lnkCredits.TabIndex = 5;
            this.lnkCredits.Text = "Roll credits";
            this.lnkCredits.Click += new System.EventHandler(this.LnkCredits_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 13);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(426, 26);
            this.metroLabel16.TabIndex = 4;
            this.metroLabel16.Text = "EvilLimiter allows you to limit the bandwidth of devices on your network without " +
    "having an\r\nphysical or administrative access.";
            // 
            // lnkEvilLimiter
            // 
            this.lnkEvilLimiter.Location = new System.Drawing.Point(354, 68);
            this.lnkEvilLimiter.Name = "lnkEvilLimiter";
            this.lnkEvilLimiter.Size = new System.Drawing.Size(66, 19);
            this.lnkEvilLimiter.TabIndex = 3;
            this.lnkEvilLimiter.Text = "EvilLimiter";
            this.lnkEvilLimiter.Click += new System.EventHandler(this.LnkEvilLimiter_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(3, 67);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(338, 13);
            this.metroLabel14.TabIndex = 2;
            this.metroLabel14.Text = "This is the Windows version of the linux command-line tool                  .";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 323);
            this.Controls.Add(this.tcHosts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "EvilLimiter for Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.cmsHosts.ResumeLayout(false);
            this.tcHosts.ResumeLayout(false);
            this.tpHosts.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tcSettings.ResumeLayout(false);
            this.tpRoutingSettings.ResumeLayout(false);
            this.tpRoutingSettings.PerformLayout();
            this.tpScanSettings.ResumeLayout(false);
            this.tpScanSettings.PerformLayout();
            this.tpSpoofSettings.ResumeLayout(false);
            this.tpSpoofSettings.PerformLayout();
            this.tpOtherSettings.ResumeLayout(false);
            this.tpOtherSettings.PerformLayout();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsHosts;
        private System.Windows.Forms.ToolStripMenuItem tsmiLimit;
        private System.Windows.Forms.ToolStripMenuItem tsmiFree;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.TabControl tcHosts;
        private System.Windows.Forms.TabPage tpHosts;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiBlock;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.TabPage tpScanSettings;
        private System.Windows.Forms.TabPage tpSpoofSettings;
        private System.Windows.Forms.TextBox tbScanSendInterval;
        private System.Windows.Forms.TextBox tbScanReplyTimeout;
        private System.Windows.Forms.TextBox tbSpoofSendInterval;
        private System.Windows.Forms.TextBox tbSpoofRestoreSendCount;
        private System.Windows.Forms.Label metroLabel13;
        private System.Windows.Forms.TextBox tbSpoofRestoreSendInterval;
        private System.Windows.Forms.TabPage tpOtherSettings;
        private System.Windows.Forms.TextBox tbBandwidthMonitorUpdateInterval;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.TabPage tpRoutingSettings;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Label lnkEvilLimiter;
        private System.Windows.Forms.Label lnkCredits;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label metroLabel3;
        private System.Windows.Forms.Label metroLabel4;
        private System.Windows.Forms.Label metroLabel6;
        private System.Windows.Forms.Label metroLabel5;
        private System.Windows.Forms.Label metroLabel8;
        private System.Windows.Forms.Label metroLabel9;
        private System.Windows.Forms.Label metroLabel10;
        private System.Windows.Forms.Label metroLabel12;
        private System.Windows.Forms.Label metroLabel7;
        private System.Windows.Forms.Label metroLabel2;
        private System.Windows.Forms.Label metroLabel11;
        private System.Windows.Forms.CheckBox tglRouting;
        private System.Windows.Forms.CheckBox cbRoutingStartup;
        private System.Windows.Forms.Label metroLabel14;
        private System.Windows.Forms.Label metroLabel16;
        private System.Windows.Forms.Label metroLabel17;
        private Controls.ListViewNF lvwHosts;
        private System.Windows.Forms.ColumnHeader chIp;
        private System.Windows.Forms.ColumnHeader chMac;
        private System.Windows.Forms.ColumnHeader chHostName;
        private System.Windows.Forms.ColumnHeader chUpload;
        private System.Windows.Forms.ColumnHeader chDownload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}