using SAR_Sign_In_Assist.Models;
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
using ICAClassLibrary.Utilities;
using SAR_Sign_In_Assist.Services;

namespace SAR_Sign_In_Assist
{
    public partial class MemberStatusByActivityForm : Form
    {

        public event EventHandler MemberStatusByActivityForm_ListUpdated;


        public int OpPeriod { get => (int)numOperationalPeriod.Value; set => numOperationalPeriod.Value = value; }

        public MemberStatusByActivityForm()
        {
            InitializeComponent();
            dgvMembersOnTask.AutoGenerateColumns = false;
        }

        private void MemberStatusByActivityForm_Load(object sender, EventArgs e)
        {
            cboActivity.DataSource = Program.signInListService.GetAllActivities().OrderByDescending(o => o.EndDate).ToList();

        }

        private void cboActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateStatusList();
        }

        private void updateStatusList()
        {
            if (cboActivity.SelectedItem != null)
            {
                Activity act = (Activity)cboActivity.SelectedItem;

                List<MemberStatus> statuses = Program.signInListService.GetMemberStatus(act.ActivityName, act.StartDate, act.EndDate);
                dgvMembersOnTask.DataSource = statuses;

            }
            MemberStatusByActivityForm_ListUpdated?.Invoke(this, EventArgs.Empty);
        }

        private void dgvMembersOnTask_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMembersOnTask.Rows.Count > 0 && e.RowIndex <= dgvMembersOnTask.Rows.Count && dgvMembersOnTask.Rows[e.RowIndex] != null)
            {
                DataGridViewRow row = dgvMembersOnTask.Rows[e.RowIndex];


                MemberStatus status = (MemberStatus)row.DataBoundItem;


                if (status.getCurrentActivityName == "Signed Out")// Or your condition 
                {
                    foreach (DataGridViewCell c in row.Cells)
                    {
                        c.Style.BackColor = Color.LightGray;
                        c.Style.ForeColor = Color.DarkGray;
                    }

                }

                else
                {
                    foreach (DataGridViewCell c in row.Cells)
                    {
                        c.Style.BackColor = Color.White;
                        c.Style.ForeColor = Color.Black;
                    }
                }


            }

        }

        private void SignOutTheseMembers(List<MemberStatus> statuses)
        {


            if (statuses.Any())
            {
                Activity act = new Activity();
                if (cboActivity.SelectedItem != null)
                {
                    act = (Activity)cboActivity.SelectedItem;
                }

                using (SignOutMemberForm signOutForm = new SignOutMemberForm())
                {


                    DialogResult dr = signOutForm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        List<TeamMember> members = Program.signInListService.GetAllMembers();

                        foreach (MemberStatus status in statuses)
                        {


                            GeneralSignInRecord newRecord = new GeneralSignInRecord();

                            //need to get the original sign in record to retrieve the op period from it
                            List<GeneralSignInRecord> signInRecords = Program.signInListService.GetSignInRecords(status.SignInTime.AddSeconds(-2), status.SignInTime.AddSeconds(2), false, true, Guid.Empty, act.ActivityName);
                            if (signInRecords.Any())
                            {
                                newRecord.OpPeriod = signInRecords.First().OpPeriod;
                            }

                            if (members.Any(o => o.PersonID == status.MemberID))
                            {
                                newRecord.teamMember = members.Where(o => o.PersonID == status.MemberID).First();
                            }
                            else { newRecord.teamMember.PersonID = status.MemberID; newRecord.MemberName = status.MemberName; }

                            newRecord.StatusChangeTime = signOutForm.SignOutTime;
                            if (signOutForm.KMsEnabled)
                            {
                                newRecord.KMs = signOutForm.KMs;
                            }
                            newRecord.Active = true;


                            newRecord.ActivityName = act.ActivityName;
                            if (act.EndDate < newRecord.StatusChangeTime) { act.EndDate = newRecord.StatusChangeTime; }
                            Program.signInListService.UpsertSignInRecord(newRecord);
                            if (Program.AutomaticallySendToICA && Program.ThisMachineIsClient)
                            {
                                SignInRecord sir = newRecord.AsSignInRecord();
                                Program.networkService.SendNetworkObject(sir);
                            }
                        }
                    }
                }
            }

            updateStatusList();
        }
    

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            List<MemberStatus> statuses = new List<MemberStatus>();
            foreach (DataGridViewRow row in dgvMembersOnTask.SelectedRows)
            {
                statuses.Add((MemberStatus)row.DataBoundItem);
            }
            statuses = statuses.Where(o => !o.IsSignedOut).ToList();

            SignOutTheseMembers(statuses);
        }

        private void btnSignOutAll_Click(object sender, EventArgs e)
        {
            List<MemberStatus> statuses = new List<MemberStatus>();
            foreach (DataGridViewRow row in dgvMembersOnTask.Rows)
            {
                statuses.Add((MemberStatus)row.DataBoundItem);
            }
            statuses = statuses.Where(o => !o.IsSignedOut).ToList();
            SignOutTheseMembers(statuses);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            Activity act = new Activity();
            if (cboActivity.SelectedItem != null)
            {
                act = (Activity)cboActivity.SelectedItem;
            }



            saveFileDialog1.FileName = "SARSignIn-" + act.ActivityName + "-" + DateTime.Now.ToString("yyyy-MMM-dd-HH-mm") + ".csv";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                string exportPath = saveFileDialog1.FileName;

                string csv = exportSignInToCSV();

                try
                {
                    System.IO.File.WriteAllText(exportPath, csv);

                    DialogResult result = MessageBox.Show("The file was saved successfully. Would you like to open it now?", "Save successful!", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(exportPath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sorry, there was a problem writing to the file.  Please report this error: " + ex.ToString());
                }
            }
        }

        public string exportSignInToCSV(string delimiter = ",")
        {
            StringBuilder csv = new StringBuilder();
            //header row
            csv.Append("GROUP"); csv.Append(delimiter);
            csv.Append("NAME"); csv.Append(delimiter);
            csv.Append("SIGN IN TIME"); csv.Append(delimiter);
            csv.Append("SIGN OUT TIME"); csv.Append(delimiter);
            csv.Append("KMs"); csv.Append(delimiter);

            csv.Append(Environment.NewLine);

            List<MemberStatus> records = new List<MemberStatus>();


            foreach (DataGridViewRow row in dgvMembersOnTask.Rows)
            {
                MemberStatus rec = (MemberStatus)row.DataBoundItem;
                records.Add(rec);
            }


            foreach (MemberStatus record in records)
            {
                csv.Append(record.OrganizationName.EscapeQuotes());
                csv.Append(delimiter);

                csv.Append(record.MemberName.EscapeQuotes());
                csv.Append(delimiter);

                csv.Append(record.SignInTime.ToString("HH:mm"));
                csv.Append(delimiter);
                csv.Append(record.SignOutTime.ToString("HH:mm"));
                csv.Append(delimiter);
                csv.Append(record.KMs.ToString());
                csv.Append(Environment.NewLine);
            }
            return csv.ToString();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Activity act = new Activity();
            if (cboActivity.SelectedItem != null)
            {
                act = (Activity)cboActivity.SelectedItem;
            }

            using (SignInMemberForm signInMemberForm = new SignInMemberForm())
            {
                signInMemberForm.ActivityName = act.ActivityName;
                signInMemberForm.OpPeriod = (int)numOperationalPeriod.Value;
                DialogResult dr = signInMemberForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    if(signInMemberForm.Record.StatusChangeTime > act.EndDate)
                    {
                        act.EndDate = signInMemberForm.Record.StatusChangeTime;
                    }
                    else if (signInMemberForm.Record.StatusChangeTime < act.StartDate)
                    {
                        act.StartDate = signInMemberForm.Record.StatusChangeTime;
                    }

                    updateStatusList();
                    if (Program.AutomaticallySendToICA && Program.ThisMachineIsClient)
                    {
                        GeneralSignInRecord rec = signInMemberForm.Record;
                        SignInRecord sir = rec.AsSignInRecord();
                        Program.networkService.SendNetworkObject(sir);
                    }
                }
            }
        }

        private void btnBulkSignIn_Click(object sender, EventArgs e)
        {
            Activity act = new Activity();
            if (cboActivity.SelectedItem != null)
            {
                act = (Activity)cboActivity.SelectedItem;
            }

            using (SignInMembersBulkForm bulkForm = new SignInMembersBulkForm())
            {
                bulkForm.ActivityName = act.ActivityName;
                bulkForm.OpPeriod = OpPeriod;
                DialogResult result = bulkForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    updateStatusList();
                    if (Program.AutomaticallySendToICA && Program.ThisMachineIsClient)
                    {
                        foreach (GeneralSignInRecord rec in bulkForm.recordsCreated)
                        {
                            SignInRecord sir = rec.AsSignInRecord();
                            Program.networkService.SendNetworkObject(sir);
                        }
                    }
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Activity act = (Activity)cboActivity.SelectedItem;

            List<GeneralSignInRecord> records = Program.signInListService.GetSignInRecords(act);



            //split records into seperate activities



            SignInPDFResult result = ICS211CheckInListService.createSignInPDF(records, true, false, false);



            if (result.Errors.Any())
            {
                StringBuilder errors = new StringBuilder();

                foreach (string err in result.Errors)
                {
                    errors.Append(err); errors.Append(Environment.NewLine);
                }

                MessageBox.Show("Some errors occurred:" + Environment.NewLine + errors.ToString());
            }

        }
    }
}
