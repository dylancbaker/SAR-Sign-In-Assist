
namespace SAR_Sign_In_Assist
{
    partial class D4HImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(D4HImportForm));
            this.grpQualifications = new System.Windows.Forms.GroupBox();
            this.btnImportD4HQualifications = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCallsignColumn = new System.Windows.Forms.ComboBox();
            this.chkImportCallsigns = new System.Windows.Forms.CheckBox();
            this.cboImportToOrganization = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblMembersToImport = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnD4HQualificationHelp = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.grpQualifications.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpQualifications
            // 
            this.grpQualifications.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpQualifications.Controls.Add(this.btnD4HQualificationHelp);
            this.grpQualifications.Controls.Add(this.btnImportD4HQualifications);
            this.grpQualifications.Location = new System.Drawing.Point(12, 287);
            this.grpQualifications.Name = "grpQualifications";
            this.grpQualifications.Size = new System.Drawing.Size(460, 122);
            this.grpQualifications.TabIndex = 32;
            this.grpQualifications.TabStop = false;
            this.grpQualifications.Text = "Import Qualification Matrix";
            // 
            // btnImportD4HQualifications
            // 
            this.btnImportD4HQualifications.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_399_import;
            this.btnImportD4HQualifications.Location = new System.Drawing.Point(10, 28);
            this.btnImportD4HQualifications.Name = "btnImportD4HQualifications";
            this.btnImportD4HQualifications.Size = new System.Drawing.Size(394, 80);
            this.btnImportD4HQualifications.TabIndex = 27;
            this.btnImportD4HQualifications.Text = "Import D4H Qualification Matrix";
            this.btnImportD4HQualifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportD4HQualifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportD4HQualifications.UseVisualStyleBackColor = true;
            this.btnImportD4HQualifications.Click += new System.EventHandler(this.btnImportD4HQualifications_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblMembersToImport);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCallsignColumn);
            this.groupBox1.Controls.Add(this.chkImportCallsigns);
            this.groupBox1.Controls.Add(this.cboImportToOrganization);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 269);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Members";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Callsign Column:";
            // 
            // cboCallsignColumn
            // 
            this.cboCallsignColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCallsignColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCallsignColumn.FormattingEnabled = true;
            this.cboCallsignColumn.Location = new System.Drawing.Point(365, 138);
            this.cboCallsignColumn.Name = "cboCallsignColumn";
            this.cboCallsignColumn.Size = new System.Drawing.Size(83, 32);
            this.cboCallsignColumn.TabIndex = 34;
            this.cboCallsignColumn.SelectedIndexChanged += new System.EventHandler(this.cboCallsignColumn_SelectedIndexChanged);
            // 
            // chkImportCallsigns
            // 
            this.chkImportCallsigns.AutoSize = true;
            this.chkImportCallsigns.Location = new System.Drawing.Point(10, 140);
            this.chkImportCallsigns.Name = "chkImportCallsigns";
            this.chkImportCallsigns.Size = new System.Drawing.Size(171, 28);
            this.chkImportCallsigns.TabIndex = 33;
            this.chkImportCallsigns.Text = "Import Callsigns?";
            this.chkImportCallsigns.UseVisualStyleBackColor = true;
            // 
            // cboImportToOrganization
            // 
            this.cboImportToOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboImportToOrganization.DisplayMember = "OrganizationName";
            this.cboImportToOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImportToOrganization.FormattingEnabled = true;
            this.cboImportToOrganization.Location = new System.Drawing.Point(10, 100);
            this.cboImportToOrganization.Name = "cboImportToOrganization";
            this.cboImportToOrganization.Size = new System.Drawing.Size(438, 32);
            this.cboImportToOrganization.TabIndex = 32;
            this.cboImportToOrganization.ValueMember = "OrganizationID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Import to this group:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(350, 28);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(98, 45);
            this.btnBrowse.TabIndex = 36;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblMembersToImport
            // 
            this.lblMembersToImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMembersToImport.Location = new System.Drawing.Point(10, 28);
            this.lblMembersToImport.Name = "lblMembersToImport";
            this.lblMembersToImport.Size = new System.Drawing.Size(334, 45);
            this.lblMembersToImport.TabIndex = 37;
            this.lblMembersToImport.Text = "Please select the d4h members file";
            this.lblMembersToImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV Files|*.csv";
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDone.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_223_chevron_left;
            this.btnDone.Location = new System.Drawing.Point(12, 419);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(121, 50);
            this.btnDone.TabIndex = 34;
            this.btnDone.Text = "Done";
            this.btnDone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnD4HQualificationHelp
            // 
            this.btnD4HQualificationHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnD4HQualificationHelp.BackgroundImage = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_931_speech_bubble_question;
            this.btnD4HQualificationHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnD4HQualificationHelp.Location = new System.Drawing.Point(417, 52);
            this.btnD4HQualificationHelp.Name = "btnD4HQualificationHelp";
            this.btnD4HQualificationHelp.Size = new System.Drawing.Size(31, 32);
            this.btnD4HQualificationHelp.TabIndex = 88;
            this.btnD4HQualificationHelp.TabStop = false;
            this.btnD4HQualificationHelp.UseVisualStyleBackColor = true;
            this.btnD4HQualificationHelp.Click += new System.EventHandler(this.btnD4HQualificationHelp_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_399_import;
            this.btnImport.Location = new System.Drawing.Point(10, 176);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(438, 87);
            this.btnImport.TabIndex = 26;
            this.btnImport.Text = "Import D4H Members";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // D4HImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 481);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.grpQualifications);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(500, 520);
            this.MinimumSize = new System.Drawing.Size(500, 520);
            this.Name = "D4HImportForm";
            this.Text = "D4H Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.D4HImportForm_FormClosing);
            this.Load += new System.EventHandler(this.D4HImportForm_Load);
            this.grpQualifications.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpQualifications;
        private System.Windows.Forms.Button btnD4HQualificationHelp;
        private System.Windows.Forms.Button btnImportD4HQualifications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCallsignColumn;
        private System.Windows.Forms.CheckBox chkImportCallsigns;
        private System.Windows.Forms.ComboBox cboImportToOrganization;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblMembersToImport;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}