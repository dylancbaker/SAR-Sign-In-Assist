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
    public partial class BasicHelpInfo : Form
    {
        public string Title { get { return lblTitle.Text; } set { lblTitle.Text = value; this.Text = value; } }
        public string Body { get { return txtHelpText.Text; } set { txtHelpText.Text = value; } }
        public string MoreInfoButtonText { get { return btnMoreInfo.Text; } set { btnMoreInfo.Text = value; btnMoreInfo.Visible = !string.IsNullOrEmpty(value); } }
        private string _moreInfoURL;
        public string MoreInfoURL { get => _moreInfoURL; set => _moreInfoURL = value; }

        public BasicHelpInfo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BasicHelpInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnMoreInfo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MoreInfoURL))
            {
                System.Diagnostics.Process.Start(MoreInfoURL);
            }
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoreInfo_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MoreInfoURL))
            {
                System.Diagnostics.Process.Start(MoreInfoURL);
            }
        }
    }
}
