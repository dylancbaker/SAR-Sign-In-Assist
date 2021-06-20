
namespace SAR_Sign_In_Assist
{
    partial class SignInList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInList));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSARTeamMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusByActivityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSelectedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDisplayedRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportSelectedRecordsToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDisplayedRecordsToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendNetworkTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestTaskFromServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForAppUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSARSignInAssistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSignInRecords = new System.Windows.Forms.DataGridView();
            this.colActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeOutRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editSignInRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendSignInRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSignInRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.grpFrom = new System.Windows.Forms.GroupBox();
            this.rbFromDate = new System.Windows.Forms.RadioButton();
            this.rbFromLast24 = new System.Windows.Forms.RadioButton();
            this.datFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnExpandFilterSort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboSARGroup = new System.Windows.Forms.ComboBox();
            this.grpTo = new System.Windows.Forms.GroupBox();
            this.rbToDate = new System.Windows.Forms.RadioButton();
            this.rbToNow = new System.Windows.Forms.RadioButton();
            this.datToDate = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBulkSignIn = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnStatusByActivity = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label4 = new System.Windows.Forms.Label();
            this.numOperationalPeriod = new System.Windows.Forms.NumericUpDown();
            this.chkAutoSendToICA = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picICAConnection = new System.Windows.Forms.PictureBox();
            this.btnQRScannerHelp = new System.Windows.Forms.Button();
            this.txtCurrentActivity = new System.Windows.Forms.TextBox();
            this.lblCurrentActivity = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnSendSelected = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fbdSaveLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignInRecords)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.grpFrom.SuspendLayout();
            this.grpTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOperationalPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picICAConnection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.reportExportToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalOptionsToolStripMenuItem,
            this.editSARTeamMembersToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // generalOptionsToolStripMenuItem
            // 
            this.generalOptionsToolStripMenuItem.Name = "generalOptionsToolStripMenuItem";
            this.generalOptionsToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.generalOptionsToolStripMenuItem.Text = "Options";
            this.generalOptionsToolStripMenuItem.Click += new System.EventHandler(this.generalOptionsToolStripMenuItem_Click);
            // 
            // editSARTeamMembersToolStripMenuItem
            // 
            this.editSARTeamMembersToolStripMenuItem.Name = "editSARTeamMembersToolStripMenuItem";
            this.editSARTeamMembersToolStripMenuItem.Size = new System.Drawing.Size(287, 30);
            this.editSARTeamMembersToolStripMenuItem.Text = "Edit SAR Team Members";
            this.editSARTeamMembersToolStripMenuItem.Click += new System.EventHandler(this.editSARTeamMembersToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusByActivityToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusByActivityToolStripMenuItem
            // 
            this.statusByActivityToolStripMenuItem.Name = "statusByActivityToolStripMenuItem";
            this.statusByActivityToolStripMenuItem.Size = new System.Drawing.Size(225, 30);
            this.statusByActivityToolStripMenuItem.Text = "Status by Activity";
            this.statusByActivityToolStripMenuItem.Click += new System.EventHandler(this.statusByActivityToolStripMenuItem_Click);
            // 
            // reportExportToolStripMenuItem
            // 
            this.reportExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printSelectedRecordsToolStripMenuItem,
            this.printDisplayedRecordsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exportSelectedRecordsToCSVToolStripMenuItem,
            this.exportDisplayedRecordsToCSVToolStripMenuItem});
            this.reportExportToolStripMenuItem.Name = "reportExportToolStripMenuItem";
            this.reportExportToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.reportExportToolStripMenuItem.Text = "Report / Export";
            // 
            // printSelectedRecordsToolStripMenuItem
            // 
            this.printSelectedRecordsToolStripMenuItem.Name = "printSelectedRecordsToolStripMenuItem";
            this.printSelectedRecordsToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.printSelectedRecordsToolStripMenuItem.Text = "Print Selected Records";
            this.printSelectedRecordsToolStripMenuItem.Click += new System.EventHandler(this.printSelectedRecordsToolStripMenuItem_Click);
            // 
            // printDisplayedRecordsToolStripMenuItem
            // 
            this.printDisplayedRecordsToolStripMenuItem.Name = "printDisplayedRecordsToolStripMenuItem";
            this.printDisplayedRecordsToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.printDisplayedRecordsToolStripMenuItem.Text = "Print Displayed Records";
            this.printDisplayedRecordsToolStripMenuItem.Click += new System.EventHandler(this.printDisplayedRecordsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(354, 6);
            // 
            // exportSelectedRecordsToCSVToolStripMenuItem
            // 
            this.exportSelectedRecordsToCSVToolStripMenuItem.Name = "exportSelectedRecordsToCSVToolStripMenuItem";
            this.exportSelectedRecordsToCSVToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.exportSelectedRecordsToCSVToolStripMenuItem.Text = "Export Selected Records to CSV";
            this.exportSelectedRecordsToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportSelectedRecordsToCSVToolStripMenuItem_Click);
            // 
            // exportDisplayedRecordsToCSVToolStripMenuItem
            // 
            this.exportDisplayedRecordsToCSVToolStripMenuItem.Name = "exportDisplayedRecordsToCSVToolStripMenuItem";
            this.exportDisplayedRecordsToCSVToolStripMenuItem.Size = new System.Drawing.Size(357, 30);
            this.exportDisplayedRecordsToCSVToolStripMenuItem.Text = "Export Displayed Records to CSV";
            this.exportDisplayedRecordsToCSVToolStripMenuItem.Click += new System.EventHandler(this.exportDisplayedRecordsToCSVToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.networkSettingsToolStripMenuItem,
            this.sendNetworkTestToolStripMenuItem,
            this.requestTaskFromServerToolStripMenuItem});
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(95, 29);
            this.networkToolStripMenuItem.Text = "Network";
            // 
            // networkSettingsToolStripMenuItem
            // 
            this.networkSettingsToolStripMenuItem.Name = "networkSettingsToolStripMenuItem";
            this.networkSettingsToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
            this.networkSettingsToolStripMenuItem.Text = "Network Settings";
            this.networkSettingsToolStripMenuItem.Click += new System.EventHandler(this.networkSettingsToolStripMenuItem_Click);
            // 
            // sendNetworkTestToolStripMenuItem
            // 
            this.sendNetworkTestToolStripMenuItem.Name = "sendNetworkTestToolStripMenuItem";
            this.sendNetworkTestToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
            this.sendNetworkTestToolStripMenuItem.Text = "Send Network Test";
            this.sendNetworkTestToolStripMenuItem.Click += new System.EventHandler(this.sendNetworkTestToolStripMenuItem_Click);
            // 
            // requestTaskFromServerToolStripMenuItem
            // 
            this.requestTaskFromServerToolStripMenuItem.Name = "requestTaskFromServerToolStripMenuItem";
            this.requestTaskFromServerToolStripMenuItem.Size = new System.Drawing.Size(293, 30);
            this.requestTaskFromServerToolStripMenuItem.Text = "Request Task from Server";
            this.requestTaskFromServerToolStripMenuItem.Click += new System.EventHandler(this.requestTaskFromServerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.checkForAppUpdatesToolStripMenuItem,
            this.aboutSARSignInAssistToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // checkForAppUpdatesToolStripMenuItem
            // 
            this.checkForAppUpdatesToolStripMenuItem.Name = "checkForAppUpdatesToolStripMenuItem";
            this.checkForAppUpdatesToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.checkForAppUpdatesToolStripMenuItem.Text = "Check for app updates";
            // 
            // aboutSARSignInAssistToolStripMenuItem
            // 
            this.aboutSARSignInAssistToolStripMenuItem.Name = "aboutSARSignInAssistToolStripMenuItem";
            this.aboutSARSignInAssistToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.aboutSARSignInAssistToolStripMenuItem.Text = "About SAR Sign In Assist";
            this.aboutSARSignInAssistToolStripMenuItem.Click += new System.EventHandler(this.aboutSARSignInAssistToolStripMenuItem_Click);
            // 
            // dgvSignInRecords
            // 
            this.dgvSignInRecords.AllowUserToAddRows = false;
            this.dgvSignInRecords.AllowUserToDeleteRows = false;
            this.dgvSignInRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSignInRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colActivityName,
            this.colGroup,
            this.colName,
            this.colSignInTime,
            this.colTimeOutRequest});
            this.dgvSignInRecords.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvSignInRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSignInRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvSignInRecords.Name = "dgvSignInRecords";
            this.dgvSignInRecords.ReadOnly = true;
            this.dgvSignInRecords.RowHeadersVisible = false;
            this.dgvSignInRecords.RowTemplate.Height = 35;
            this.dgvSignInRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSignInRecords.Size = new System.Drawing.Size(852, 504);
            this.dgvSignInRecords.TabIndex = 1;
            this.dgvSignInRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSignInRecords_CellDoubleClick);
            this.dgvSignInRecords.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSignInRecords_CellFormatting);
            this.dgvSignInRecords.SelectionChanged += new System.EventHandler(this.dgvSignInRecords_SelectionChanged);
            // 
            // colActivityName
            // 
            this.colActivityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colActivityName.DataPropertyName = "ActivityName";
            this.colActivityName.HeaderText = "Activity";
            this.colActivityName.Name = "colActivityName";
            this.colActivityName.ReadOnly = true;
            this.colActivityName.Width = 92;
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGroup.DataPropertyName = "GroupName";
            this.colGroup.HeaderText = "SAR Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.Width = 120;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "MemberName";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 150;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSignInTime
            // 
            this.colSignInTime.DataPropertyName = "SignInTime";
            dataGridViewCellStyle7.Format = "yyyy-MMM-dd HH:mm";
            dataGridViewCellStyle7.NullValue = "00:00";
            this.colSignInTime.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSignInTime.HeaderText = "Sign In/Out Time";
            this.colSignInTime.Name = "colSignInTime";
            this.colSignInTime.ReadOnly = true;
            this.colSignInTime.Width = 220;
            // 
            // colTimeOutRequest
            // 
            this.colTimeOutRequest.DataPropertyName = "MustBeOutTimeOrBlank";
            dataGridViewCellStyle8.NullValue = null;
            this.colTimeOutRequest.DefaultCellStyle = dataGridViewCellStyle8;
            this.colTimeOutRequest.HeaderText = "Must Be Out";
            this.colTimeOutRequest.Name = "colTimeOutRequest";
            this.colTimeOutRequest.ReadOnly = true;
            this.colTimeOutRequest.Width = 140;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSignInRecordToolStripMenuItem,
            this.sendSignInRecordToolStripMenuItem,
            this.removeSignInRecordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 70);
            // 
            // editSignInRecordToolStripMenuItem
            // 
            this.editSignInRecordToolStripMenuItem.Name = "editSignInRecordToolStripMenuItem";
            this.editSignInRecordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.editSignInRecordToolStripMenuItem.Text = "Edit Sign In Record";
            // 
            // sendSignInRecordToolStripMenuItem
            // 
            this.sendSignInRecordToolStripMenuItem.Name = "sendSignInRecordToolStripMenuItem";
            this.sendSignInRecordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sendSignInRecordToolStripMenuItem.Text = "Send Sign In Record";
            // 
            // removeSignInRecordToolStripMenuItem
            // 
            this.removeSignInRecordToolStripMenuItem.Name = "removeSignInRecordToolStripMenuItem";
            this.removeSignInRecordToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.removeSignInRecordToolStripMenuItem.Text = "Remove Sign In Record";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvSignInRecords);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlFilter);
            this.splitContainer1.Panel2.Controls.Add(this.btnExport);
            this.splitContainer1.Panel2.Controls.Add(this.btnPrint);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.btnSignOut);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.btnBulkSignIn);
            this.splitContainer1.Panel2.Controls.Add(this.btnSignIn);
            this.splitContainer1.Panel2.Controls.Add(this.btnStatusByActivity);
            this.splitContainer1.Size = new System.Drawing.Size(1104, 504);
            this.splitContainer1.SplitterDistance = 852;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilter.Controls.Add(this.grpFrom);
            this.pnlFilter.Controls.Add(this.btnExpandFilterSort);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.label3);
            this.pnlFilter.Controls.Add(this.cboSARGroup);
            this.pnlFilter.Controls.Add(this.grpTo);
            this.pnlFilter.Location = new System.Drawing.Point(2, 3);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(243, 62);
            this.pnlFilter.TabIndex = 25;
            // 
            // grpFrom
            // 
            this.grpFrom.Controls.Add(this.rbFromDate);
            this.grpFrom.Controls.Add(this.rbFromLast24);
            this.grpFrom.Controls.Add(this.datFromDate);
            this.grpFrom.Location = new System.Drawing.Point(9, 41);
            this.grpFrom.Name = "grpFrom";
            this.grpFrom.Size = new System.Drawing.Size(254, 100);
            this.grpFrom.TabIndex = 22;
            this.grpFrom.TabStop = false;
            this.grpFrom.Text = "From";
            // 
            // rbFromDate
            // 
            this.rbFromDate.AutoSize = true;
            this.rbFromDate.Location = new System.Drawing.Point(6, 70);
            this.rbFromDate.Name = "rbFromDate";
            this.rbFromDate.Size = new System.Drawing.Size(14, 13);
            this.rbFromDate.TabIndex = 21;
            this.rbFromDate.UseVisualStyleBackColor = true;
            this.rbFromDate.CheckedChanged += new System.EventHandler(this.rbFromDate_CheckedChanged);
            // 
            // rbFromLast24
            // 
            this.rbFromLast24.AutoSize = true;
            this.rbFromLast24.Checked = true;
            this.rbFromLast24.Location = new System.Drawing.Point(6, 28);
            this.rbFromLast24.Name = "rbFromLast24";
            this.rbFromLast24.Size = new System.Drawing.Size(97, 28);
            this.rbFromLast24.TabIndex = 20;
            this.rbFromLast24.TabStop = true;
            this.rbFromLast24.Text = "Last 24h";
            this.rbFromLast24.UseVisualStyleBackColor = true;
            this.rbFromLast24.CheckedChanged += new System.EventHandler(this.rbFromLast24_CheckedChanged);
            // 
            // datFromDate
            // 
            this.datFromDate.CustomFormat = "yyyy-MMM-dd HH:mm";
            this.datFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datFromDate.Location = new System.Drawing.Point(26, 62);
            this.datFromDate.Name = "datFromDate";
            this.datFromDate.Size = new System.Drawing.Size(195, 29);
            this.datFromDate.TabIndex = 19;
            this.datFromDate.ValueChanged += new System.EventHandler(this.datFromDate_ValueChanged);
            // 
            // btnExpandFilterSort
            // 
            this.btnExpandFilterSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExpandFilterSort.BackColor = System.Drawing.Color.LightGray;
            this.btnExpandFilterSort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpandFilterSort.BackgroundImage")));
            this.btnExpandFilterSort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpandFilterSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandFilterSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandFilterSort.Location = new System.Drawing.Point(205, 13);
            this.btnExpandFilterSort.Name = "btnExpandFilterSort";
            this.btnExpandFilterSort.Size = new System.Drawing.Size(25, 25);
            this.btnExpandFilterSort.TabIndex = 31;
            this.btnExpandFilterSort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExpandFilterSort.UseVisualStyleBackColor = false;
            this.btnExpandFilterSort.Click += new System.EventHandler(this.btnExpandFilterSort_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Filter Sign-Ins";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 24;
            this.label3.Text = "SAR Group";
            // 
            // cboSARGroup
            // 
            this.cboSARGroup.DisplayMember = "OrganizationName";
            this.cboSARGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSARGroup.FormattingEnabled = true;
            this.cboSARGroup.Location = new System.Drawing.Point(9, 286);
            this.cboSARGroup.Name = "cboSARGroup";
            this.cboSARGroup.Size = new System.Drawing.Size(221, 32);
            this.cboSARGroup.TabIndex = 23;
            this.cboSARGroup.ValueMember = "OrganizationID";
            this.cboSARGroup.SelectedIndexChanged += new System.EventHandler(this.cboSARGroup_SelectedIndexChanged);
            // 
            // grpTo
            // 
            this.grpTo.Controls.Add(this.rbToDate);
            this.grpTo.Controls.Add(this.rbToNow);
            this.grpTo.Controls.Add(this.datToDate);
            this.grpTo.Location = new System.Drawing.Point(9, 147);
            this.grpTo.Name = "grpTo";
            this.grpTo.Size = new System.Drawing.Size(249, 104);
            this.grpTo.TabIndex = 0;
            this.grpTo.TabStop = false;
            this.grpTo.Text = "To";
            // 
            // rbToDate
            // 
            this.rbToDate.AutoSize = true;
            this.rbToDate.Location = new System.Drawing.Point(6, 70);
            this.rbToDate.Name = "rbToDate";
            this.rbToDate.Size = new System.Drawing.Size(14, 13);
            this.rbToDate.TabIndex = 23;
            this.rbToDate.UseVisualStyleBackColor = true;
            this.rbToDate.CheckedChanged += new System.EventHandler(this.rbToDate_CheckedChanged);
            // 
            // rbToNow
            // 
            this.rbToNow.AutoSize = true;
            this.rbToNow.Checked = true;
            this.rbToNow.Location = new System.Drawing.Point(6, 28);
            this.rbToNow.Name = "rbToNow";
            this.rbToNow.Size = new System.Drawing.Size(67, 28);
            this.rbToNow.TabIndex = 22;
            this.rbToNow.TabStop = true;
            this.rbToNow.Text = "Now";
            this.rbToNow.UseVisualStyleBackColor = true;
            this.rbToNow.CheckedChanged += new System.EventHandler(this.rbToNow_CheckedChanged);
            // 
            // datToDate
            // 
            this.datToDate.CustomFormat = "yyyy-MMM-dd HH:mm";
            this.datToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datToDate.Location = new System.Drawing.Point(26, 62);
            this.datToDate.Name = "datToDate";
            this.datToDate.Size = new System.Drawing.Size(195, 29);
            this.datToDate.TabIndex = 20;
            this.datToDate.ValueChanged += new System.EventHandler(this.datToDate_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_filetypes_9_file_spreadsheet;
            this.btnExport.Location = new System.Drawing.Point(8, 441);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(228, 50);
            this.btnExport.TabIndex = 28;
            this.btnExport.Text = "Export to CSV";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_16_print;
            this.btnPrint.Location = new System.Drawing.Point(8, 385);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(228, 50);
            this.btnPrint.TabIndex = 27;
            this.btnPrint.Text = "Print Selected";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Report";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(8, 300);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(228, 50);
            this.btnSignOut.TabIndex = 17;
            this.btnSignOut.Text = "Sign Out Selected";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sign Out";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Sign In";
            // 
            // btnBulkSignIn
            // 
            this.btnBulkSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBulkSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnBulkSignIn.Image")));
            this.btnBulkSignIn.Location = new System.Drawing.Point(9, 212);
            this.btnBulkSignIn.Name = "btnBulkSignIn";
            this.btnBulkSignIn.Size = new System.Drawing.Size(228, 50);
            this.btnBulkSignIn.TabIndex = 15;
            this.btnBulkSignIn.Text = "Bulk Sign In";
            this.btnBulkSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBulkSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBulkSignIn.UseVisualStyleBackColor = true;
            this.btnBulkSignIn.Click += new System.EventHandler(this.btnBulkSignIn_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Image")));
            this.btnSignIn.Location = new System.Drawing.Point(8, 156);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(228, 50);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnStatusByActivity
            // 
            this.btnStatusByActivity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStatusByActivity.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_152_square_new_window;
            this.btnStatusByActivity.Location = new System.Drawing.Point(10, 71);
            this.btnStatusByActivity.Name = "btnStatusByActivity";
            this.btnStatusByActivity.Size = new System.Drawing.Size(226, 50);
            this.btnStatusByActivity.TabIndex = 2;
            this.btnStatusByActivity.Text = "Status by Activity";
            this.btnStatusByActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatusByActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStatusByActivity.UseVisualStyleBackColor = true;
            this.btnStatusByActivity.Click += new System.EventHandler(this.btnStatusByActivity_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 33);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label4);
            this.splitContainer2.Panel1.Controls.Add(this.numOperationalPeriod);
            this.splitContainer2.Panel1.Controls.Add(this.chkAutoSendToICA);
            this.splitContainer2.Panel1.Controls.Add(this.picICAConnection);
            this.splitContainer2.Panel1.Controls.Add(this.btnQRScannerHelp);
            this.splitContainer2.Panel1.Controls.Add(this.txtCurrentActivity);
            this.splitContainer2.Panel1.Controls.Add(this.lblCurrentActivity);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1104, 603);
            this.splitContainer2.SplitterDistance = 47;
            this.splitContainer2.TabIndex = 3;
            this.splitContainer2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.splitContainer2_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operational Period";
            // 
            // numOperationalPeriod
            // 
            this.numOperationalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numOperationalPeriod.Location = new System.Drawing.Point(665, 9);
            this.numOperationalPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOperationalPeriod.Name = "numOperationalPeriod";
            this.numOperationalPeriod.Size = new System.Drawing.Size(77, 29);
            this.numOperationalPeriod.TabIndex = 5;
            this.numOperationalPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkAutoSendToICA
            // 
            this.chkAutoSendToICA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoSendToICA.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkAutoSendToICA.AutoSize = true;
            this.chkAutoSendToICA.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.chkAutoSendToICA.FlatAppearance.BorderSize = 0;
            this.chkAutoSendToICA.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.chkAutoSendToICA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.chkAutoSendToICA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.chkAutoSendToICA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoSendToICA.ImageIndex = 0;
            this.chkAutoSendToICA.ImageList = this.imageList1;
            this.chkAutoSendToICA.Location = new System.Drawing.Point(849, 6);
            this.chkAutoSendToICA.Margin = new System.Windows.Forms.Padding(6);
            this.chkAutoSendToICA.Name = "chkAutoSendToICA";
            this.chkAutoSendToICA.Size = new System.Drawing.Size(248, 34);
            this.chkAutoSendToICA.TabIndex = 52;
            this.chkAutoSendToICA.Text = "Automatically send to ICA";
            this.chkAutoSendToICA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkAutoSendToICA.UseVisualStyleBackColor = true;
            this.chkAutoSendToICA.CheckedChanged += new System.EventHandler(this.chkRopeRescue_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check-box-unchecked.png");
            this.imageList1.Images.SetKeyName(1, "check-box-checked.png");
            // 
            // picICAConnection
            // 
            this.picICAConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picICAConnection.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_74_NoWifi1;
            this.picICAConnection.Location = new System.Drawing.Point(805, 6);
            this.picICAConnection.Name = "picICAConnection";
            this.picICAConnection.Size = new System.Drawing.Size(35, 35);
            this.picICAConnection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picICAConnection.TabIndex = 51;
            this.picICAConnection.TabStop = false;
            this.picICAConnection.Click += new System.EventHandler(this.picICAConnection_Click);
            // 
            // btnQRScannerHelp
            // 
            this.btnQRScannerHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQRScannerHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQRScannerHelp.BackgroundImage")));
            this.btnQRScannerHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQRScannerHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRScannerHelp.Location = new System.Drawing.Point(458, 9);
            this.btnQRScannerHelp.Name = "btnQRScannerHelp";
            this.btnQRScannerHelp.Size = new System.Drawing.Size(28, 28);
            this.btnQRScannerHelp.TabIndex = 49;
            this.btnQRScannerHelp.UseVisualStyleBackColor = true;
            this.btnQRScannerHelp.Click += new System.EventHandler(this.btnQRScannerHelp_Click);
            // 
            // txtCurrentActivity
            // 
            this.txtCurrentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentActivity.Location = new System.Drawing.Point(143, 9);
            this.txtCurrentActivity.Name = "txtCurrentActivity";
            this.txtCurrentActivity.Size = new System.Drawing.Size(309, 29);
            this.txtCurrentActivity.TabIndex = 1;
            // 
            // lblCurrentActivity
            // 
            this.lblCurrentActivity.AutoSize = true;
            this.lblCurrentActivity.Location = new System.Drawing.Point(3, 11);
            this.lblCurrentActivity.Name = "lblCurrentActivity";
            this.lblCurrentActivity.Size = new System.Drawing.Size(134, 24);
            this.lblCurrentActivity.TabIndex = 0;
            this.lblCurrentActivity.Text = "Current Activity";
            this.lblCurrentActivity.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.lblCurrentActivity_PreviewKeyDown);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnHide);
            this.splitContainer3.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer3.Panel2.Controls.Add(this.btnView);
            this.splitContainer3.Panel2.Controls.Add(this.btnSendSelected);
            this.splitContainer3.Size = new System.Drawing.Size(1104, 552);
            this.splitContainer3.SplitterDistance = 504;
            this.splitContainer3.TabIndex = 3;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(169, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 41);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 41);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(7, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 41);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnSendSelected
            // 
            this.btnSendSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendSelected.Image = ((System.Drawing.Image)(resources.GetObject("btnSendSelected.Image")));
            this.btnSendSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendSelected.Location = new System.Drawing.Point(845, 2);
            this.btnSendSelected.Name = "btnSendSelected";
            this.btnSendSelected.Size = new System.Drawing.Size(256, 41);
            this.btnSendSelected.TabIndex = 2;
            this.btnSendSelected.Text = "Send Selected to ICA";
            this.btnSendSelected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendSelected.UseVisualStyleBackColor = true;
            this.btnSendSelected.Click += new System.EventHandler(this.btnSendSelected_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV Files (*.CSV)|*.csv";
            // 
            // SignInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 636);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(995, 675);
            this.Name = "SignInList";
            this.Text = "Member Sign-Ins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SignInList_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignInList_FormClosed);
            this.Load += new System.EventHandler(this.SignInList_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SignInList_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSignInRecords)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlFilter.ResumeLayout(false);
            this.grpFrom.ResumeLayout(false);
            this.grpFrom.PerformLayout();
            this.grpTo.ResumeLayout(false);
            this.grpTo.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOperationalPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picICAConnection)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSARTeamMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForAppUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSARSignInAssistToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSignInRecords;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBulkSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboSARGroup;
        private System.Windows.Forms.GroupBox grpTo;
        private System.Windows.Forms.RadioButton rbToDate;
        private System.Windows.Forms.RadioButton rbToNow;
        private System.Windows.Forms.DateTimePicker datToDate;
        private System.Windows.Forms.GroupBox grpFrom;
        private System.Windows.Forms.RadioButton rbFromDate;
        private System.Windows.Forms.RadioButton rbFromLast24;
        private System.Windows.Forms.DateTimePicker datFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendSelected;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editSignInRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendSignInRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeSignInRecordToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCurrentActivity;
        private System.Windows.Forms.Label lblCurrentActivity;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Button btnQRScannerHelp;
        private System.Windows.Forms.Button btnExpandFilterSort;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem reportExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSelectedRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDisplayedRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exportSelectedRecordsToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDisplayedRecordsToCSVToolStripMenuItem;
        private System.Windows.Forms.PictureBox picICAConnection;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox chkAutoSendToICA;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkSettingsToolStripMenuItem;
        private System.Windows.Forms.Button btnStatusByActivity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeOutRequest;
        private System.Windows.Forms.FolderBrowserDialog fbdSaveLocation;
        private System.Windows.Forms.ToolStripMenuItem sendNetworkTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusByActivityToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numOperationalPeriod;
        private System.Windows.Forms.ToolStripMenuItem requestTaskFromServerToolStripMenuItem;
    }
}