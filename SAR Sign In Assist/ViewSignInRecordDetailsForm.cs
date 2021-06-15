using ICAClassLibrary.Models;
using SAR_Sign_In_Assist.Properties;
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
    public partial class ViewSignInRecordDetailsForm : Form
    {
        private TeamMember _member;
        public TeamMember member { get => _member; set => _member = value; }


        public ViewSignInRecordDetailsForm()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ViewSignInRecordDetailsForm_Load(object sender, EventArgs e)
        {
            displayMember();
        }

        private void displayMember()
        {
            this.Text = member.Name;
            lblName.Text = member.Name;
            lblGroup.Text = member.Group;
            lblReference.Text = member.Reference;
            lblCallsign.Text = member.Callsign;

            lblAddress.Text = member.Address;
            lblPhone.Text = member.Phone;
            lblEmail.Text = member.Email;

            lblNOKName.Text = member.NOKName;
            lblNOKPhone.Text = member.NOKPhone;
            lblNOKRelationship.Text = member.NOKRelation;

            lblSpecialSkills.Text = member.SpecialSkills;
            
            if (member.RopeRescue) { lblRR.Img = Resources.check_box_checked; } else { lblRR.Img = Resources.check_box_unchecked; }
            if (member.Tracker) { lblTK.Img = Resources.check_box_checked; } else { lblTK.Img = Resources.check_box_unchecked; }
            if (member.FirstAid) { lblFirstAid.Img = Resources.check_box_checked; } else { lblFirstAid.Img = Resources.check_box_unchecked; }
            if (member.Swiftwater) { lblSW.Img = Resources.check_box_checked; } else { lblSW.Img = Resources.check_box_unchecked; }
            if (member.MountainRescue) { lblMR.Img = Resources.check_box_checked; } else { lblMR.Img = Resources.check_box_unchecked; }
            if (member.GSAR) { lblGSAR.Img = Resources.check_box_checked; } else { lblGSAR.Img = Resources.check_box_unchecked; }
            if (member.GSTL) { lblGSTL.Img = Resources.check_box_checked; } else { lblGSTL.Img = Resources.check_box_unchecked; }
            if (member.SARM) { lblSARM.Img = Resources.check_box_checked; } else { lblSARM.Img = Resources.check_box_unchecked; }
           
          
        }
    }
}
