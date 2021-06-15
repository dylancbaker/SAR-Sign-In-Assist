
namespace SAR_Sign_In_Assist
{
    partial class EditMemberSignInTimes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMemberSignInTimes));
            this.pnlSignOut = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.numKMs = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.datSignOutTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSignIn = new System.Windows.Forms.Panel();
            this.chkMustBeOutTime = new System.Windows.Forms.CheckBox();
            this.datRequestedTimeOut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.datSignInTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnQRScannerHelp = new System.Windows.Forms.Button();
            this.txtCurrentActivity = new System.Windows.Forms.TextBox();
            this.lblCurrentActivity = new System.Windows.Forms.Label();
            this.pnlSignOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKMs)).BeginInit();
            this.pnlSignIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSignOut
            // 
            this.pnlSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSignOut.BackColor = System.Drawing.Color.White;
            this.pnlSignOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSignOut.Controls.Add(this.label4);
            this.pnlSignOut.Controls.Add(this.numKMs);
            this.pnlSignOut.Controls.Add(this.label6);
            this.pnlSignOut.Controls.Add(this.datSignOutTime);
            this.pnlSignOut.Controls.Add(this.label1);
            this.pnlSignOut.Location = new System.Drawing.Point(12, 166);
            this.pnlSignOut.Name = "pnlSignOut";
            this.pnlSignOut.Size = new System.Drawing.Size(385, 115);
            this.pnlSignOut.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 110;
            this.label4.Text = "KMs";
            // 
            // numKMs
            // 
            this.numKMs.Location = new System.Drawing.Point(203, 76);
            this.numKMs.Name = "numKMs";
            this.numKMs.Size = new System.Drawing.Size(120, 29);
            this.numKMs.TabIndex = 109;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 24);
            this.label6.TabIndex = 108;
            this.label6.Text = "Select a sign out time";
            // 
            // datSignOutTime
            // 
            this.datSignOutTime.CustomFormat = "HH:mm";
            this.datSignOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSignOutTime.Location = new System.Drawing.Point(203, 41);
            this.datSignOutTime.Name = "datSignOutTime";
            this.datSignOutTime.Size = new System.Drawing.Size(149, 29);
            this.datSignOutTime.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 106;
            this.label1.Text = "Sign Out Record";
            // 
            // pnlSignIn
            // 
            this.pnlSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSignIn.BackColor = System.Drawing.Color.White;
            this.pnlSignIn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSignIn.Controls.Add(this.chkMustBeOutTime);
            this.pnlSignIn.Controls.Add(this.datRequestedTimeOut);
            this.pnlSignIn.Controls.Add(this.label3);
            this.pnlSignIn.Controls.Add(this.datSignInTime);
            this.pnlSignIn.Controls.Add(this.label5);
            this.pnlSignIn.Location = new System.Drawing.Point(12, 41);
            this.pnlSignIn.Name = "pnlSignIn";
            this.pnlSignIn.Size = new System.Drawing.Size(385, 119);
            this.pnlSignIn.TabIndex = 14;
            // 
            // chkMustBeOutTime
            // 
            this.chkMustBeOutTime.AutoSize = true;
            this.chkMustBeOutTime.Location = new System.Drawing.Point(17, 76);
            this.chkMustBeOutTime.Name = "chkMustBeOutTime";
            this.chkMustBeOutTime.Size = new System.Drawing.Size(180, 28);
            this.chkMustBeOutTime.TabIndex = 111;
            this.chkMustBeOutTime.Text = "Must Be Out Time";
            this.chkMustBeOutTime.UseVisualStyleBackColor = true;
            this.chkMustBeOutTime.CheckedChanged += new System.EventHandler(this.chkMustBeOutTime_CheckedChanged);
            // 
            // datRequestedTimeOut
            // 
            this.datRequestedTimeOut.CustomFormat = "HH:mm";
            this.datRequestedTimeOut.Enabled = false;
            this.datRequestedTimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datRequestedTimeOut.Location = new System.Drawing.Point(203, 76);
            this.datRequestedTimeOut.Name = "datRequestedTimeOut";
            this.datRequestedTimeOut.Size = new System.Drawing.Size(152, 29);
            this.datRequestedTimeOut.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 24);
            this.label3.TabIndex = 107;
            this.label3.Text = "Sign In Time";
            // 
            // datSignInTime
            // 
            this.datSignInTime.CustomFormat = "HH:mm";
            this.datSignInTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datSignInTime.Location = new System.Drawing.Point(203, 41);
            this.datSignInTime.Name = "datSignInTime";
            this.datSignInTime.Size = new System.Drawing.Size(152, 29);
            this.datSignInTime.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 105;
            this.label5.Text = "Sign In Record";
            // 
            // lblMemberName
            // 
            this.lblMemberName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(12, 9);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(183, 29);
            this.lblMemberName.TabIndex = 13;
            this.lblMemberName.Text = "John Q Smithington";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_223_chevron_left;
            this.btnCancel.Location = new System.Drawing.Point(12, 348);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 50);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_199_save;
            this.btnSave.Location = new System.Drawing.Point(217, 348);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 50);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnQRScannerHelp
            // 
            this.btnQRScannerHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQRScannerHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQRScannerHelp.BackgroundImage")));
            this.btnQRScannerHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQRScannerHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRScannerHelp.Location = new System.Drawing.Point(369, 314);
            this.btnQRScannerHelp.Name = "btnQRScannerHelp";
            this.btnQRScannerHelp.Size = new System.Drawing.Size(28, 28);
            this.btnQRScannerHelp.TabIndex = 52;
            this.btnQRScannerHelp.UseVisualStyleBackColor = true;
            // 
            // txtCurrentActivity
            // 
            this.txtCurrentActivity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCurrentActivity.Location = new System.Drawing.Point(12, 313);
            this.txtCurrentActivity.Name = "txtCurrentActivity";
            this.txtCurrentActivity.Size = new System.Drawing.Size(351, 29);
            this.txtCurrentActivity.TabIndex = 51;
            // 
            // lblCurrentActivity
            // 
            this.lblCurrentActivity.AutoSize = true;
            this.lblCurrentActivity.Location = new System.Drawing.Point(8, 284);
            this.lblCurrentActivity.Name = "lblCurrentActivity";
            this.lblCurrentActivity.Size = new System.Drawing.Size(67, 24);
            this.lblCurrentActivity.TabIndex = 50;
            this.lblCurrentActivity.Text = "Activity";
            // 
            // EditMemberSignInTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnQRScannerHelp);
            this.Controls.Add(this.txtCurrentActivity);
            this.Controls.Add(this.lblCurrentActivity);
            this.Controls.Add(this.pnlSignOut);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlSignIn);
            this.Controls.Add(this.lblMemberName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(425, 450);
            this.MinimumSize = new System.Drawing.Size(425, 400);
            this.Name = "EditMemberSignInTimes";
            this.Text = "Edit Member Sign In Times";
            this.Load += new System.EventHandler(this.EditMemberSignInTimes_Load);
            this.pnlSignOut.ResumeLayout(false);
            this.pnlSignOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKMs)).EndInit();
            this.pnlSignIn.ResumeLayout(false);
            this.pnlSignIn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSignOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKMs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datSignOutTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlSignIn;
        private System.Windows.Forms.CheckBox chkMustBeOutTime;
        private System.Windows.Forms.DateTimePicker datRequestedTimeOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datSignInTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Button btnQRScannerHelp;
        private System.Windows.Forms.TextBox txtCurrentActivity;
        private System.Windows.Forms.Label lblCurrentActivity;
    }
}