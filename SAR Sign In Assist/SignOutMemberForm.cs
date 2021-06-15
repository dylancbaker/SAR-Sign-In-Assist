using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAR_Sign_In_Assist
{
    public partial class SignOutMemberForm : Form
    {
        public DateTime SignOutTime { get => datDate.Value; set => datDate.Value = value; }
        public decimal KMs { get => numKMs.Value; set => numKMs.Value = value; }

        private bool _kmsEnabled = true;
        public bool KMsEnabled
        {
            get
            {
                return _kmsEnabled;
            }
            set
            {
                _kmsEnabled = value;
                lblKMs.Enabled = _kmsEnabled;
                numKMs.Enabled = _kmsEnabled;
            }
        }


        public SignOutMemberForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; this.Close();
        }

        private void SignOutMemberForm_Load(object sender, EventArgs e)
        {
            datDate.Value = DateTime.Now;
        }

        private void btnNow_Click(object sender, EventArgs e)
        {
            datDate.Value = DateTime.Now;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
