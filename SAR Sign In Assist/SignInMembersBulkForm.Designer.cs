
namespace SAR_Sign_In_Assist
{
    partial class SignInMembersBulkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInMembersBulkForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOrganization = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvTeamMembers = new System.Windows.Forms.DataGridView();
            this.chkSignIn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCallsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTracker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFirstAid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGSAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGSTL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSARM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSpecialSkills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQRScannerHelp = new System.Windows.Forms.Button();
            this.txtCurrentActivity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datExistingMember = new System.Windows.Forms.DateTimePicker();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cboOrganization);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(754, 503);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "SAR Group / Organization";
            // 
            // cboOrganization
            // 
            this.cboOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrganization.DisplayMember = "OrganizationName";
            this.cboOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganization.FormattingEnabled = true;
            this.cboOrganization.Location = new System.Drawing.Point(243, 3);
            this.cboOrganization.Name = "cboOrganization";
            this.cboOrganization.Size = new System.Drawing.Size(499, 32);
            this.cboOrganization.TabIndex = 14;
            this.cboOrganization.ValueMember = "OrganizationID";
            this.cboOrganization.SelectedIndexChanged += new System.EventHandler(this.cboOrganization_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvTeamMembers);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnQRScannerHelp);
            this.splitContainer2.Panel2.Controls.Add(this.txtCurrentActivity);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.datExistingMember);
            this.splitContainer2.Panel2.Controls.Add(this.btnSignIn);
            this.splitContainer2.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer2.Size = new System.Drawing.Size(754, 460);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvTeamMembers
            // 
            this.dgvTeamMembers.AllowUserToAddRows = false;
            this.dgvTeamMembers.AllowUserToDeleteRows = false;
            this.dgvTeamMembers.AllowUserToResizeColumns = false;
            this.dgvTeamMembers.AllowUserToResizeRows = false;
            this.dgvTeamMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSignIn,
            this.colName,
            this.colGroup,
            this.colCallsign,
            this.colPhone,
            this.colRR,
            this.colTracker,
            this.colFirstAid,
            this.colGSAR,
            this.colGSTL,
            this.colSARM,
            this.colSpecialSkills});
            this.dgvTeamMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamMembers.Location = new System.Drawing.Point(0, 0);
            this.dgvTeamMembers.Name = "dgvTeamMembers";
            this.dgvTeamMembers.RowHeadersVisible = false;
            this.dgvTeamMembers.RowTemplate.Height = 30;
            this.dgvTeamMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamMembers.Size = new System.Drawing.Size(754, 363);
            this.dgvTeamMembers.TabIndex = 12;
            this.dgvTeamMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeamMembers_CellClick);
            // 
            // chkSignIn
            // 
            this.chkSignIn.FalseValue = "False";
            this.chkSignIn.HeaderText = "Sign In";
            this.chkSignIn.Name = "chkSignIn";
            this.chkSignIn.TrueValue = "True";
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGroup.DataPropertyName = "Group";
            this.colGroup.HeaderText = "Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.Width = 88;
            // 
            // colCallsign
            // 
            this.colCallsign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCallsign.DataPropertyName = "Callsign";
            this.colCallsign.HeaderText = "Callsign";
            this.colCallsign.Name = "colCallsign";
            this.colCallsign.ReadOnly = true;
            this.colCallsign.Width = 101;
            // 
            // colPhone
            // 
            this.colPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colPhone.DataPropertyName = "Phone";
            this.colPhone.HeaderText = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            this.colPhone.Visible = false;
            // 
            // colRR
            // 
            this.colRR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRR.DataPropertyName = "RopeRescue";
            this.colRR.HeaderText = "Rope Rescue";
            this.colRR.Name = "colRR";
            this.colRR.ReadOnly = true;
            this.colRR.Visible = false;
            // 
            // colTracker
            // 
            this.colTracker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTracker.DataPropertyName = "Tracker";
            this.colTracker.HeaderText = "Tracker";
            this.colTracker.Name = "colTracker";
            this.colTracker.ReadOnly = true;
            this.colTracker.Visible = false;
            // 
            // colFirstAid
            // 
            this.colFirstAid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirstAid.DataPropertyName = "FirstAid";
            this.colFirstAid.HeaderText = "First Aid";
            this.colFirstAid.Name = "colFirstAid";
            this.colFirstAid.ReadOnly = true;
            this.colFirstAid.Visible = false;
            // 
            // colGSAR
            // 
            this.colGSAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGSAR.DataPropertyName = "GSAR";
            this.colGSAR.HeaderText = "GSAR";
            this.colGSAR.Name = "colGSAR";
            this.colGSAR.ReadOnly = true;
            this.colGSAR.Visible = false;
            // 
            // colGSTL
            // 
            this.colGSTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGSTL.DataPropertyName = "GSTL";
            this.colGSTL.HeaderText = "GSTL";
            this.colGSTL.Name = "colGSTL";
            this.colGSTL.ReadOnly = true;
            this.colGSTL.Visible = false;
            // 
            // colSARM
            // 
            this.colSARM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSARM.DataPropertyName = "SARM";
            this.colSARM.HeaderText = "SARM";
            this.colSARM.Name = "colSARM";
            this.colSARM.ReadOnly = true;
            this.colSARM.Visible = false;
            // 
            // colSpecialSkills
            // 
            this.colSpecialSkills.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSpecialSkills.HeaderText = "Special Skills";
            this.colSpecialSkills.Name = "colSpecialSkills";
            this.colSpecialSkills.ReadOnly = true;
            this.colSpecialSkills.Visible = false;
            // 
            // btnQRScannerHelp
            // 
            this.btnQRScannerHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQRScannerHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQRScannerHelp.BackgroundImage")));
            this.btnQRScannerHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQRScannerHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRScannerHelp.Location = new System.Drawing.Point(488, 41);
            this.btnQRScannerHelp.Name = "btnQRScannerHelp";
            this.btnQRScannerHelp.Size = new System.Drawing.Size(28, 28);
            this.btnQRScannerHelp.TabIndex = 55;
            this.btnQRScannerHelp.UseVisualStyleBackColor = true;
            this.btnQRScannerHelp.Click += new System.EventHandler(this.btnQRScannerHelp_Click);
            // 
            // txtCurrentActivity
            // 
            this.txtCurrentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentActivity.Location = new System.Drawing.Point(226, 41);
            this.txtCurrentActivity.Name = "txtCurrentActivity";
            this.txtCurrentActivity.Size = new System.Drawing.Size(256, 29);
            this.txtCurrentActivity.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 53;
            this.label4.Text = "Activity";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sign In Time";
            // 
            // datExistingMember
            // 
            this.datExistingMember.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.datExistingMember.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datExistingMember.Location = new System.Drawing.Point(355, 6);
            this.datExistingMember.Name = "datExistingMember";
            this.datExistingMember.Size = new System.Drawing.Size(161, 29);
            this.datExistingMember.TabIndex = 13;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_739_check;
            this.btnSignIn.Location = new System.Drawing.Point(525, 6);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(6);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(223, 74);
            this.btnSignIn.TabIndex = 12;
            this.btnSignIn.Text = "Sign In Checked Members";
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_223_chevron_left;
            this.btnCancel.Location = new System.Drawing.Point(6, 6);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 74);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SignInMembersBulkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 503);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "SignInMembersBulkForm";
            this.Text = "Sign In Exsiting Members";
            this.Load += new System.EventHandler(this.SignInMembersBulkForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOrganization;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvTeamMembers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSignIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCallsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTracker;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFirstAid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGSAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGSTL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSARM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialSkills;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datExistingMember;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnQRScannerHelp;
        private System.Windows.Forms.TextBox txtCurrentActivity;
        private System.Windows.Forms.Label label4;
    }
}