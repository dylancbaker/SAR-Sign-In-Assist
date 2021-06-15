using ICAClassLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICAClassLibrary.Models;
using SAR_Sign_In_Assist.Models;

namespace SAR_Sign_In_Assist.ViewModels
{
    public class SignInMemberViewModel : BaseViewModel
    {
        private TeamMember _currentMember = new TeamMember();
        private string _ActivityName;
        private DateTime _SignInTime;
        private DateTime _MustBeOutTime;
        private bool _UseMustBeOut;

        public TeamMember CurrentMember { get => _currentMember; set => _currentMember = value; }
        public string ActivityName { get => _ActivityName; set => _ActivityName = value; }
        public DateTime SignInTime { get => _SignInTime; set => _SignInTime = value; }
        public DateTime MustBeOutTime { get => _MustBeOutTime; set => _MustBeOutTime = value; }
        public bool UseMustBeOut { get => _UseMustBeOut; set => _UseMustBeOut = value; }

        public SignInMemberViewModel()
        {
            CurrentMember = new TeamMember();
        }


        public List<TeamMember> GetTeamMembers(Guid OrganizationID)
        {
            GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
            List<TeamMember> members = options.AllTeamMembers;
            if (OrganizationID != Guid.Empty)
            {
                members = members.Where(o => o.OrganizationID == OrganizationID).ToList();
            }
            return members;
        }
        public List<Organization> GetOrganizations()
        {
            return new Organization().getStaticOrganizationList();
        }
        public Guid SavedOrganizationID
        {
            get
            {
                GeneralOptions options = Program.generalOptionsService.GetGeneralOptions();
                if (options.OrganizationID != Guid.Empty && GetOrganizations().Any(o => o.OrganizationID == options.OrganizationID))
                {
                    return options.OrganizationID;
                }
                else { return Guid.Empty; }
            }
        }


        public bool SaveSignInRecord()
        {
            bool saveSuccessful = false;
            try
            {
                GeneralSignInRecord record = new GeneralSignInRecord();
                record.Active = true;
                record.ActivityName = ActivityName;
                record.MemberID = CurrentMember.PersonID;
                record.StatusChangeTime = SignInTime;

                if (UseMustBeOut && MustBeOutTime > DateTime.MinValue)
                {
                    //the dattimeout value will be in 1700s, need to move that to either today or tomorrow depending on the current time.
                    DateTime today = DateTime.Now;
                    DateTime outDate = new DateTime(today.Year, today.Month, today.Day, MustBeOutTime.Hour, MustBeOutTime.Minute, 0);
                    if (outDate <= today) { outDate = outDate.AddDays(1); }
                    record.TimeOutRequest = outDate;
                }


                record.teamMember = CurrentMember;
                record.IsSignIn = true;
                Program.signInListService.UpsertSignInRecord(record);
                saveSuccessful = true;
            }
            catch (Exception)
            {
                saveSuccessful = false;
            }
            return saveSuccessful;
        }
    }
}
