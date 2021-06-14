using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ICAClassLibrary.Models;
using SAR_Sign_In_Assist.Services;

namespace SAR_Sign_In_Assist.CustomControls
{
    public partial class EditTeamMemberForm : UserControl
    {
        private TeamMember _currentMember = new TeamMember();
        public TeamMember CurrentMember { get => _currentMember; set { _currentMember = value; loadCurrentValues(); } }



        public EditTeamMemberForm()
        {
            InitializeComponent();
            CurrentMember = new TeamMember();
            List<Organization> allGroups = new Organization().getStaticOrganizationList();
            allGroups = allGroups.OrderBy(o => o.OrganizationName).ToList();
            cboOrganization.DataSource = allGroups;


        }

        private void loadCurrentValues()
        {
            if (CurrentMember != null)
            {
                txtName.Text = CurrentMember.Name;
                if (CurrentMember.OrganizationID != Guid.Empty)
                {
                    cboOrganization.SelectedValue = CurrentMember.OrganizationID;
                }
                else { cboOrganization.SelectedValue = new Guid("96BA69A4-436C-4DA1-85B1-992E84C36019"); }
                txtCallsign.Text = CurrentMember.Callsign;
                txtPhone.Text = CurrentMember.Phone;
                chkRopeRescue.Checked = CurrentMember.RopeRescue;
                chkTracker.Checked = CurrentMember.Tracker;
                chkFirstAid.Checked = CurrentMember.FirstAid;
                chkGSAR.Checked = CurrentMember.GSAR;
                txtSpecialSkills.Text = CurrentMember.SpecialSkills;
                chkGSTL.Checked = CurrentMember.GSTL;
                chkSARM.Checked = CurrentMember.SARM;
                chkSwiftwater.Checked = CurrentMember.Swiftwater;
                chkMountainRescue.Checked = CurrentMember.MountainRescue;
                txtRef.Text = CurrentMember.Reference;
                txtEmail.Text = CurrentMember.Email;
                txtAddress.Text = CurrentMember.Address;
                txtNOKName.Text = CurrentMember.NOKName;
                txtNOKRelationship.Text = CurrentMember.NOKRelation;
                txtNOKPhone.Text = CurrentMember.NOKPhone;
            }
            else
            {
                txtName.Text = "";
                GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();

                if (options.OrganizationID != Guid.Empty) { cboOrganization.SelectedValue = options.OrganizationID; }
                else { cboOrganization.SelectedValue = new Guid("96BA69A4-436C-4DA1-85B1-992E84C36019"); }
                txtCallsign.Text = "";
                txtPhone.Text = "";
                chkRopeRescue.Checked = false;
                chkTracker.Checked = false;
                chkFirstAid.Checked = false;
                chkGSAR.Checked = true;
                txtSpecialSkills.Text = "";
                chkGSTL.Checked = false;
                chkSARM.Checked = false;
                chkSwiftwater.Checked = false;
                chkMountainRescue.Checked = false;
                txtRef.Text = "";
                txtEmail.Text = "";
                txtAddress.Text = "";
                txtNOKName.Text = "";
                txtNOKRelationship.Text = "";
                txtNOKPhone.Text = "";
            }
        }

        public event EventHandler ChangesMade;
        protected virtual void OnChangesMade(EventArgs e)
        {
            EventHandler handler = this.ChangesMade;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private void toggleCheckbox(CheckBox chk)
        {
            if (chk.Checked) { chk.ImageIndex = 1; }
            else { chk.ImageIndex = 0; }
        }

        private void chkGSAR_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.GSAR = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void chkSARM_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.SARM = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void chkRopeRescue_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.RopeRescue = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void chkSwiftwater_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.Swiftwater = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void chkGSTL_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.GSTL = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void chkTracker_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.Tracker = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void chkFirstAid_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.FirstAid = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void chkMountainRescue_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            toggleCheckbox(chk);
            CurrentMember.MountainRescue = chk.Checked;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.Name = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void cboOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            Organization org = (Organization)cboOrganization.SelectedItem;
            if (CurrentMember != null)
            {
                CurrentMember.OrganizationID = org.OrganizationID;
                CurrentMember.Group = org.OrganizationName;
                OnChangesMade(EventArgs.Empty);
            }
        }

        private void txtCallsign_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.Callsign = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.Phone = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.Email = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtSpecialSkills_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.SpecialSkills = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.Address = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtRef_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.Reference = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtNOKName_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.NOKName = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtNOKRelationship_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.NOKRelation = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void txtNOKPhone_TextChanged(object sender, EventArgs e)
        {
            CurrentMember.NOKPhone = ((TextBox)sender).Text;
            OnChangesMade(EventArgs.Empty);
        }

        private void EditTeamMemberForm_Load(object sender, EventArgs e)
        {
            loadCurrentValues();
        }
    }
}
