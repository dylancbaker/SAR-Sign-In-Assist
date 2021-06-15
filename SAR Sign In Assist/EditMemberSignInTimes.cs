using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAR_Sign_In_Assist.Models;

namespace SAR_Sign_In_Assist
{
    public partial class EditMemberSignInTimes : Form
    {

        private GeneralSignInRecord _currentSignInRecord = null;
        public GeneralSignInRecord currentSignInRecord { get => _currentSignInRecord; set => _currentSignInRecord = value; }

        public EditMemberSignInTimes()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void EditMemberSignInTimes_Load(object sender, EventArgs e)
        {
            pnlSignOut.Enabled = !currentSignInRecord.IsSignIn;
            pnlSignIn.Enabled = currentSignInRecord.IsSignIn;
            txtCurrentActivity.Text = currentSignInRecord.ActivityName;
            if (currentSignInRecord.IsSignIn)
            {
                datSignInTime.Value = currentSignInRecord.StatusChangeTime;
                chkMustBeOutTime.Checked = (currentSignInRecord.TimeOutRequest > DateTime.MinValue && currentSignInRecord.TimeOutRequest < DateTime.MaxValue);
                if (currentSignInRecord.TimeOutRequest > datRequestedTimeOut.MinDate && currentSignInRecord.TimeOutRequest < datRequestedTimeOut.MaxDate) { datRequestedTimeOut.Value = currentSignInRecord.TimeOutRequest; }
            }
            else
            {
                numKMs.Value = currentSignInRecord.KMs;
                datSignOutTime.Value = currentSignInRecord.SignOutTime;
            }
            lblMemberName.Text = currentSignInRecord.teamMember.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentSignInRecord.ActivityName = txtCurrentActivity.Text;
            currentSignInRecord.KMs = numKMs.Value;
            if (currentSignInRecord.IsSignIn)
            {
                currentSignInRecord.StatusChangeTime = datSignInTime.Value;
                if (chkMustBeOutTime.Checked && datRequestedTimeOut.Value > datRequestedTimeOut.MinDate) { currentSignInRecord.TimeOutRequest = datRequestedTimeOut.Value; }
                else { currentSignInRecord.TimeOutRequest = DateTime.MinValue; }
            }
            else
            {
                currentSignInRecord.StatusChangeTime = datSignOutTime.Value;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chkMustBeOutTime_CheckedChanged(object sender, EventArgs e)
        {
            datRequestedTimeOut.Enabled = chkMustBeOutTime.Checked;
        }
    }
}
