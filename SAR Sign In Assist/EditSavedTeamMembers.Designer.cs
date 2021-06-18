
namespace SAR_Sign_In_Assist
{
    partial class EditSavedTeamMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSavedTeamMembers));
            this.dgvTeamMembers = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCallsign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTracker = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSwiftwater = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colMR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFirstAid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGSAR = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGSTL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSARM = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colSpecialSkills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSARGroup = new System.Windows.Forms.ComboBox();
            this.btnImportFromD4H = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTeamMembers
            // 
            this.dgvTeamMembers.AllowUserToAddRows = false;
            this.dgvTeamMembers.AllowUserToDeleteRows = false;
            this.dgvTeamMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colGroup,
            this.colCallsign,
            this.colPhone,
            this.colRR,
            this.colTracker,
            this.colSwiftwater,
            this.colMR,
            this.colFirstAid,
            this.colGSAR,
            this.colGSTL,
            this.colSARM,
            this.colSpecialSkills});
            this.dgvTeamMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamMembers.Location = new System.Drawing.Point(0, 0);
            this.dgvTeamMembers.Name = "dgvTeamMembers";
            this.dgvTeamMembers.ReadOnly = true;
            this.dgvTeamMembers.RowHeadersVisible = false;
            this.dgvTeamMembers.RowTemplate.Height = 30;
            this.dgvTeamMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamMembers.Size = new System.Drawing.Size(777, 397);
            this.dgvTeamMembers.TabIndex = 50;
            this.dgvTeamMembers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeamMembers_CellDoubleClick);
            this.dgvTeamMembers.SelectionChanged += new System.EventHandler(this.dgvTeamMembers_SelectionChanged);
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 86;
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
            this.colPhone.Width = 91;
            // 
            // colRR
            // 
            this.colRR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colRR.DataPropertyName = "RopeRescue";
            this.colRR.HeaderText = "Rope Rescue";
            this.colRR.Name = "colRR";
            this.colRR.ReadOnly = true;
            this.colRR.Width = 132;
            // 
            // colTracker
            // 
            this.colTracker.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTracker.DataPropertyName = "Tracker";
            this.colTracker.HeaderText = "Tracker";
            this.colTracker.Name = "colTracker";
            this.colTracker.ReadOnly = true;
            this.colTracker.Width = 80;
            // 
            // colSwiftwater
            // 
            this.colSwiftwater.DataPropertyName = "Swiftwater";
            this.colSwiftwater.HeaderText = "Swiftwater";
            this.colSwiftwater.Name = "colSwiftwater";
            this.colSwiftwater.ReadOnly = true;
            // 
            // colMR
            // 
            this.colMR.DataPropertyName = "MountainRescue";
            this.colMR.HeaderText = "Mtn Resc.";
            this.colMR.Name = "colMR";
            this.colMR.ReadOnly = true;
            // 
            // colFirstAid
            // 
            this.colFirstAid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFirstAid.DataPropertyName = "FirstAid";
            this.colFirstAid.HeaderText = "First Aid";
            this.colFirstAid.Name = "colFirstAid";
            this.colFirstAid.ReadOnly = true;
            this.colFirstAid.Width = 84;
            // 
            // colGSAR
            // 
            this.colGSAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGSAR.DataPropertyName = "GSAR";
            this.colGSAR.HeaderText = "GSAR";
            this.colGSAR.Name = "colGSAR";
            this.colGSAR.ReadOnly = true;
            this.colGSAR.Width = 68;
            // 
            // colGSTL
            // 
            this.colGSTL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colGSTL.DataPropertyName = "GSTL";
            this.colGSTL.HeaderText = "GSTL";
            this.colGSTL.Name = "colGSTL";
            this.colGSTL.ReadOnly = true;
            this.colGSTL.Width = 64;
            // 
            // colSARM
            // 
            this.colSARM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSARM.DataPropertyName = "SARM";
            this.colSARM.HeaderText = "SARM";
            this.colSARM.Name = "colSARM";
            this.colSARM.ReadOnly = true;
            this.colSARM.Width = 70;
            // 
            // colSpecialSkills
            // 
            this.colSpecialSkills.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSpecialSkills.DataPropertyName = "SpecialSkills";
            this.colSpecialSkills.HeaderText = "Special Skills";
            this.colSpecialSkills.Name = "colSpecialSkills";
            this.colSpecialSkills.ReadOnly = true;
            this.colSpecialSkills.Width = 144;
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
            this.splitContainer1.Panel1.Controls.Add(this.cboSARGroup);
            this.splitContainer1.Panel1.Controls.Add(this.btnImportFromD4H);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(777, 539);
            this.splitContainer1.SplitterDistance = 60;
            this.splitContainer1.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "Group:";
            // 
            // cboSARGroup
            // 
            this.cboSARGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSARGroup.DisplayMember = "OrganizationName";
            this.cboSARGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSARGroup.FormattingEnabled = true;
            this.cboSARGroup.Location = new System.Drawing.Point(82, 16);
            this.cboSARGroup.Name = "cboSARGroup";
            this.cboSARGroup.Size = new System.Drawing.Size(419, 32);
            this.cboSARGroup.TabIndex = 61;
            this.cboSARGroup.ValueMember = "OrganizationID";
            this.cboSARGroup.SelectedIndexChanged += new System.EventHandler(this.cboSARGroup_SelectedIndexChanged);
            // 
            // btnImportFromD4H
            // 
            this.btnImportFromD4H.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportFromD4H.Image = global::SAR_Sign_In_Assist.Properties.Resources.d4hsmall;
            this.btnImportFromD4H.Location = new System.Drawing.Point(519, 4);
            this.btnImportFromD4H.Name = "btnImportFromD4H";
            this.btnImportFromD4H.Size = new System.Drawing.Size(255, 54);
            this.btnImportFromD4H.TabIndex = 0;
            this.btnImportFromD4H.Text = "Import from D4H";
            this.btnImportFromD4H.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportFromD4H.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportFromD4H.UseVisualStyleBackColor = true;
            this.btnImportFromD4H.Click += new System.EventHandler(this.btnImportFromD4H_Click);
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
            this.splitContainer2.Panel2.Controls.Add(this.btnAddNew);
            this.splitContainer2.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer2.Panel2.Controls.Add(this.btnEdit);
            this.splitContainer2.Size = new System.Drawing.Size(777, 475);
            this.splitContainer2.SplitterDistance = 397;
            this.splitContainer2.TabIndex = 60;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNew.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_371_plus;
            this.btnAddNew.Location = new System.Drawing.Point(12, 11);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(216, 54);
            this.btnAddNew.TabIndex = 51;
            this.btnAddNew.Text = "Add New Member";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_17_bin;
            this.btnDelete.Location = new System.Drawing.Point(645, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 54);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_151_square_edit;
            this.btnEdit.Location = new System.Drawing.Point(548, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 54);
            this.btnEdit.TabIndex = 53;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // EditSavedTeamMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 539);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditSavedTeamMembers";
            this.Text = "Edit Saved Team Members";
            this.Load += new System.EventHandler(this.EditSavedTeamMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMembers)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvTeamMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCallsign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colRR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTracker;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSwiftwater;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colMR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colFirstAid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGSAR;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGSTL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSARM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSpecialSkills;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnImportFromD4H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSARGroup;
    }
}