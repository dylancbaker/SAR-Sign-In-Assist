
namespace SAR_Sign_In_Assist
{
    partial class EditOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditOptionsForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDefaultQRHelp = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.chkDefaultQRScanner = new System.Windows.Forms.CheckBox();
            this.cboOrganizationName = new System.Windows.Forms.ComboBox();
            this.btnHelpHomeGroupName = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnHelpDefaultPort = new System.Windows.Forms.Button();
            this.numDefaultPortNumber = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPortNumber)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_199_save;
            this.btnSave.Location = new System.Drawing.Point(418, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 51);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_223_chevron_left;
            this.btnCancel.Location = new System.Drawing.Point(14, 284);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 51);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDefaultQRHelp
            // 
            this.btnDefaultQRHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultQRHelp.BackgroundImage = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_931_speech_bubble_question;
            this.btnDefaultQRHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefaultQRHelp.Location = new System.Drawing.Point(509, 97);
            this.btnDefaultQRHelp.Name = "btnDefaultQRHelp";
            this.btnDefaultQRHelp.Size = new System.Drawing.Size(31, 32);
            this.btnDefaultQRHelp.TabIndex = 111;
            this.btnDefaultQRHelp.TabStop = false;
            this.btnDefaultQRHelp.UseVisualStyleBackColor = true;
            this.btnDefaultQRHelp.Click += new System.EventHandler(this.btnDefaultQRHelp_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(82, 101);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 24);
            this.label23.TabIndex = 109;
            this.label23.Text = "Listen for QR";
            // 
            // chkDefaultQRScanner
            // 
            this.chkDefaultQRScanner.AutoSize = true;
            this.chkDefaultQRScanner.Location = new System.Drawing.Point(206, 99);
            this.chkDefaultQRScanner.Name = "chkDefaultQRScanner";
            this.chkDefaultQRScanner.Size = new System.Drawing.Size(292, 28);
            this.chkDefaultQRScanner.TabIndex = 110;
            this.chkDefaultQRScanner.Text = "Yes, listen for QR scanner input";
            this.chkDefaultQRScanner.UseVisualStyleBackColor = true;
            // 
            // cboOrganizationName
            // 
            this.cboOrganizationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboOrganizationName.DisplayMember = "OrganizationName";
            this.cboOrganizationName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganizationName.FormattingEnabled = true;
            this.cboOrganizationName.Location = new System.Drawing.Point(206, 147);
            this.cboOrganizationName.Name = "cboOrganizationName";
            this.cboOrganizationName.Size = new System.Drawing.Size(297, 32);
            this.cboOrganizationName.TabIndex = 113;
            this.cboOrganizationName.ValueMember = "OrganizationID";
            // 
            // btnHelpHomeGroupName
            // 
            this.btnHelpHomeGroupName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpHomeGroupName.BackgroundImage = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_931_speech_bubble_question;
            this.btnHelpHomeGroupName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelpHomeGroupName.Location = new System.Drawing.Point(509, 147);
            this.btnHelpHomeGroupName.Name = "btnHelpHomeGroupName";
            this.btnHelpHomeGroupName.Size = new System.Drawing.Size(31, 32);
            this.btnHelpHomeGroupName.TabIndex = 114;
            this.btnHelpHomeGroupName.TabStop = false;
            this.btnHelpHomeGroupName.UseVisualStyleBackColor = true;
            this.btnHelpHomeGroupName.Click += new System.EventHandler(this.btnHelpHomeGroupName_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 151);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 24);
            this.label18.TabIndex = 112;
            this.label18.Text = "Primary SAR Group";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(12, 197);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(212, 29);
            this.label25.TabIndex = 115;
            this.label25.Text = "Network Settings";
            // 
            // btnHelpDefaultPort
            // 
            this.btnHelpDefaultPort.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpDefaultPort.BackgroundImage = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_931_speech_bubble_question;
            this.btnHelpDefaultPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHelpDefaultPort.Location = new System.Drawing.Point(332, 227);
            this.btnHelpDefaultPort.Name = "btnHelpDefaultPort";
            this.btnHelpDefaultPort.Size = new System.Drawing.Size(31, 32);
            this.btnHelpDefaultPort.TabIndex = 118;
            this.btnHelpDefaultPort.TabStop = false;
            this.btnHelpDefaultPort.UseVisualStyleBackColor = false;
            this.btnHelpDefaultPort.Click += new System.EventHandler(this.btnHelpDefaultPort_Click);
            // 
            // numDefaultPortNumber
            // 
            this.numDefaultPortNumber.Location = new System.Drawing.Point(206, 229);
            this.numDefaultPortNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numDefaultPortNumber.Name = "numDefaultPortNumber";
            this.numDefaultPortNumber.Size = new System.Drawing.Size(120, 29);
            this.numDefaultPortNumber.TabIndex = 117;
            this.numDefaultPortNumber.Value = new decimal(new int[] {
            42999,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(101, 231);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(99, 24);
            this.label26.TabIndex = 116;
            this.label26.Text = "Port to use";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 29);
            this.label1.TabIndex = 119;
            this.label1.Text = "General Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 41);
            this.panel1.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(526, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Note: changes here will also impact ICA on this computer.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 349);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHelpDefaultPort);
            this.Controls.Add(this.numDefaultPortNumber);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cboOrganizationName);
            this.Controls.Add(this.btnHelpHomeGroupName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnDefaultQRHelp);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.chkDefaultQRScanner);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "EditOptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.EditOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDefaultPortNumber)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDefaultQRHelp;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox chkDefaultQRScanner;
        private System.Windows.Forms.ComboBox cboOrganizationName;
        private System.Windows.Forms.Button btnHelpHomeGroupName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnHelpDefaultPort;
        private System.Windows.Forms.NumericUpDown numDefaultPortNumber;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}