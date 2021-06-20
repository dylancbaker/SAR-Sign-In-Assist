
namespace SAR_Sign_In_Assist
{
    partial class MemberStatusByActivityForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberStatusByActivityForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboActivity = new System.Windows.Forms.ComboBox();
            this.lblCurrentActivity = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvMembersOnTask = new System.Windows.Forms.DataGridView();
            this.colMemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTimeOutRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSignOutAll = new System.Windows.Forms.Button();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBulkSignIn = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.numOperationalPeriod = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersOnTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperationalPeriod)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.numOperationalPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.cboActivity);
            this.splitContainer1.Panel1.Controls.Add(this.lblCurrentActivity);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 540);
            this.splitContainer1.SplitterDistance = 54;
            this.splitContainer1.TabIndex = 0;
            // 
            // cboActivity
            // 
            this.cboActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboActivity.DisplayMember = "NameWithDates";
            this.cboActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActivity.FormattingEnabled = true;
            this.cboActivity.Location = new System.Drawing.Point(152, 12);
            this.cboActivity.Name = "cboActivity";
            this.cboActivity.Size = new System.Drawing.Size(615, 32);
            this.cboActivity.TabIndex = 3;
            this.cboActivity.ValueMember = "ActivityID";
            this.cboActivity.SelectedIndexChanged += new System.EventHandler(this.cboActivity_SelectedIndexChanged);
            // 
            // lblCurrentActivity
            // 
            this.lblCurrentActivity.AutoSize = true;
            this.lblCurrentActivity.Location = new System.Drawing.Point(12, 15);
            this.lblCurrentActivity.Name = "lblCurrentActivity";
            this.lblCurrentActivity.Size = new System.Drawing.Size(134, 24);
            this.lblCurrentActivity.TabIndex = 2;
            this.lblCurrentActivity.Text = "Current Activity";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMembersOnTask);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnExport);
            this.splitContainer2.Panel2.Controls.Add(this.btnPrint);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.btnSignOutAll);
            this.splitContainer2.Panel2.Controls.Add(this.btnSignOut);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.btnBulkSignIn);
            this.splitContainer2.Panel2.Controls.Add(this.btnSignIn);
            this.splitContainer2.Size = new System.Drawing.Size(1043, 482);
            this.splitContainer2.SplitterDistance = 786;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvMembersOnTask
            // 
            this.dgvMembersOnTask.AllowUserToAddRows = false;
            this.dgvMembersOnTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembersOnTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMemberName,
            this.colGroup,
            this.colSignInTime,
            this.colTimeOutRequest,
            this.colSignOut});
            this.dgvMembersOnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembersOnTask.Location = new System.Drawing.Point(0, 0);
            this.dgvMembersOnTask.Name = "dgvMembersOnTask";
            this.dgvMembersOnTask.ReadOnly = true;
            this.dgvMembersOnTask.RowHeadersVisible = false;
            this.dgvMembersOnTask.RowTemplate.Height = 30;
            this.dgvMembersOnTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembersOnTask.Size = new System.Drawing.Size(786, 482);
            this.dgvMembersOnTask.TabIndex = 2;
            this.dgvMembersOnTask.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMembersOnTask_CellFormatting);
            // 
            // colMemberName
            // 
            this.colMemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMemberName.DataPropertyName = "MemberName";
            this.colMemberName.HeaderText = "Name";
            this.colMemberName.MinimumWidth = 150;
            this.colMemberName.Name = "colMemberName";
            this.colMemberName.ReadOnly = true;
            // 
            // colGroup
            // 
            this.colGroup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGroup.DataPropertyName = "OrganizationName";
            this.colGroup.HeaderText = "SAR Group";
            this.colGroup.Name = "colGroup";
            this.colGroup.ReadOnly = true;
            this.colGroup.Width = 120;
            // 
            // colSignInTime
            // 
            this.colSignInTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSignInTime.DataPropertyName = "SignInTime";
            dataGridViewCellStyle1.Format = "HH:mm yyyy-MMM-dd";
            dataGridViewCellStyle1.NullValue = null;
            this.colSignInTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.colSignInTime.HeaderText = "Sign In";
            this.colSignInTime.Name = "colSignInTime";
            this.colSignInTime.ReadOnly = true;
            this.colSignInTime.Width = 86;
            // 
            // colTimeOutRequest
            // 
            this.colTimeOutRequest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTimeOutRequest.DataPropertyName = "TimeOutRequestAsStr";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.colTimeOutRequest.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTimeOutRequest.HeaderText = "Requested Time Out";
            this.colTimeOutRequest.Name = "colTimeOutRequest";
            this.colTimeOutRequest.ReadOnly = true;
            this.colTimeOutRequest.Width = 164;
            // 
            // colSignOut
            // 
            this.colSignOut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSignOut.DataPropertyName = "SignOutTimeOrBlank";
            dataGridViewCellStyle3.Format = "HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.colSignOut.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSignOut.HeaderText = "Sign Out";
            this.colSignOut.Name = "colSignOut";
            this.colSignOut.ReadOnly = true;
            this.colSignOut.Width = 99;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_filetypes_9_file_spreadsheet;
            this.btnExport.Location = new System.Drawing.Point(3, 389);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(238, 50);
            this.btnExport.TabIndex = 37;
            this.btnExport.Text = "Export to CSV";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_16_print;
            this.btnPrint.Location = new System.Drawing.Point(3, 333);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(238, 50);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Report";
            // 
            // btnSignOutAll
            // 
            this.btnSignOutAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOutAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOutAll.Image")));
            this.btnSignOutAll.Location = new System.Drawing.Point(3, 248);
            this.btnSignOutAll.Name = "btnSignOutAll";
            this.btnSignOutAll.Size = new System.Drawing.Size(238, 50);
            this.btnSignOutAll.TabIndex = 34;
            this.btnSignOutAll.Text = "Sign Out All";
            this.btnSignOutAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOutAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOutAll.UseVisualStyleBackColor = true;
            this.btnSignOutAll.Click += new System.EventHandler(this.btnSignOutAll_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.Location = new System.Drawing.Point(3, 192);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(238, 50);
            this.btnSignOut.TabIndex = 33;
            this.btnSignOut.Text = "Sign Out Selected";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Sign Out";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 30;
            this.label6.Text = "Sign In";
            // 
            // btnBulkSignIn
            // 
            this.btnBulkSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBulkSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnBulkSignIn.Image")));
            this.btnBulkSignIn.Location = new System.Drawing.Point(4, 104);
            this.btnBulkSignIn.Name = "btnBulkSignIn";
            this.btnBulkSignIn.Size = new System.Drawing.Size(238, 50);
            this.btnBulkSignIn.TabIndex = 31;
            this.btnBulkSignIn.Text = "Bulk Sign In";
            this.btnBulkSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBulkSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBulkSignIn.UseVisualStyleBackColor = true;
            this.btnBulkSignIn.Click += new System.EventHandler(this.btnBulkSignIn_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Image")));
            this.btnSignIn.Location = new System.Drawing.Point(3, 48);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(238, 50);
            this.btnSignIn.TabIndex = 29;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            this.saveFileDialog1.Filter = "CSV Files (*.CSV)|*.csv";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Operational Period";
            // 
            // numOperationalPeriod
            // 
            this.numOperationalPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numOperationalPeriod.Location = new System.Drawing.Point(954, 15);
            this.numOperationalPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numOperationalPeriod.Name = "numOperationalPeriod";
            this.numOperationalPeriod.Size = new System.Drawing.Size(77, 29);
            this.numOperationalPeriod.TabIndex = 7;
            this.numOperationalPeriod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MemberStatusByActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 540);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MemberStatusByActivityForm";
            this.Text = "Member Status by Activity";
            this.Load += new System.EventHandler(this.MemberStatusByActivityForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembersOnTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOperationalPeriod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvMembersOnTask;
        private System.Windows.Forms.ComboBox cboActivity;
        private System.Windows.Forms.Label lblCurrentActivity;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSignOutAll;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBulkSignIn;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTimeOutRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignOut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numOperationalPeriod;
    }
}