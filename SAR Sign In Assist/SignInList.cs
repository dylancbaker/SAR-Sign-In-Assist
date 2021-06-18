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
using SAR_Sign_In_Assist.Models;
using ICAClassLibrary.Utilities;
using SAR_Sign_In_Assist.Services;

using System.Runtime.InteropServices;
using System.IO;
using iTextSharp.text.pdf;

namespace SAR_Sign_In_Assist
{
    public partial class SignInList : Form
    {
        const int mSignInHotKeyID = 1;
        const int mSignOutHotKeyID = 2;
        const int mGenericSignInOutHotKeyID = 3;

        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);


        private bool ConnectedToICA = false;

        public SignInList()
        {
            InitializeComponent();
            //Modifier keys codes: Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            RegisterHotKey(this.Handle, mSignInHotKeyID, 4, (int)Keys.Oemtilde);
            RegisterHotKey(this.Handle, mSignOutHotKeyID, 4, (int)Keys.D6);
            RegisterHotKey(this.Handle, mGenericSignInOutHotKeyID, 0, (int)Keys.Oemtilde);

            lblCurrentActivity.KeyPress += new KeyPressEventHandler(keypressed);
        }


        

        private bool initialLoadInProgress = false;

        private void SignInList_Load(object sender, EventArgs e)
        {
            //KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);


            initialLoadInProgress = true;
            List<Organization> allGroups =  new Organization().getStaticOrganizationList(true);
            
            cboSARGroup.DataSource = allGroups;
            //cboSARGroup.DropDownWidth = DropDownWidth(cboSARGroup);

            DateTime today = DateTime.Now;
            datFromDate.Value = today.AddDays(-1);
            datToDate.Value = today;

            rbFromLast24.Checked = true;
            rbToNow.Checked = true;

            togglePanel(pnlFilter, btnExpandFilterSort, pnlFilterMaxHeight, true);

            updateSignInList();

            setNetworkStatusImage();
            initialLoadInProgress = false;
        }

      


        private void updateSignInList()
        {
            dgvSignInRecords.AutoGenerateColumns = false;
            DateTime endDate = DateTime.Now;
            DateTime startDate = endDate.AddHours(-24);

            if (rbFromDate.Checked) { startDate = datFromDate.Value; }
            if (rbToDate.Checked) { endDate = datToDate.Value; }
            Organization org = (Organization)cboSARGroup.SelectedItem;
            if (org != null)
            {
                dgvSignInRecords.DataSource = null;
                List<GeneralSignInRecord> records = Program.signInListService.GetSignInRecords(startDate, endDate, false, false, org.OrganizationID);
                dgvSignInRecords.DataSource = records;

                for(int x = 0; x<records.Count; x++)
                {
                    if (!records[x].IsSignIn)
                    {
                        foreach (DataGridViewCell cell in dgvSignInRecords.Rows[x].Cells) {
                            cell.Style.BackColor = Color.LightGray;
                          
                        }
                        dgvSignInRecords.Rows[x].Cells["colSignInTime"].Style.Font = new Font(dgvSignInRecords.Font, FontStyle.Italic);
                    }
                    if (!string.IsNullOrEmpty(records[x].MustBeOutTimeOrBlank))
                    {
                        dgvSignInRecords.Rows[x].Cells["colTimeOutRequest"].Style.ForeColor = Color.Red;
                    }
                }

            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit? If this is closed, any connected barcode scanners will no longer function.", "Are you sure?", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
        }

        private void aboutSARSignInAssistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 aboutbox = new AboutBox1())
            {
                aboutbox.ShowDialog();
            }
        }

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sarassist.ca/Support");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no need to save, all records are automatically saved.");
        }


        int DropDownWidth(ComboBox myCombo)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in myCombo.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), myCombo.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }

        private void datFromDate_ValueChanged(object sender, EventArgs e)
        {
            rbFromDate.Checked = true;
        }

        private void datToDate_ValueChanged(object sender, EventArgs e)
        {
            rbToDate.Checked = true;
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



        private int collapsedPanelHeight = 46;
        private int pnlFilterMaxHeight = 327;
        private void btnExpandFilterSort_Click(object sender, EventArgs e)
        {
            togglePanel(pnlFilter, btnExpandFilterSort, pnlFilterMaxHeight, false);
        }

        private void togglePanel(Panel panel, Button btnExpand, int fullHeight, bool forceCollapse = false)
        {
            if (panel.Height <= collapsedPanelHeight && !forceCollapse)
            {
                panel.Height = fullHeight;
                btnExpand.BackgroundImage = SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_222_chevron_up_3x;
            }
            else
            {
                panel.Height = collapsedPanelHeight;
                btnExpand.BackgroundImage = SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_221_chevron_down_3x;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            togglePanel(pnlFilter, btnExpandFilterSort, pnlFilterMaxHeight, false);
        }



        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (SignInMemberForm signInMemberForm = new SignInMemberForm())
            {
                signInMemberForm.ActivityName = txtCurrentActivity.Text;
                DialogResult dr = signInMemberForm.ShowDialog(this);
                if (dr == DialogResult.OK) { updateSignInList(); }
            }
        }

        void SignInMemberForm_Closed(object sender, FormClosedEventArgs e)
        {

            //setNumberOfTeamAssignments();


        }

        private void cboSARGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initialLoadInProgress) { updateSignInList(); }
        }

        private void rbToDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialLoadInProgress) { updateSignInList(); }
        }

        private void rbFromDate_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialLoadInProgress) { updateSignInList(); }
        }

        private void rbFromLast24_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialLoadInProgress) { updateSignInList(); }
        }

        private void rbToNow_CheckedChanged(object sender, EventArgs e)
        {
            if (!initialLoadInProgress) { updateSignInList(); }
        }

        private void dgvSignInRecords_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          

            /*
            if (dgvSignInRecords.Rows.Count > 0 && e.RowIndex <= dgvSignInRecords.Rows.Count && dgvSignInRecords.Rows[e.RowIndex] != null)
            {
                DataGridViewRow row = dgvSignInRecords.Rows[e.RowIndex];

                GeneralSignInRecord record = (GeneralSignInRecord)row.DataBoundItem;


                if (!record.IsSignIn)// Or your condition 
                {
                    foreach (DataGridViewCell c in row.Cells)
                    {
                        c.Style.BackColor = Color.LightGray;
                        c.Style.ForeColor = Color.DarkGray;
                    }

                } else
                {
                    foreach (DataGridViewCell c in row.Cells)
                    {
                        c.Style.BackColor = Color.White;
                        c.Style.ForeColor = Color.Black;
                    }

                }


                if (record.TimeOutRequest < DateTime.MaxValue && record.TimeOutRequest > DateTime.MinValue)
                {
                    row.Cells["colTimeOutRequest"].Style.ForeColor = Color.Red;

                }
                else
                {
                    row.Cells["colTimeOutRequest"].Style.ForeColor = Color.White;
                }

            }*/
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (dgvSignInRecords.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to hide these records? there's no easy way to ever see them again.", "Are you sure?", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvSignInRecords.SelectedRows)
                    {
                        GeneralSignInRecord record = (GeneralSignInRecord)row.DataBoundItem;
                        record.Active = false;
                        Program.signInListService.UpsertSignInRecord(record);
                    }
                    updateSignInList();
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "SARSignIn-" + DateTime.Now.ToString("yyyy-MMM-dd-HH-mm") + ".csv";
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

        private void exportSelectedRecordsToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "SARSignIn-" + DateTime.Now.ToString("yyyy-MMM-dd-HH-mm") + ".csv";
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

        public string exportSignInToCSV(string delimiter = ",", bool exportAllVisible = false)
        {
            StringBuilder csv = new StringBuilder();
            //header row
            csv.Append("ACTIVITY"); csv.Append(delimiter);
            csv.Append("GROUP"); csv.Append(delimiter);
            csv.Append("NAME"); csv.Append(delimiter);
            csv.Append("SIGN IN TIME"); csv.Append(delimiter);
            csv.Append("SIGN OUT TIME"); csv.Append(delimiter);
            csv.Append("KMs"); csv.Append(delimiter);

            csv.Append(Environment.NewLine);

            List<GeneralSignInRecord> records = new List<GeneralSignInRecord>();

            if (exportAllVisible)
            {

                DateTime endDate = DateTime.Now;
                DateTime startDate = endDate.AddHours(-24);

                if (rbFromDate.Checked) { startDate = datFromDate.Value; }
                if (rbToDate.Checked) { endDate = datToDate.Value; }
                Organization org = (Organization)cboSARGroup.SelectedItem;
                records = Program.signInListService.GetSignInRecords(startDate, endDate, false, false, org.OrganizationID);
            }
            else
            {
                foreach (DataGridViewRow row in dgvSignInRecords.SelectedRows)
                {
                    GeneralSignInRecord rec = (GeneralSignInRecord)row.DataBoundItem;
                    records.Add(rec);
                }
            }

            foreach (GeneralSignInRecord record in records)
            {
                csv.Append(record.ActivityName.EscapeQuotes());
                csv.Append(delimiter);
                csv.Append(record.GroupName.EscapeQuotes());
                csv.Append(delimiter);

                csv.Append(record.MemberName.EscapeQuotes());
                csv.Append(delimiter);

                if (record.IsSignIn) { csv.Append(record.SignInTime.ToString("HH:mm")); }
                csv.Append(delimiter);
                if (!record.IsSignIn) { csv.Append(record.SignOutTime.ToString("HH:mm")); }
                csv.Append(delimiter);
                csv.Append(record.KMs.ToString());
                csv.Append(Environment.NewLine);
            }
            return csv.ToString();
        }

        private void btnBulkSignIn_Click(object sender, EventArgs e)
        {
            using (SignInMembersBulkForm bulkForm = new SignInMembersBulkForm())
            {
                bulkForm.ActivityName = txtCurrentActivity.Text;
                DialogResult result = bulkForm.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    updateSignInList();
                }
            }
        }

        private void exportDisplayedRecordsToCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {

            saveFileDialog1.FileName = "SARSignIn-" + DateTime.Now.ToString("yyyy-MMM-dd-HH-mm") + ".csv";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && !string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                string exportPath = saveFileDialog1.FileName;

                string csv = exportSignInToCSV(",", true);

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


        private void toggleCheckbox(CheckBox cb)
        {
            if (cb.Checked) { cb.ImageIndex = 1; }
            else { cb.ImageIndex = 0; }
        }

        private void setNetworkStatusImage()
        {
            if (ConnectedToICA)
            {
                picICAConnection.Image = SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_74_wifi_2x;
            }
            else
            {
                picICAConnection.Image = SAR_Sign_In_Assist.Properties.Resources.glyphicons_basic_74_NoWifi1;
            }
        }

        private void chkRopeRescue_CheckedChanged(object sender, EventArgs e)
        {
            toggleCheckbox((CheckBox)sender);
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            List<GeneralSignInRecord> selectedRecords = new List<GeneralSignInRecord>();
            foreach (DataGridViewRow row in dgvSignInRecords.SelectedRows)
            {
                selectedRecords.Add((GeneralSignInRecord)row.DataBoundItem);
            }

            //only allow editing if they're all the same type of record (ie all sign in or all sign out)
            
            if (selectedRecords.Count > 0 && ( selectedRecords.Count == 1 || selectedRecords.Where(o => o.IsSignIn).Count() == selectedRecords.Count))
            {

                GeneralSignInRecord recordToEdit = new GeneralSignInRecord();
                if (selectedRecords.Count == 1)
                {
                    recordToEdit = selectedRecords[0];
                }
                else
                {
                    recordToEdit.StatusChangeTime = selectedRecords.Min(o => o.StatusChangeTime);
                    if (selectedRecords.Max(o => o.TimeOutRequest) == selectedRecords.Min(o => o.TimeOutRequest) && selectedRecords.Max(o => o.TimeOutRequest) > DateTime.MinValue)
                    {
                        recordToEdit.TimeOutRequest = selectedRecords.Max(o => o.TimeOutRequest);
                    }
                    recordToEdit.Active = true;
                    recordToEdit.IsSignIn = selectedRecords.First().IsSignIn;
                    recordToEdit.teamMember = new TeamMember();
                    recordToEdit.ActivityName = selectedRecords.GroupBy(n => n.ActivityName).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
                    recordToEdit.teamMember.Name = "-Several Members-";

                    if (selectedRecords.Max(o => o.KMs) == selectedRecords.Min(o => o.KMs))
                    {
                        recordToEdit.KMs = selectedRecords.Max(o => o.KMs);
                    }
                }

                using (EditMemberSignInTimes editSignIn = new EditMemberSignInTimes())
                {
                    editSignIn.currentSignInRecord = recordToEdit;
                    DialogResult dr = editSignIn.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        if (selectedRecords.Count == 1)
                        {
                            Program.signInListService.UpsertSignInRecord(editSignIn.currentSignInRecord);
                        }
                        else
                        {
                            foreach (GeneralSignInRecord record in selectedRecords)
                            {
                                record.StatusChangeTime = editSignIn.currentSignInRecord.StatusChangeTime;
                                record.KMs = editSignIn.currentSignInRecord.KMs;
                                record.TimeOutRequest = editSignIn.currentSignInRecord.TimeOutRequest;
                                Program.signInListService.UpsertSignInRecord(record);
                            }
                        }




                    }
                }

                updateSignInList();
            }
            else
            {
                MessageBox.Show("Sorry, you can only edit records of the same type (ie all sign in or all sign out).");
            }

        }


        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvSignInRecords.SelectedRows.Count == 1)
            {
                using (ViewSignInRecordDetailsForm viewRec = new ViewSignInRecordDetailsForm())
                {
                    GeneralSignInRecord rec = (GeneralSignInRecord)dgvSignInRecords.SelectedRows[0].DataBoundItem;
                    viewRec.member = rec.teamMember;
                    viewRec.ShowDialog();
                }
            }
        }

        private void dgvSignInRecords_SelectionChanged(object sender, EventArgs e)
        {
            btnView.Enabled = (dgvSignInRecords.SelectedRows.Count == 1);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            
            List<GeneralSignInRecord> selectedRecords = new List<GeneralSignInRecord>();
            foreach (DataGridViewRow row in dgvSignInRecords.SelectedRows)
            {
                selectedRecords.Add((GeneralSignInRecord)row.DataBoundItem);
            }
            selectedRecords = selectedRecords.Where(o => o.IsSignIn).ToList();

            if (selectedRecords.Any())
            {
                using (SignOutMemberForm signOutForm = new SignOutMemberForm())
                {
                    DialogResult dr = signOutForm.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        foreach (GeneralSignInRecord record in selectedRecords)
                        {
                            GeneralSignInRecord newRecord = new GeneralSignInRecord();
                            newRecord.teamMember = record.teamMember;
                            newRecord.StatusChangeTime = signOutForm.SignOutTime;
                            if (signOutForm.KMsEnabled)
                            {
                                newRecord.KMs = signOutForm.KMs;
                            }
                            newRecord.Active = true;
                            newRecord.ActivityName = record.ActivityName;

                            Program.signInListService.UpsertSignInRecord(newRecord);
                        }
                    }
                }

                updateSignInList();
            }

        }

        MemberStatusByActivityForm memberStatusByActivityForm = null;
        private void btnStatusByActivity_Click(object sender, EventArgs e)
        {
            if (memberStatusByActivityForm == null)
            {
                memberStatusByActivityForm = new MemberStatusByActivityForm();
                memberStatusByActivityForm.FormClosed += new FormClosedEventHandler(MemberStatusByActivityForm_Closed);
                memberStatusByActivityForm.Show();
            }
            memberStatusByActivityForm.BringToFront();
        }

        void MemberStatusByActivityForm_Closed(object sender, FormClosedEventArgs e)
        {

            //setNumberOfTeamAssignments();

            memberStatusByActivityForm = null;
        }

        private void dgvSignInRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                using (ViewSignInRecordDetailsForm viewRec = new ViewSignInRecordDetailsForm())
                {
                    GeneralSignInRecord rec = (GeneralSignInRecord)dgvSignInRecords.Rows[e.RowIndex].DataBoundItem;
                    viewRec.member = rec.teamMember;
                    viewRec.ShowDialog();
                }
            }
        }



        /****************
         ****************
         ****************
         * BARCODE STUFF
         **************** 
         ****************
         ****************/

        private bool listeningToSignInBarcode = false;
        private bool listeningToSignOutBarcode = false;
        private bool listeningToInOutBarcode = false;
        private bool listeningToBarcode
        {
            get
            {
                if (listeningToSignInBarcode || listeningToSignOutBarcode || listeningToInOutBarcode) { return true; }
                else { return false; }
            }
        }

        private bool ListenForQRScanner = true;

        private int signInEscapeChr = 126;
        private int signOutEscapeChr = 94;
        private int staticEscapeChr = 96;


        private DateTime startListeningToBarcode;
        StringBuilder barcodeInput = new StringBuilder();

        private GeneralSignInRecord getRecordFromBarcode(string qr)
        {
            GeneralSignInRecord record = new GeneralSignInRecord();
            record.Active = true;
            record.ActivityName = txtCurrentActivity.Text;
            if (listeningToSignInBarcode) { record.IsSignIn = true; }
            else { record.IsSignIn = false; }

            TeamMember member = new TeamMember().getMemberFromQR(qr);
            //can we match this to an existing member?
            List<TeamMember> allTeamMembers = Program.generalOptionsService.GetGeneralOptions().AllTeamMembers.Where(o => o.MemberActive).ToList();

            if (!string.IsNullOrEmpty(member.Email) && allTeamMembers.Where(o => !string.IsNullOrEmpty(o.Email) && o.Email.Equals(member.Email, StringComparison.InvariantCultureIgnoreCase)).Any())
            {
                record.teamMember = allTeamMembers.Where(o => !string.IsNullOrEmpty(o.Email) && o.Email.Equals(member.Email, StringComparison.InvariantCultureIgnoreCase)).First();
            }
            else if (!string.IsNullOrEmpty(member.Name) && allTeamMembers.Where(o => o.Name.Equals(member.Name, StringComparison.InvariantCultureIgnoreCase) && o.OrganizationID == member.OrganizationID).Any())
            {
                record.teamMember = allTeamMembers.Where(o => o.Name.Equals(member.Name, StringComparison.InvariantCultureIgnoreCase) && o.OrganizationID == member.OrganizationID).First();
            }
            else
            {
                record.teamMember = member;
            }

            string[] bits = qr.Split(';');
            if (bits.Length >= 13 && !string.IsNullOrEmpty(bits[12]))
            {
                DateTime today = DateTime.Now;
                int hour = 0;
                int min = 0;
                int sec = 0;
                _ = int.TryParse(bits[12].Substring(0, 2), out hour);
                _ = int.TryParse(bits[12].Substring(3, 2), out min);
                _ = int.TryParse(bits[12].Substring(6, 2), out sec);

                DateTime dt = new DateTime(today.Year, today.Month, today.Day, hour, min, sec);
                record.SignInTime = moveToNearestDateByTime(dt);
            }
            else { record.SignInTime = DateTime.Now; }

            if (bits.Length >= 14 && record.IsSignIn && !string.IsNullOrEmpty(bits[13]))
            {
                DateTime today = DateTime.Now;
                int hour = 0;
                int min = 0;
                int sec = 0;
                _ = int.TryParse(bits[13].Substring(0, 2), out hour);
                _ = int.TryParse(bits[13].Substring(3, 2), out min);
                _ = int.TryParse(bits[13].Substring(6, 2), out sec);


                record.TimeOutRequest = new DateTime(today.Year, today.Month, today.Day, hour, min, sec);
                if (record.TimeOutRequest < record.SignInTime) { record.TimeOutRequest = record.TimeOutRequest.AddDays(1); }

            }
            else if (bits.Length >= 14 && !record.IsSignIn)
            {
                int km = 0;
                if (int.TryParse(bits[13].ToString(Globals.cultureInfo), out km))
                {
                    record.KMs = km;
                }
            }
            return record;

        }

        private DateTime moveToNearestDateByTime(DateTime current)
        {
            DateTime today = DateTime.Now;
            TimeSpan c = today - current;
            TimeSpan y = today - current.AddDays(-1);
            if (Math.Abs(c.TotalSeconds) > Math.Abs(y.TotalSeconds))
            {
                return current.AddDays(-1);
            }
            else { return current; }

        }

      


        protected override void WndProc(ref Message m)
        {
            if (ListenForQRScanner)
            {
                //Handles the ~ key for sign in barcodes
                if (m.Msg == 0x0312 && m.WParam.ToInt32() == mSignInHotKeyID)
                {
                    //Do something here, the key pressed matches our listener
                    if (!listeningToSignInBarcode)
                    {
                        listeningToSignInBarcode = true;
                        startListeningToBarcode = DateTime.Now;
                        barcodeInput = new StringBuilder();
                        this.BringToFront();
                        lblCurrentActivity.Select();
                    }
                    else if (listeningToSignInBarcode)
                    {
                        if (barcodeInput.Length > 5)
                        {
                            GeneralSignInRecord record = getRecordFromBarcode(barcodeInput.ToString());
                            listeningToSignInBarcode = false;

                            Program.signInListService.UpsertSignInRecord(record);
                            updateSignInList();
                        }
                        listeningToSignInBarcode = false;
                    }

                }

                else if (m.Msg == 0x0312 && m.WParam.ToInt32() == mSignOutHotKeyID)
                {
                    if (!listeningToBarcode)
                    {
                        listeningToSignOutBarcode = true;
                        startListeningToBarcode = DateTime.Now;
                        barcodeInput = new StringBuilder();
                        lblCurrentActivity.Select();
                    }
                    else if (listeningToBarcode)
                    {
                        if (barcodeInput.Length > 5)
                        {
                            GeneralSignInRecord record = getRecordFromBarcode(barcodeInput.ToString());
                            listeningToSignOutBarcode = false;
                            Program.signInListService.UpsertSignInRecord(record);
                            updateSignInList();
                        }
                        listeningToSignInBarcode = false;
                    }
                }
                else if (m.Msg == 0x0312 && m.WParam.ToInt32() == mGenericSignInOutHotKeyID)
                {
                    if (!listeningToBarcode)
                    {
                        listeningToInOutBarcode = true;
                        startListeningToBarcode = DateTime.Now;
                        barcodeInput = new StringBuilder();
                        lblCurrentActivity.Select();
                    }
                    else if (listeningToBarcode)
                    {
                        if (barcodeInput.Length > 5)
                        {
                            GeneralSignInRecord record = getRecordFromBarcode(barcodeInput.ToString());
                            listeningToInOutBarcode = false;
                            DateTime startDate = record.StatusChangeTime.AddDays(-1);
                            List<GeneralSignInRecord> recentMemberRecords = Program.signInListService.GetSignInRecords(startDate, DateTime.Now, false, false);
                            if (recentMemberRecords.Any(o => o.MemberID == record.MemberID))
                            {
                                recentMemberRecords = recentMemberRecords.Where(o => o.MemberID == record.MemberID).ToList();
                                if (recentMemberRecords.First().IsSignIn)
                                {
                                    //the most recent record was a sign in, so in this case we will sign them out
                                    record.IsSignIn = false;


                                }
                                else
                                {
                                    //the most recent record was NOT a sign in, so lets assume this is
                                    record.IsSignIn = true;

                                }
                            }
                            else { record.IsSignIn = true; }

                            Program.signInListService.UpsertSignInRecord(record);
                            updateSignInList();
                        }
                        listeningToSignInBarcode = false;
                    }
                }


            }
            base.WndProc(ref m);
        }



        private void handleQRs(char key)
        {
            if (ListenForQRScanner)

            {
                /*
                if (key == signInEscapeChr && !listeningToBarcode)
                {
                    listeningToSignInBarcode = true;
                    startListeningToBarcode = DateTime.Now;
                    barcodeInput = new StringBuilder();
                    lblCurrentActivity.Select();
                }

                else if (key == signOutEscapeChr && !listeningToBarcode)
                {
                    listeningToSignOutBarcode = true;
                    startListeningToBarcode = DateTime.Now;
                    barcodeInput = new StringBuilder();
                    lblCurrentActivity.Select();
                }

                else if (key == staticEscapeChr && !listeningToBarcode)
                {
                    //this is a generic barcode starting with a ` character. if the member is not signed in, it will sign them in for now. if they are signed in, it will sign them out for now.
                    listeningToInOutBarcode = true;
                    startListeningToBarcode = DateTime.Now;
                    barcodeInput = new StringBuilder();
                    lblCurrentActivity.Select();
                }


                else if (key == signInEscapeChr && listeningToSignInBarcode)
                {

                    GeneralSignInRecord record = getRecordFromBarcode(barcodeInput.ToString());
                    listeningToSignInBarcode = false;

                    Program.signInListService.UpsertSignInRecord(record);
                    updateSignInList();
                }



                else if (key == signOutEscapeChr && listeningToSignOutBarcode)
                {

                    GeneralSignInRecord record = getRecordFromBarcode(barcodeInput.ToString());
                    listeningToSignOutBarcode = false;
                    Program.signInListService.UpsertSignInRecord(record);
                    updateSignInList();
                }

                else if (key == staticEscapeChr && listeningToInOutBarcode)
                {
                    //this is a generic barcode starting with a ` character. if the member is not signed in, it will sign them in for now. if they are signed in, it will sign them out for now.

                    GeneralSignInRecord record = getRecordFromBarcode(barcodeInput.ToString());
                    listeningToInOutBarcode = false;
                    DateTime startDate = record.StatusChangeTime.AddDays(-1);
                    List<GeneralSignInRecord> recentMemberRecords = Program.signInListService.GetSignInRecords(startDate, DateTime.Now, false, false);
                    if (recentMemberRecords.Any(o => o.MemberID == record.MemberID))
                    {
                        recentMemberRecords = recentMemberRecords.Where(o => o.MemberID == record.MemberID).ToList();
                        if (recentMemberRecords.First().IsSignIn)
                        {
                            //the most recent record was a sign in, so in this case we will sign them out
                            record.IsSignIn = false;


                        }
                        else
                        {
                            //the most recent record was NOT a sign in, so lets assume this is
                            record.IsSignIn = true;

                        }
                    }
                    else { record.IsSignIn = true; }

                    Program.signInListService.UpsertSignInRecord(record);
                    updateSignInList();

                }
                else*/
                if (listeningToBarcode)
                {
                    DateTime today = DateTime.Now;
                    TimeSpan ts = today - startListeningToBarcode;
                    if (ts.Seconds > 2)
                    {
                        listeningToSignInBarcode = false;
                        listeningToSignOutBarcode = false;
                    }
                    else
                    {
                        barcodeInput.Append(key.ToString());
                        //e.Handled = true;

                    }
                }
            }
        }

        private void SignInList_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void SignInList_FormClosed(object sender, FormClosedEventArgs e)
        {
            //KListener.Dispose();
        }

        private void keypressed(Object o, KeyPressEventArgs e)
        {
            // The keypressed method uses the KeyChar property to check 
            // whether the ENTER key is pressed. 

            handleQRs(e.KeyChar);

            // If the ENTER key is pressed, the Handled property is set to true, 
            // to indicate the event is handled.
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }


        StringBuilder thing = new StringBuilder();
        private void lblCurrentActivity_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
           
           
        }

        private void splitContainer2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void printSelectedRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GeneralSignInRecord> selectedRecords = new List<GeneralSignInRecord>();
            foreach (DataGridViewRow row in dgvSignInRecords.SelectedRows)
            {
                selectedRecords.Add((GeneralSignInRecord)row.DataBoundItem);
            }

            PrintTheseRecords(selectedRecords);
        }

        private void printDisplayedRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<GeneralSignInRecord> selectedRecords = new List<GeneralSignInRecord>();
            foreach (DataGridViewRow row in dgvSignInRecords.Rows)
            {
                selectedRecords.Add((GeneralSignInRecord)row.DataBoundItem);
            }

            PrintTheseRecords(selectedRecords);
        }

        private void generalOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditOptionsForm editOptions = new EditOptionsForm())
            {
                DialogResult dr = editOptions.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    ListenForQRScanner = Program.generalOptionsService.GetGeneralOptions().DefaultListenForQR;
                }
            }
        }

        EditSavedTeamMembers editSavedTeamMembers = null;
        private void editSARTeamMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(editSavedTeamMembers == null)
            {
                editSavedTeamMembers = new EditSavedTeamMembers();
                editSavedTeamMembers.FormClosed += new FormClosedEventHandler(EditSavedTEamMembersForm_Closed);
                editSavedTeamMembers.Show();
            }
            editSavedTeamMembers.BringToFront();
        }

        void EditSavedTEamMembersForm_Closed(object sender, FormClosedEventArgs e)
        {
            editSavedTeamMembers = null;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<GeneralSignInRecord> selectedRecords = new List<GeneralSignInRecord>();
            foreach (DataGridViewRow row in dgvSignInRecords.SelectedRows)
            {
                selectedRecords.Add((GeneralSignInRecord)row.DataBoundItem);
            }

            PrintTheseRecords(selectedRecords);
           

            

        }

        private void PrintTheseRecords(List<GeneralSignInRecord> selectedRecords)
        {
            //split records into seperate activities
            List<Activity> activities = Program.signInListService.GetAllActivities(selectedRecords);
            List<SignInPDFResult> results = new List<SignInPDFResult>();

            foreach (Activity activity in activities)
            {
                List<GeneralSignInRecord> records = selectedRecords.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(activity.ActivityName, StringComparison.InvariantCultureIgnoreCase) && o.StatusChangeTime >= activity.StartDate && o.StatusChangeTime <= activity.EndDate).ToList();
                SignInPDFResult result = ICS211CheckInListService.createSignInPDF(records, true, false, false);
                results.Add(result);
            }
            if (selectedRecords.Any(o => string.IsNullOrEmpty(o.ActivityName)))
            {
                List<GeneralSignInRecord> records = selectedRecords.Where(o => string.IsNullOrEmpty(o.ActivityName)).ToList();
                SignInPDFResult result = ICS211CheckInListService.createSignInPDF(records, true, false, false);
                results.Add(result);
            }


            if (results.Where(o => o.Errors.Any()).Any())
            {
                StringBuilder errors = new StringBuilder();
                foreach (SignInPDFResult result in results)
                {
                    foreach (string err in result.Errors)
                    {
                        errors.Append(err); errors.Append(Environment.NewLine);
                    }
                }
                MessageBox.Show("Some errors occurred:" + Environment.NewLine + errors.ToString());
            }
        }




        

    }
}
