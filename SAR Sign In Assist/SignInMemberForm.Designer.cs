
namespace SAR_Sign_In_Assist
{
    partial class SignInMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInMemberForm));
            this.pnlExistingMember = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSARGroup = new System.Windows.Forms.ComboBox();
            this.cboExistingMembers = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnQRScannerHelp = new System.Windows.Forms.Button();
            this.txtCurrentActivity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkUseMustBeOut = new System.Windows.Forms.CheckBox();
            this.datMustBeOutTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.datSignInTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbExistingMember = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rbNewMember = new System.Windows.Forms.RadioButton();
            this.editTeamMemberForm1 = new SAR_Sign_In_Assist.CustomControls.EditTeamMemberForm();
            this.pnlExistingMember.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExistingMember
            // 
            this.pnlExistingMember.BackColor = System.Drawing.Color.White;
            this.pnlExistingMember.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExistingMember.Controls.Add(this.label1);
            this.pnlExistingMember.Controls.Add(this.cboSARGroup);
            this.pnlExistingMember.Controls.Add(this.cboExistingMembers);
            this.pnlExistingMember.Location = new System.Drawing.Point(52, 12);
            this.pnlExistingMember.Name = "pnlExistingMember";
            this.pnlExistingMember.Size = new System.Drawing.Size(867, 124);
            this.pnlExistingMember.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select an Existing Member";
            // 
            // cboSARGroup
            // 
            this.cboSARGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSARGroup.DisplayMember = "OrganizationName";
            this.cboSARGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSARGroup.FormattingEnabled = true;
            this.cboSARGroup.Location = new System.Drawing.Point(10, 41);
            this.cboSARGroup.Name = "cboSARGroup";
            this.cboSARGroup.Size = new System.Drawing.Size(838, 32);
            this.cboSARGroup.TabIndex = 11;
            this.cboSARGroup.ValueMember = "OrganizationID";
            this.cboSARGroup.SelectedIndexChanged += new System.EventHandler(this.cboSARGroup_SelectedIndexChanged);
            // 
            // cboExistingMembers
            // 
            this.cboExistingMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboExistingMembers.DisplayMember = "Name";
            this.cboExistingMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExistingMembers.FormattingEnabled = true;
            this.cboExistingMembers.Location = new System.Drawing.Point(10, 79);
            this.cboExistingMembers.Name = "cboExistingMembers";
            this.cboExistingMembers.Size = new System.Drawing.Size(838, 32);
            this.cboExistingMembers.TabIndex = 10;
            this.cboExistingMembers.ValueMember = "PersonID";
            this.cboExistingMembers.SelectedIndexChanged += new System.EventHandler(this.cboExistingMembers_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.editTeamMemberForm1);
            this.panel2.Location = new System.Drawing.Point(52, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 338);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Add a New Member";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnQRScannerHelp);
            this.panel3.Controls.Add(this.txtCurrentActivity);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.chkUseMustBeOut);
            this.panel3.Controls.Add(this.datMustBeOutTime);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnSignIn);
            this.panel3.Controls.Add(this.datSignInTime);
            this.panel3.Location = new System.Drawing.Point(52, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 91);
            this.panel3.TabIndex = 0;
            // 
            // btnQRScannerHelp
            // 
            this.btnQRScannerHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQRScannerHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQRScannerHelp.BackgroundImage")));
            this.btnQRScannerHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQRScannerHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRScannerHelp.Location = new System.Drawing.Point(491, 14);
            this.btnQRScannerHelp.Name = "btnQRScannerHelp";
            this.btnQRScannerHelp.Size = new System.Drawing.Size(28, 28);
            this.btnQRScannerHelp.TabIndex = 52;
            this.btnQRScannerHelp.UseVisualStyleBackColor = true;
            this.btnQRScannerHelp.Click += new System.EventHandler(this.btnQRScannerHelp_Click);
            // 
            // txtCurrentActivity
            // 
            this.txtCurrentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentActivity.Location = new System.Drawing.Point(145, 13);
            this.txtCurrentActivity.Name = "txtCurrentActivity";
            this.txtCurrentActivity.Size = new System.Drawing.Size(340, 29);
            this.txtCurrentActivity.TabIndex = 51;
            this.txtCurrentActivity.TextChanged += new System.EventHandler(this.txtCurrentActivity_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Current Activity";
            // 
            // chkUseMustBeOut
            // 
            this.chkUseMustBeOut.AutoSize = true;
            this.chkUseMustBeOut.Location = new System.Drawing.Point(10, 48);
            this.chkUseMustBeOut.Name = "chkUseMustBeOut";
            this.chkUseMustBeOut.Size = new System.Drawing.Size(180, 28);
            this.chkUseMustBeOut.TabIndex = 15;
            this.chkUseMustBeOut.Text = "Must Be Out Time";
            this.chkUseMustBeOut.UseVisualStyleBackColor = true;
            this.chkUseMustBeOut.CheckedChanged += new System.EventHandler(this.chkUseMustBeOut_CheckedChanged);
            // 
            // datMustBeOutTime
            // 
            this.datMustBeOutTime.CustomFormat = "HH:mm";
            this.datMustBeOutTime.Enabled = false;
            this.datMustBeOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datMustBeOutTime.Location = new System.Drawing.Point(196, 48);
            this.datMustBeOutTime.Name = "datMustBeOutTime";
            this.datMustBeOutTime.Size = new System.Drawing.Size(122, 29);
            this.datMustBeOutTime.TabIndex = 14;
            this.datMustBeOutTime.ValueChanged += new System.EventHandler(this.datMustBeOutTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sign In Time";
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.SystemColors.Control;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Image")));
            this.btnSignIn.Location = new System.Drawing.Point(741, 13);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(119, 64);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // datSignInTime
            // 
            this.datSignInTime.CustomFormat = "HH:mm";
            this.datSignInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSignInTime.Location = new System.Drawing.Point(577, 43);
            this.datSignInTime.Name = "datSignInTime";
            this.datSignInTime.Size = new System.Drawing.Size(152, 29);
            this.datSignInTime.TabIndex = 11;
            this.datSignInTime.ValueChanged += new System.EventHandler(this.datSignInTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(438, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "- OR -";
            // 
            // rbExistingMember
            // 
            this.rbExistingMember.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbExistingMember.FlatAppearance.BorderSize = 0;
            this.rbExistingMember.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.rbExistingMember.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rbExistingMember.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rbExistingMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbExistingMember.ImageIndex = 0;
            this.rbExistingMember.ImageList = this.imageList1;
            this.rbExistingMember.Location = new System.Drawing.Point(10, 18);
            this.rbExistingMember.Name = "rbExistingMember";
            this.rbExistingMember.Size = new System.Drawing.Size(40, 40);
            this.rbExistingMember.TabIndex = 12;
            this.rbExistingMember.TabStop = true;
            this.rbExistingMember.UseVisualStyleBackColor = true;
            this.rbExistingMember.CheckedChanged += new System.EventHandler(this.rbExistingMember_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check-box-unchecked.png");
            this.imageList1.Images.SetKeyName(1, "check-box-checked.png");
            // 
            // rbNewMember
            // 
            this.rbNewMember.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbNewMember.FlatAppearance.BorderSize = 0;
            this.rbNewMember.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control;
            this.rbNewMember.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.rbNewMember.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.rbNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNewMember.ImageIndex = 0;
            this.rbNewMember.ImageList = this.imageList1;
            this.rbNewMember.Location = new System.Drawing.Point(10, 171);
            this.rbNewMember.Name = "rbNewMember";
            this.rbNewMember.Size = new System.Drawing.Size(40, 40);
            this.rbNewMember.TabIndex = 13;
            this.rbNewMember.TabStop = true;
            this.rbNewMember.UseVisualStyleBackColor = true;
            this.rbNewMember.CheckedChanged += new System.EventHandler(this.rbNewMember_CheckedChanged);
            // 
            // editTeamMemberForm1
            // 
            this.editTeamMemberForm1.CurrentMember = ((ICAClassLibrary.Models.TeamMember)(resources.GetObject("editTeamMemberForm1.CurrentMember")));
            this.editTeamMemberForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTeamMemberForm1.Location = new System.Drawing.Point(3, 33);
            this.editTeamMemberForm1.Margin = new System.Windows.Forms.Padding(6);
            this.editTeamMemberForm1.Name = "editTeamMemberForm1";
            this.editTeamMemberForm1.Size = new System.Drawing.Size(857, 297);
            this.editTeamMemberForm1.TabIndex = 0;
            this.editTeamMemberForm1.ChangesMade += new System.EventHandler(this.editTeamMemberForm1_ChangesMade);
            // 
            // SignInMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 619);
            this.Controls.Add(this.rbNewMember);
            this.Controls.Add(this.rbExistingMember);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlExistingMember);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SignInMemberForm";
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.SignInMemberForm_Load);
            this.pnlExistingMember.ResumeLayout(false);
            this.pnlExistingMember.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlExistingMember;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSARGroup;
        private System.Windows.Forms.ComboBox cboExistingMembers;
        private System.Windows.Forms.Label label2;
        private CustomControls.EditTeamMemberForm editTeamMemberForm1;
        private System.Windows.Forms.CheckBox chkUseMustBeOut;
        private System.Windows.Forms.DateTimePicker datMustBeOutTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.DateTimePicker datSignInTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnQRScannerHelp;
        private System.Windows.Forms.TextBox txtCurrentActivity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbNewMember;
        private System.Windows.Forms.RadioButton rbExistingMember;
        private System.Windows.Forms.ImageList imageList1;
    }
}