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

namespace SAR_Sign_In_Assist
{
    public partial class D4HImportForm : Form
    {

        bool changesMade = false;

        public D4HImportForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnD4HQualificationHelp_Click(object sender, EventArgs e)
        {
            HelpInfo info = new HelpInfo();
            if (info.loadByTopic("D4HQualificationImport"))
            {
                using (BasicHelpInfo help = new BasicHelpInfo())
                {
                    help.Title = info.Title;
                    help.Body = info.Body;
                    help.ShowDialog();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                List<TeamMember> members = new TeamMember().getMembersFromCSV(openFileDialog1.FileName, -1);
                lblMembersToImport.Text = "Found " + members.Count + " members in the file";
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                int callsignColumn = cboCallsignColumn.SelectedIndex;
                if (!chkImportCallsigns.Checked) { callsignColumn = -1; }
                GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();

                List<TeamMember> members = new TeamMember().getMembersFromCSV(openFileDialog1.FileName, callsignColumn);

                Organization ImportOrg = (Organization)cboImportToOrganization.SelectedItem;

                //Check for duplicate Reference IDs in the import
                int duplicatecount = members.Where(o => !string.IsNullOrEmpty(o.Email)).GroupBy(x => x.Email).Where(g => g.Count() > 1).Select(y => y.Key).Count();
                bool anyDuplicateEmails = members.GroupBy(x => x.Email).Where(g => g.Count() > 1).Select(y => y.Key).Any();
                if (anyDuplicateEmails)
                {
                    // MessageBox.Show("It looks like you have some duplicate Emails in your data. The system normally uses the email to differentiate members. For best results in the future. \r\n\r\nThe system will now blank out any duplicate reference IDs and proceed with the import.");
                    List<string> duplciates = members.Where(o => !string.IsNullOrEmpty(o.Email)).GroupBy(x => x.Email).Where(g => g.Count() > 1).Select(y => y.Key).ToList();
                    foreach (string s in duplciates)
                    {
                        members.Where(o => o.Email.Equals(s, StringComparison.InvariantCultureIgnoreCase)).ToList().ForEach(o => o.Email = "");
                    }
                }

                int updateCount = 0;
                int AddCount = 0;

                foreach (TeamMember member in members)
                {
                    //if (!string.IsNullOrEmpty(txtImportGroupName.Text)) { member.Group = txtImportGroupName.Text; }
                    member.OrganizationID = ImportOrg.OrganizationID;
                    member.Group = ImportOrg.OrganizationName;
                    if (member.D4HStatus == "Retired") { member.MemberActive = false; }

                    //try to match reference
                    if (!string.IsNullOrEmpty(member.Email))
                    {
                        if (options.AllTeamMembers.Where(o => !string.IsNullOrEmpty(o.Email) && o.Email.Equals(member.Email, StringComparison.InvariantCultureIgnoreCase)).Any())
                        {
                            //update
                            TeamMember savedMember = options.AllTeamMembers.Where(o => !string.IsNullOrEmpty(o.Email) && o.Email.Equals(member.Email, StringComparison.InvariantCultureIgnoreCase)).First();
                            savedMember = updateMember(savedMember, member);
                            updateCount += 1;
                        }
                        else
                        {
                            //add
                            options.AllTeamMembers.Add(member);
                            AddCount += 1;
                        }
                    }
                    //failing that, match name and org
                    else
                    {
                        //update
                        if (options.AllTeamMembers.Where(o => !string.IsNullOrEmpty(o.Email) && o.Email.Equals(member.Email, StringComparison.InvariantCultureIgnoreCase) && o.OrganizationID == member.OrganizationID).Any())
                        {
                            TeamMember savedMember = options.AllTeamMembers.Where(o => o.Email.Equals(member.Email, StringComparison.InvariantCultureIgnoreCase) && o.OrganizationID == member.OrganizationID).First();
                            savedMember = updateMember(savedMember, member);
                            updateCount += 1;
                        }
                        else if (options.AllTeamMembers.Where(o => o.Name.Equals(member.Name, StringComparison.InvariantCultureIgnoreCase) && o.OrganizationID == member.OrganizationID).Any())
                        {
                            TeamMember savedMember = options.AllTeamMembers.Where(o => o.Name.Equals(member.Name, StringComparison.InvariantCultureIgnoreCase) && o.OrganizationID == member.OrganizationID).First();
                            savedMember = updateMember(savedMember, member);
                            updateCount += 1;
                        }
                        //add
                        else
                        {
                            options.AllTeamMembers.Add(member);
                            AddCount += 1;
                        }
                    }

                }
                Program.generalOptionsService.SaveGeneralOptions(options);
                MessageBox.Show("Added  " + AddCount + " and updated  " + updateCount + " members");
                changesMade = true;
            } else
            {
                MessageBox.Show("You must select the file you exported from d4h before proceeding. Use the \"Browse\" button.");
            }
        }

        private TeamMember updateMember(TeamMember savedMember, TeamMember newData)
        {
            if (savedMember != null)
            {
                savedMember.Phone = newData.Phone;
                savedMember.OrganizationID = newData.OrganizationID;
                savedMember.Group = newData.Group;
                savedMember.Address = newData.Address;
                savedMember.NOKName = newData.NOKName;
                savedMember.NOKPhone = newData.NOKPhone;
                savedMember.NOKRelation = newData.NOKRelation;
                savedMember.Email = newData.Email;
                savedMember.MemberActive = newData.MemberActive;
                savedMember.D4HStatus = newData.D4HStatus;
                savedMember.Callsign = newData.Callsign;
            }
            return savedMember;
        }
        private void D4HImportForm_Load(object sender, EventArgs e)
        {
            List<Organization> organizations = new Organization().getStaticOrganizationList();
            cboImportToOrganization.DataSource = organizations;
            cboImportToOrganization.DisplayMember = "OrganizationName";
            cboImportToOrganization.ValueMember = "OrganizationID";
            cboCallsignColumn.DataSource = getExcelColumns();
            cboImportToOrganization.SelectedValue = Program.generalOptionsService.GetGeneralOptions().OrganizationID;
            chkImportCallsigns.Checked = false;
            
        }

        private List<string> getExcelColumns()
        {
            List<string> columns = new List<string>();

            for (int x = 0; x < 26; x++)
            {
                columns.Add(char.ConvertFromUtf32(65 + x));
            }
            for (int x = 0; x < 26; x++)
            {
                columns.Add("A" + char.ConvertFromUtf32(65 + x));
            }
            for (int x = 0; x < 26; x++)
            {
                columns.Add("B" + char.ConvertFromUtf32(65 + x));
            }

            return columns;

        }


        private void cboCallsignColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkImportCallsigns.Checked = true;
        }

        private void btnImportD4HQualifications_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                int updatedMembers = 0;

                List<D4HQualifications> d4HQualifications = new TeamMember().getD4HQualificationsFromCSV(openFileDialog1.FileName);

                GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
                foreach (TeamMember member in options.AllTeamMembers)
                {
                    D4HQualifications qual = null;
                    if (!string.IsNullOrEmpty(member.Reference) && d4HQualifications.Where(o => o.Ref.Equals(member.Reference, StringComparison.InvariantCultureIgnoreCase)).Any())
                    {
                        qual = d4HQualifications.Where(o => o.Ref.Equals(member.Reference, StringComparison.InvariantCultureIgnoreCase)).First();

                    }
                    else if (string.IsNullOrEmpty(member.Name) && d4HQualifications.Where(o => o.MemberName.Equals(member.Name, StringComparison.InvariantCultureIgnoreCase)).Any())
                    {
                        qual = d4HQualifications.Where(o => o.MemberName.Equals(member.Name, StringComparison.InvariantCultureIgnoreCase)).First();
                    }

                    if (qual != null)
                    {
                        member.Tracker = false;
                        if (qual.gstl) { member.GSTL = qual.gstl; }
                        if (qual.sarm) { member.SARM = qual.sarm; }
                        if (qual.roperescue) { member.RopeRescue = qual.roperescue; }
                        if (qual.tracker) { member.Tracker = qual.tracker; }
                        if (qual.gsar) { member.GSAR = qual.gsar; }
                        if (qual.swiftwater) { member.Swiftwater = qual.swiftwater; } else { member.Swiftwater = false; } //this one expires!
                        if (qual.mountainrescue) { member.MountainRescue = qual.mountainrescue; }
                        updatedMembers += 1;
                    }
                }
                Program.generalOptionsService.SaveGeneralOptions(options);

                MessageBox.Show("Updated qualifications for " + updatedMembers + " members.");
                changesMade = true;
            }
        }

        private void D4HImportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changesMade) { this.DialogResult = DialogResult.OK; }
        }
    }
}
