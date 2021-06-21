using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAR_Sign_In_Assist.ViewModels;
using SAR_Sign_In_Assist.Models;
using ICAClassLibrary.Models;

namespace SAR_Sign_In_Assist
{
    public partial class SignInMemberForm : Form
    {
        private SignInMemberViewModel _viewModel = null;
        TeamMember CurrentMember { get => _viewModel.CurrentMember; set => _viewModel.CurrentMember = value; }
        public string ActivityName { get => _viewModel.ActivityName; set { _viewModel.ActivityName = value; txtCurrentActivity.Text = value; } }
        public int OpPeriod { get => _viewModel.OpPeriod; set => _viewModel.OpPeriod = value; }
        public GeneralSignInRecord Record { get => _viewModel.record; }  //used to retrieve the newly created record in order to send it via the network.



        public SignInMemberForm()
        {
            InitializeComponent();
            if (_viewModel == null)
            {
                _viewModel = new SignInMemberViewModel();
            }
            editTeamMemberForm1.CurrentMember = CurrentMember;
        }

        private void SignInMemberForm_Load(object sender, EventArgs e)
        {

            cboSARGroup.DataSource = _viewModel.GetOrganizations();
            cboSARGroup.DisplayMember = "OrganizationName";
            cboSARGroup.ValueMember = "OrganizationID";
            if (_viewModel.SavedOrganizationID != Guid.Empty)
            {
                cboSARGroup.SelectedValue = _viewModel.SavedOrganizationID;
            }
            editTeamMemberForm1.CurrentMember = new ICAClassLibrary.Models.TeamMember();
            rbExistingMember.Checked = cboExistingMembers.Items.Count > 0;
            datSignInTime.Value = DateTime.Now;
        }



        private void cboSARGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Organization org = (Organization)cboSARGroup.SelectedItem;
            if (org != null && org.OrganizationID != Guid.Empty)
            {
                cboExistingMembers.DataSource = _viewModel.GetTeamMembers(org.OrganizationID);
            }
        }

      
        private void datSignInTime_ValueChanged(object sender, EventArgs e)
        {
            _viewModel.SignInTime = datSignInTime.Value;
        }

        private void txtCurrentActivity_TextChanged(object sender, EventArgs e)
        {
            _viewModel.ActivityName = txtCurrentActivity.Text;
        }

        private void chkUseMustBeOut_CheckedChanged(object sender, EventArgs e)
        {
            datMustBeOutTime.Enabled = chkUseMustBeOut.Checked;
            _viewModel.UseMustBeOut = chkUseMustBeOut.Checked;
        }

        private void datMustBeOutTime_ValueChanged(object sender, EventArgs e)
        {
            _viewModel.MustBeOutTime = datMustBeOutTime.Value;
        }

        private void btnQRScannerHelp_Click(object sender, EventArgs e)
        {
            HelpInfo info = new HelpInfo();
            if (info.loadByTopic("SignInAssist-Activity"))
            {
                using (BasicHelpInfo help = new BasicHelpInfo())
                {
                    help.Title = info.Title;
                    help.Body = info.Body;
                    help.ShowDialog();
                }
            }
        }

        private void editTeamMemberForm1_ChangesMade(object sender, EventArgs e)
        {
            //CurrentMember = editTeamMemberForm1.CurrentMember;
            rbNewMember.Checked = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (rbExistingMember.Checked && cboExistingMembers.SelectedItem != null)
            {
                _viewModel.CurrentMember = (TeamMember)cboExistingMembers.SelectedItem;
            }
            else
            {
                _viewModel.CurrentMember = editTeamMemberForm1.CurrentMember;
            }



            bool saveSuccessful = _viewModel.SaveSignInRecord();
            if (saveSuccessful)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("There was an error saving your sign in record. I wonder what I might be?");
            }
        }


        private void toggleRadioButton(RadioButton rb)
        {
            if (rb.Checked) { rb.ImageIndex = 1; }
            else { rb.ImageIndex = 0; }
        }


        private void rbExistingMember_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadioButton(rbExistingMember);
        }

        private void rbNewMember_CheckedChanged(object sender, EventArgs e)
        {
            toggleRadioButton(rbNewMember);
        }

        private void cboExistingMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbExistingMember.Checked = true;
        }
    }
}
