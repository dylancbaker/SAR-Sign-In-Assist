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
    public partial class SignInList : Form
    {
        public SignInList()
        {
            InitializeComponent();
        }

        private void SignInList_Load(object sender, EventArgs e)
        {
            List<Organization> allGroups = new Organization().getStaticOrganizationList();
            allGroups = allGroups.OrderBy(o => o.OrganizationName).ToList();
            Organization blankOrg = new Organization();
            blankOrg.OrganizationID = Guid.Empty;
            blankOrg.OrganizationName = "-All Groups-";
            allGroups.Insert(0, blankOrg);
            cboSARGroup.DataSource = allGroups;
            cboSARGroup.DropDownWidth = DropDownWidth(cboSARGroup);

            DateTime today = DateTime.Now;
            datFromDate.Value = today.AddDays(-1);
            datToDate.Value = today;

            rbFromLast24.Checked = true;
            rbToNow.Checked = true;

            togglePanel(pnlFilter, btnExpandFilterSort, pnlFilterMaxHeight, true);

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
            if (info.loadByTopic("MemberStatusQRScanner"))
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
    }
}
