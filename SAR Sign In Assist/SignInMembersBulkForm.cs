using ICAClassLibrary.Models;
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
    public partial class SignInMembersBulkForm : Form
    {
        SignInList parent = null;

        public SignInMembersBulkForm()
        {
            InitializeComponent();
            dgvTeamMembers.AutoGenerateColumns = false;
        }

        private void SignInMembersBulkForm_Load(object sender, EventArgs e)
        {
            List<Organization> allGroups = new Organization().getStaticOrganizationList();
            
            Organization blankOrg = new Organization();
            blankOrg.OrganizationID = Guid.Empty;
            blankOrg.OrganizationName = "-All Groups-";
            allGroups.Insert(0, blankOrg);
            cboOrganization.DataSource = allGroups;

            buildMemberList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cboOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            buildMemberList();
        }

        private void buildMemberList()
        {
            GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();

            List<TeamMember> allMembers = options.AllTeamMembers.Where(o => o.MemberActive).OrderBy(o=>o.Name).ToList();

            Organization org = (Organization)cboOrganization.SelectedItem;
            if(org.OrganizationID != Guid.Empty)
            {
                allMembers = allMembers.Where(o => o.OrganizationID == org.OrganizationID).ToList();
            }
           
            //allMembers = allMembers.OrderByDescending(o => o.OrganizationID == options.OrganizationID).ThenBy(o => o.Name).ToList();
            dgvTeamMembers.DataSource = allMembers;

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            List<TeamMember> membersToSignIn = new List<TeamMember>();
            int checkIndex = dgvTeamMembers.Columns["chkSignIn"].Index;
            foreach (DataGridViewRow row in dgvTeamMembers.Rows)
            {
                if (row.Index >= 0)
                {
                    TeamMember member = (TeamMember)row.DataBoundItem;
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[checkIndex];
                    if (cell.Value == cell.TrueValue)
                    {
                        membersToSignIn.Add(member);
                    }
                }


            }
            foreach (TeamMember member in membersToSignIn)
            {
                GeneralSignInRecord record = new GeneralSignInRecord();
                record.StatusChangeTime = datExistingMember.Value;
                record.MemberID = member.PersonID;
                record.IsSignIn = true;
                record.ActivityName = txtCurrentActivity.Text;
                record.Active = true;
                record.teamMember = member;
                Program.signInListService.UpsertSignInRecord(record);

                //CurrentTask.AllSignInRecords.Add(record);
                //parent.SendNetworkObject(record);
                //if (!CurrentTask.TaskTeamMembers.Where(o => o.PersonID == member.PersonID).Any()) { CurrentTask.TaskTeamMembers.Add(member); }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvTeamMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex > 0)
            {
                if (dgvTeamMembers.Rows[e.RowIndex].Cells["chkSignIn"].Value != null)
                {
                    dgvTeamMembers.Rows[e.RowIndex].Cells["chkSignIn"].Value = !(bool)dgvTeamMembers.Rows[e.RowIndex].Cells["chkSignIn"].Value;
                }
                else
                {
                    dgvTeamMembers.Rows[e.RowIndex].Cells["chkSignIn"].Value = true;
                }
            }
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
    }
}
