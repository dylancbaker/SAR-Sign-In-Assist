
namespace SAR_Sign_In_Assist
{
    partial class NetworkSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkSettings));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbStandalone = new System.Windows.Forms.RadioButton();
            this.pnlClientSettings = new System.Windows.Forms.Panel();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImportCoordinatesHelp = new System.Windows.Forms.Button();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlClientSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_199_save;
            this.btnSave.Location = new System.Drawing.Point(409, 213);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 49);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_223_chevron_left;
            this.btnCancel.Location = new System.Drawing.Point(14, 213);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 49);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbStandalone
            // 
            this.rbStandalone.AutoSize = true;
            this.rbStandalone.Checked = true;
            this.rbStandalone.Location = new System.Drawing.Point(17, 49);
            this.rbStandalone.Name = "rbStandalone";
            this.rbStandalone.Size = new System.Drawing.Size(248, 28);
            this.rbStandalone.TabIndex = 53;
            this.rbStandalone.TabStop = true;
            this.rbStandalone.Text = "Run on this computer only";
            this.rbStandalone.UseVisualStyleBackColor = true;
            this.rbStandalone.CheckedChanged += new System.EventHandler(this.rbStandalone_CheckedChanged);
            // 
            // pnlClientSettings
            // 
            this.pnlClientSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClientSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClientSettings.Controls.Add(this.txtServerPort);
            this.pnlClientSettings.Controls.Add(this.txtServerIP);
            this.pnlClientSettings.Controls.Add(this.label3);
            this.pnlClientSettings.Controls.Add(this.label2);
            this.pnlClientSettings.Enabled = false;
            this.pnlClientSettings.Location = new System.Drawing.Point(34, 121);
            this.pnlClientSettings.Name = "pnlClientSettings";
            this.pnlClientSettings.Size = new System.Drawing.Size(492, 77);
            this.pnlClientSettings.TabIndex = 56;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerPort.Location = new System.Drawing.Point(172, 38);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(315, 29);
            this.txtServerPort.TabIndex = 54;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerIP.Location = new System.Drawing.Point(172, 3);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(315, 29);
            this.txtServerIP.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Port Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "Server IP Address";
            // 
            // btnImportCoordinatesHelp
            // 
            this.btnImportCoordinatesHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImportCoordinatesHelp.BackgroundImage = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_931_speech_bubble_question;
            this.btnImportCoordinatesHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImportCoordinatesHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportCoordinatesHelp.Location = new System.Drawing.Point(488, 6);
            this.btnImportCoordinatesHelp.Name = "btnImportCoordinatesHelp";
            this.btnImportCoordinatesHelp.Size = new System.Drawing.Size(38, 38);
            this.btnImportCoordinatesHelp.TabIndex = 55;
            this.btnImportCoordinatesHelp.UseVisualStyleBackColor = true;
            this.btnImportCoordinatesHelp.Click += new System.EventHandler(this.btnImportCoordinatesHelp_Click);
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(12, 87);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(427, 28);
            this.rbClient.TabIndex = 54;
            this.rbClient.Text = "This computer will connect to another computer";
            this.rbClient.UseVisualStyleBackColor = true;
            this.rbClient.CheckedChanged += new System.EventHandler(this.rbClient_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Network Settings";
            // 
            // NetworkSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 274);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.rbStandalone);
            this.Controls.Add(this.pnlClientSettings);
            this.Controls.Add(this.btnImportCoordinatesHelp);
            this.Controls.Add(this.rbClient);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NetworkSettings";
            this.Text = "NetworkSettings";
            this.Load += new System.EventHandler(this.NetworkSettings_Load);
            this.pnlClientSettings.ResumeLayout(false);
            this.pnlClientSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbStandalone;
        private System.Windows.Forms.Panel pnlClientSettings;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportCoordinatesHelp;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.Label label1;
    }
}