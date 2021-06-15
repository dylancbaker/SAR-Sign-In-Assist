﻿using SAR_Sign_In_Assist.Models;
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

namespace SAR_Sign_In_Assist
{
    public partial class MemberStatusByActivityForm : Form
    {
        public MemberStatusByActivityForm()
        {
            InitializeComponent();
            dgvMembersOnTask.AutoGenerateColumns = false;
        }

        private void MemberStatusByActivityForm_Load(object sender, EventArgs e)
        {
            cboActivity.DataSource = Program.signInListService.GetAllActivities().OrderByDescending(o=>o.EndDate).ToList();

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
                        }
                    }
                }

                updateStatusList();
            }
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
    }
}