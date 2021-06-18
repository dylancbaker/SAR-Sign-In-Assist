using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICAClassLibrary;
using ICAClassLibrary.Models;

namespace SAR_Sign_In_Assist
{
    public partial class EditSavedTeamMembers : Form
    {
        public EditSavedTeamMembers()
        {
            InitializeComponent();
            dgvTeamMembers.AutoGenerateColumns = false;
        }

        private void EditSavedTeamMembers_Load(object sender, EventArgs e)
        {
            List<Organization> allGroups = new Organization().getStaticOrganizationList(true);
            cboSARGroup.DataSource = allGroups;
        }

        private void cboSARGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMemberList();
        }

        private void updateMemberList()
        {
            Organization org = (Organization)cboSARGroup.SelectedItem;
            GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
            List<TeamMember> members = options.AllTeamMembers.Where(o => o.MemberActive).OrderBy(o=>o.Name).ToList();
            if(org.OrganizationID != Guid.Empty) { members = members.Where(o => o.OrganizationID == org.OrganizationID).ToList(); }
            dgvTeamMembers.DataSource = members;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeamMembers.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected members?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
                    foreach (DataGridViewRow row in dgvTeamMembers.SelectedRows)
                    {
                        TeamMember member = (TeamMember)row.DataBoundItem;
                        options.AllTeamMembers = options.AllTeamMembers.Where(o => o.PersonID != member.PersonID).ToList();
                    }
                    Program.generalOptionsService.SaveGeneralOptions();
                    updateMemberList();
                }
            }
        }

        private void dgvTeamMembers_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dgvTeamMembers.SelectedRows.Count == 1;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            TeamMember member = new TeamMember();
            using (EditMemberForm editMemberForm = new EditMemberForm())
            {
                editMemberForm.memberToEdit = member;
                DialogResult dr = editMemberForm.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    updateMemberList();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TeamMember member = (TeamMember)dgvTeamMembers.SelectedRows[0].DataBoundItem;

            using (EditMemberForm editMemberForm = new EditMemberForm())
            {
                editMemberForm.memberToEdit = member;
                DialogResult dr = editMemberForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    updateMemberList();
                }
            }
        }

        private void btnImportFromD4H_Click(object sender, EventArgs e)
        {

        }

        private void dgvTeamMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTeamMembers.SelectedRows.Count == 1)
            {
                TeamMember member = (TeamMember)dgvTeamMembers.SelectedRows[0].DataBoundItem;

                using (EditMemberForm editMemberForm = new EditMemberForm())
                {
                    editMemberForm.memberToEdit = member;
                    DialogResult dr = editMemberForm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        updateMemberList();
                    }
                }
            }
        }
    }
}
