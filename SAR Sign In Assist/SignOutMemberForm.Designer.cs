
namespace SAR_Sign_In_Assist
{
    partial class SignOutMemberForm
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
            this.lblKMs = new System.Windows.Forms.Label();
            this.numKMs = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNow = new System.Windows.Forms.Button();
            this.datDate = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKMs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKMs
            // 
            this.lblKMs.AutoSize = true;
            this.lblKMs.Location = new System.Drawing.Point(418, 40);
            this.lblKMs.Name = "lblKMs";
            this.lblKMs.Size = new System.Drawing.Size(47, 24);
            this.lblKMs.TabIndex = 14;
            this.lblKMs.Text = "KMs";
            // 
            // numKMs
            // 
            this.numKMs.Location = new System.Drawing.Point(471, 38);
            this.numKMs.Name = "numKMs";
            this.numKMs.Size = new System.Drawing.Size(120, 29);
            this.numKMs.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select a sign out time";
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(273, 36);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(119, 32);
            this.btnNow.TabIndex = 9;
            this.btnNow.Text = "Set to Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // datDate
            // 
            this.datDate.CustomFormat = "HH:mm";
            this.datDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datDate.Location = new System.Drawing.Point(11, 38);
            this.datDate.Name = "datDate";
            this.datDate.Size = new System.Drawing.Size(256, 29);
            this.datDate.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_223_chevron_left;
            this.btnCancel.Location = new System.Drawing.Point(11, 74);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 41);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Image = global::SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_55_clock;
            this.btnOK.Location = new System.Drawing.Point(451, 78);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(141, 41);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "Sign Out";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SignOutMemberForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(604, 131);
            this.ControlBox = false;
            this.Controls.Add(this.lblKMs);
            this.Controls.Add(this.numKMs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnNow);
            this.Controls.Add(this.datDate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(620, 170);
            this.MinimumSize = new System.Drawing.Size(620, 170);
            this.Name = "SignOutMemberForm";
            this.Text = "Select Sign Out Time";
            this.Load += new System.EventHandler(this.SignOutMemberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKMs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKMs;
        private System.Windows.Forms.NumericUpDown numKMs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.DateTimePicker datDate;
    }
}