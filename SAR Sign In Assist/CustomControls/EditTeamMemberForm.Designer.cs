
namespace SAR_Sign_In_Assist.CustomControls
{
    partial class EditTeamMemberForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTeamMemberForm));
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOrganization = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCallsign = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNOKPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNOKRelationship = new System.Windows.Forms.TextBox();
            this.txtSpecialSkills = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNOKName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkMountainRescue = new System.Windows.Forms.CheckBox();
            this.chkSwiftwater = new System.Windows.Forms.CheckBox();
            this.chkFirstAid = new System.Windows.Forms.CheckBox();
            this.chkGSAR = new System.Windows.Forms.CheckBox();
            this.chkTracker = new System.Windows.Forms.CheckBox();
            this.chkRopeRescue = new System.Windows.Forms.CheckBox();
            this.chkGSTL = new System.Windows.Forms.CheckBox();
            this.chkSARM = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(636, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(189, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(402, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 21;
            this.label3.Text = "Call Sign";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(500, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 27);
            this.label4.TabIndex = 22;
            this.label4.Text = "Phone";
            // 
            // cboOrganization
            // 
            this.cboOrganization.DisplayMember = "OrganizationName";
            this.cboOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrganization.FormattingEnabled = true;
            this.cboOrganization.Location = new System.Drawing.Point(197, 44);
            this.cboOrganization.Name = "cboOrganization";
            this.cboOrganization.Size = new System.Drawing.Size(201, 28);
            this.cboOrganization.TabIndex = 15;
            this.cboOrganization.ValueMember = "OrganizationID";
            this.cboOrganization.SelectedIndexChanged += new System.EventHandler(this.cboOrganization_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(640, 45);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 26);
            this.txtEmail.TabIndex = 18;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(18, 45);
            this.txtName.Margin = new System.Windows.Forms.Padding(6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(168, 26);
            this.txtName.TabIndex = 14;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtCallsign
            // 
            this.txtCallsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCallsign.Location = new System.Drawing.Point(407, 45);
            this.txtCallsign.Margin = new System.Windows.Forms.Padding(6);
            this.txtCallsign.Name = "txtCallsign";
            this.txtCallsign.Size = new System.Drawing.Size(88, 26);
            this.txtCallsign.TabIndex = 16;
            this.txtCallsign.TextChanged += new System.EventHandler(this.txtCallsign_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(505, 45);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(123, 26);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(481, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 27);
            this.label15.TabIndex = 18;
            this.label15.Text = "Phone";
            // 
            // txtNOKPhone
            // 
            this.txtNOKPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKPhone.Location = new System.Drawing.Point(483, 248);
            this.txtNOKPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtNOKPhone.Name = "txtNOKPhone";
            this.txtNOKPhone.Size = new System.Drawing.Size(123, 26);
            this.txtNOKPhone.TabIndex = 16;
            this.txtNOKPhone.TextChanged += new System.EventHandler(this.txtNOKPhone_TextChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(570, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Special Skills";
            // 
            // txtNOKRelationship
            // 
            this.txtNOKRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKRelationship.Location = new System.Drawing.Point(311, 248);
            this.txtNOKRelationship.Name = "txtNOKRelationship";
            this.txtNOKRelationship.Size = new System.Drawing.Size(163, 26);
            this.txtNOKRelationship.TabIndex = 15;
            this.txtNOKRelationship.TextChanged += new System.EventHandler(this.txtNOKRelationship_TextChanged);
            // 
            // txtSpecialSkills
            // 
            this.txtSpecialSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialSkills.Location = new System.Drawing.Point(571, 119);
            this.txtSpecialSkills.Margin = new System.Windows.Forms.Padding(6);
            this.txtSpecialSkills.Name = "txtSpecialSkills";
            this.txtSpecialSkills.Size = new System.Drawing.Size(268, 26);
            this.txtSpecialSkills.TabIndex = 11;
            this.txtSpecialSkills.TextChanged += new System.EventHandler(this.txtSpecialSkills_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(312, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 24);
            this.label14.TabIndex = 10;
            this.label14.Text = "Relationship";
            // 
            // txtNOKName
            // 
            this.txtNOKName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOKName.Location = new System.Drawing.Point(18, 248);
            this.txtNOKName.Name = "txtNOKName";
            this.txtNOKName.Size = new System.Drawing.Size(287, 26);
            this.txtNOKName.TabIndex = 14;
            this.txtNOKName.TextChanged += new System.EventHandler(this.txtNOKName_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(176, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "Emergency Contact";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(18, 183);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(606, 26);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Address";
            // 
            // txtRef
            // 
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.Location = new System.Drawing.Point(632, 183);
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(207, 26);
            this.txtRef.TabIndex = 13;
            this.txtRef.TextChanged += new System.EventHandler(this.txtRef_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(628, 156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "EMBC ID";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "check-box-unchecked.png");
            this.imageList1.Images.SetKeyName(1, "check-box-checked.png");
            // 
            // chkMountainRescue
            // 
            this.chkMountainRescue.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMountainRescue.AutoSize = true;
            this.chkMountainRescue.FlatAppearance.BorderSize = 0;
            this.chkMountainRescue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMountainRescue.ImageIndex = 0;
            this.chkMountainRescue.ImageList = this.imageList1;
            this.chkMountainRescue.Location = new System.Drawing.Point(444, 119);
            this.chkMountainRescue.Margin = new System.Windows.Forms.Padding(6);
            this.chkMountainRescue.Name = "chkMountainRescue";
            this.chkMountainRescue.Size = new System.Drawing.Size(114, 34);
            this.chkMountainRescue.TabIndex = 20;
            this.chkMountainRescue.Text = "Mountain";
            this.chkMountainRescue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkMountainRescue.UseVisualStyleBackColor = true;
            this.chkMountainRescue.CheckedChanged += new System.EventHandler(this.chkMountainRescue_CheckedChanged);
            // 
            // chkSwiftwater
            // 
            this.chkSwiftwater.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSwiftwater.AutoSize = true;
            this.chkSwiftwater.FlatAppearance.BorderSize = 0;
            this.chkSwiftwater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSwiftwater.ImageIndex = 0;
            this.chkSwiftwater.ImageList = this.imageList1;
            this.chkSwiftwater.Location = new System.Drawing.Point(444, 83);
            this.chkSwiftwater.Margin = new System.Windows.Forms.Padding(6);
            this.chkSwiftwater.Name = "chkSwiftwater";
            this.chkSwiftwater.Size = new System.Drawing.Size(119, 34);
            this.chkSwiftwater.TabIndex = 19;
            this.chkSwiftwater.Text = "Swiftwater";
            this.chkSwiftwater.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkSwiftwater.UseVisualStyleBackColor = true;
            this.chkSwiftwater.CheckedChanged += new System.EventHandler(this.chkSwiftwater_CheckedChanged);
            // 
            // chkFirstAid
            // 
            this.chkFirstAid.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkFirstAid.AutoSize = true;
            this.chkFirstAid.FlatAppearance.BorderSize = 0;
            this.chkFirstAid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFirstAid.ImageIndex = 0;
            this.chkFirstAid.ImageList = this.imageList1;
            this.chkFirstAid.Location = new System.Drawing.Point(280, 119);
            this.chkFirstAid.Margin = new System.Windows.Forms.Padding(6);
            this.chkFirstAid.Name = "chkFirstAid";
            this.chkFirstAid.Size = new System.Drawing.Size(104, 34);
            this.chkFirstAid.TabIndex = 8;
            this.chkFirstAid.Text = "First Aid";
            this.chkFirstAid.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkFirstAid.UseVisualStyleBackColor = true;
            this.chkFirstAid.CheckedChanged += new System.EventHandler(this.chkFirstAid_CheckedChanged);
            // 
            // chkGSAR
            // 
            this.chkGSAR.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGSAR.AutoSize = true;
            this.chkGSAR.FlatAppearance.BorderSize = 0;
            this.chkGSAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGSAR.ImageIndex = 0;
            this.chkGSAR.ImageList = this.imageList1;
            this.chkGSAR.Location = new System.Drawing.Point(18, 83);
            this.chkGSAR.Margin = new System.Windows.Forms.Padding(6);
            this.chkGSAR.Name = "chkGSAR";
            this.chkGSAR.Size = new System.Drawing.Size(88, 34);
            this.chkGSAR.TabIndex = 7;
            this.chkGSAR.Text = "GSAR";
            this.chkGSAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkGSAR.UseVisualStyleBackColor = true;
            this.chkGSAR.CheckedChanged += new System.EventHandler(this.chkGSAR_CheckedChanged);
            // 
            // chkTracker
            // 
            this.chkTracker.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkTracker.AutoSize = true;
            this.chkTracker.FlatAppearance.BorderSize = 0;
            this.chkTracker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkTracker.ImageIndex = 0;
            this.chkTracker.ImageList = this.imageList1;
            this.chkTracker.Location = new System.Drawing.Point(117, 119);
            this.chkTracker.Margin = new System.Windows.Forms.Padding(6);
            this.chkTracker.Name = "chkTracker";
            this.chkTracker.Size = new System.Drawing.Size(100, 34);
            this.chkTracker.TabIndex = 6;
            this.chkTracker.Text = "Tracker";
            this.chkTracker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkTracker.UseVisualStyleBackColor = true;
            this.chkTracker.CheckedChanged += new System.EventHandler(this.chkTracker_CheckedChanged);
            // 
            // chkRopeRescue
            // 
            this.chkRopeRescue.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRopeRescue.AutoSize = true;
            this.chkRopeRescue.FlatAppearance.BorderSize = 0;
            this.chkRopeRescue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRopeRescue.ImageIndex = 0;
            this.chkRopeRescue.ImageList = this.imageList1;
            this.chkRopeRescue.Location = new System.Drawing.Point(280, 83);
            this.chkRopeRescue.Margin = new System.Windows.Forms.Padding(6);
            this.chkRopeRescue.Name = "chkRopeRescue";
            this.chkRopeRescue.Size = new System.Drawing.Size(152, 34);
            this.chkRopeRescue.TabIndex = 5;
            this.chkRopeRescue.Text = "Rope Rescue";
            this.chkRopeRescue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkRopeRescue.UseVisualStyleBackColor = true;
            this.chkRopeRescue.CheckedChanged += new System.EventHandler(this.chkRopeRescue_CheckedChanged);
            // 
            // chkGSTL
            // 
            this.chkGSTL.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkGSTL.AutoSize = true;
            this.chkGSTL.FlatAppearance.BorderSize = 0;
            this.chkGSTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkGSTL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkGSTL.ImageIndex = 0;
            this.chkGSTL.ImageList = this.imageList1;
            this.chkGSTL.Location = new System.Drawing.Point(18, 119);
            this.chkGSTL.Name = "chkGSTL";
            this.chkGSTL.Size = new System.Drawing.Size(84, 34);
            this.chkGSTL.TabIndex = 10;
            this.chkGSTL.Text = "GSTL";
            this.chkGSTL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkGSTL.UseVisualStyleBackColor = true;
            this.chkGSTL.CheckedChanged += new System.EventHandler(this.chkGSTL_CheckedChanged);
            // 
            // chkSARM
            // 
            this.chkSARM.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSARM.AutoSize = true;
            this.chkSARM.FlatAppearance.BorderSize = 0;
            this.chkSARM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSARM.ImageIndex = 0;
            this.chkSARM.ImageList = this.imageList1;
            this.chkSARM.Location = new System.Drawing.Point(117, 83);
            this.chkSARM.Name = "chkSARM";
            this.chkSARM.Size = new System.Drawing.Size(154, 34);
            this.chkSARM.TabIndex = 9;
            this.chkSARM.Text = "SAR Manager";
            this.chkSARM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkSARM.UseVisualStyleBackColor = true;
            this.chkSARM.CheckedChanged += new System.EventHandler(this.chkSARM_CheckedChanged);
            // 
            // EditTeamMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chkMountainRescue);
            this.Controls.Add(this.txtNOKPhone);
            this.Controls.Add(this.chkSwiftwater);
            this.Controls.Add(this.txtNOKRelationship);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNOKName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSpecialSkills);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkFirstAid);
            this.Controls.Add(this.cboOrganization);
            this.Controls.Add(this.chkGSAR);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.chkTracker);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.chkRopeRescue);
            this.Controls.Add(this.txtCallsign);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.chkGSTL);
            this.Controls.Add(this.chkSARM);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditTeamMemberForm";
            this.Size = new System.Drawing.Size(857, 297);
            this.Load += new System.EventHandler(this.EditTeamMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOrganization;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCallsign;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox chkMountainRescue;
        private System.Windows.Forms.CheckBox chkSwiftwater;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNOKPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNOKRelationship;
        private System.Windows.Forms.TextBox txtSpecialSkills;
        private System.Windows.Forms.CheckBox chkFirstAid;
        private System.Windows.Forms.CheckBox chkGSAR;
        private System.Windows.Forms.CheckBox chkTracker;
        private System.Windows.Forms.CheckBox chkRopeRescue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNOKName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkSARM;
        private System.Windows.Forms.CheckBox chkGSTL;
        private System.Windows.Forms.ImageList imageList1;
    }
}
