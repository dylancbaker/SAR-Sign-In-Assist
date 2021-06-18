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
    public partial class EditOptionsForm : Form
    {
        public EditOptionsForm()
        {
            InitializeComponent();
        }

        private void btnDefaultQRHelp_Click(object sender, EventArgs e)
        {
            HelpInfo info = new HelpInfo();
            if (info.loadByTopic("OptionsDefaultQR"))
            {
                using (BasicHelpInfo help = new BasicHelpInfo())
                {
                    help.Title = info.Title;
                    help.Body = info.Body;
                    help.ShowDialog();
                }
            }
        }

        private void btnHelpDefaultPort_Click(object sender, EventArgs e)
        {
            HelpInfo info = new HelpInfo();
            if (info.loadByTopic("OptionsDefaultPortNumber"))
            {
                using (BasicHelpInfo help = new BasicHelpInfo())
                {
                    help.Title = info.Title;
                    help.Body = info.Body;
                    help.ShowDialog();
                }
            }
        }

        private void btnHelpHomeGroupName_Click(object sender, EventArgs e)
        {
            HelpInfo info = new HelpInfo();
            if (info.loadByTopic("OptionsPrimarySARGroup"))
            {
                using (BasicHelpInfo help = new BasicHelpInfo())
                {
                    help.Title = info.Title;
                    help.Body = info.Body;
                    help.ShowDialog();
                }
            }
        }

        private void EditOptionsForm_Load(object sender, EventArgs e)
        {
            GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
            chkDefaultQRScanner.Checked = options.DefaultListenForQR;
            numDefaultPortNumber.Value = options.DefaultPortNumber;
            cboOrganizationName.DataSource = new Organization().getStaticOrganizationList();
            cboOrganizationName.SelectedValue = options.OrganizationID;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
            options.DefaultListenForQR = chkDefaultQRScanner.Checked;
            options.DefaultPortNumber = Convert.ToInt32(numDefaultPortNumber.Value);
            options.OrganizationID = new Guid(cboOrganizationName.SelectedValue.ToString());
            Program.generalOptionsService.SaveGeneralOptions(options);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
