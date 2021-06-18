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
using ICAClassLibrary.Models;

namespace SAR_Sign_In_Assist
{
    public partial class EditMemberForm : Form
    {
        TeamMember _memberToEdit = null;
        public TeamMember memberToEdit { get => _memberToEdit; set => _memberToEdit = value; }

        public EditMemberForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            memberToEdit = editTeamMemberForm1.CurrentMember;
            Program.generalOptionsService.UpserOptionValue(memberToEdit, "TeamMember");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            editTeamMemberForm1.CurrentMember = memberToEdit;
        }
    }
}
