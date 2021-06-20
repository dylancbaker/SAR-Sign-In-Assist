using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAR_Sign_In_Assist.Models;
using ICAClassLibrary.Models;
using System.IO;
using System.Xml.Serialization;

namespace SAR_Sign_In_Assist.Services
{
    public class SignInListService
    {
        private string _SaveFileName = "SARSignInAssistRecords.xml";
        private List<GeneralSignInRecord> _generalSignInRecords = new List<GeneralSignInRecord>();
        private bool _LoadFromFileSuccessful = false;


        public void UpsertSignInRecord(GeneralSignInRecord record)
        {
            if(_generalSignInRecords.Any(o=> o.SignInRecordID == record.SignInRecordID)) { _generalSignInRecords = _generalSignInRecords.Where(o => o.SignInRecordID != record.SignInRecordID).ToList(); }
            _generalSignInRecords.Add(record);
            _generalSignInRecords = _generalSignInRecords.OrderBy(o => o.StatusChangeTime).ToList();
            SaveSignInRecords();
        }

        public List<GeneralSignInRecord> GetSignInRecords(DateTime startDate, DateTime endDate, bool includeInactive = false, bool sortAscending = true, Guid OrganizationID = new Guid(), string ActivityName = null)
        {
            loadSignInRecordsByFilename();
            List<GeneralSignInRecord> records = _generalSignInRecords.Where(o => (o.Active || includeInactive) && o.StatusChangeTime >= startDate && o.StatusChangeTime <= endDate && (OrganizationID == Guid.Empty || o.teamMember.OrganizationID == OrganizationID)).ToList();
            if (!string.IsNullOrEmpty(ActivityName))
            {
                records = records.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(ActivityName, StringComparison.InvariantCultureIgnoreCase)).ToList();

            }
            if (sortAscending) { records = records.OrderBy(o => o.StatusChangeTime).ToList();            }
            else { records = records.OrderByDescending(o => o.StatusChangeTime).ToList(); }
            return records;
        }
        public List<GeneralSignInRecord> GetSignInRecords(Activity activity, bool includeInactive = false, bool sortAscending = true, Guid OrganizationID = new Guid())
        {
            loadSignInRecordsByFilename();
            List<GeneralSignInRecord> records = _generalSignInRecords.Where(o => (o.Active || includeInactive) && o.StatusChangeTime >= activity.StartDate && o.StatusChangeTime <= activity.EndDate && (OrganizationID == Guid.Empty || o.teamMember.OrganizationID == OrganizationID)).ToList();
            if (!string.IsNullOrEmpty(activity.ActivityName))
            {
                records = records.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(activity.ActivityName, StringComparison.InvariantCultureIgnoreCase)).ToList();

            }
            if (sortAscending) { records = records.OrderBy(o => o.StatusChangeTime).ToList(); }
            else { records = records.OrderByDescending(o => o.StatusChangeTime).ToList(); }
            return records;
        }

        public List<MemberStatus> GetMemberStatus(string ActivityName, DateTime startDate, DateTime endDate)
        {
            List<MemberStatus> memberStatuses = getAllMemberStatus(ActivityName, startDate, endDate, true);
            return memberStatuses;

        }

        public List<MemberStatus> GetMemberStatus(List<GeneralSignInRecord> fromTheseRecords)
        {
            List<MemberStatus> memberStatuses = getAllMemberStatus(fromTheseRecords, true);
            return memberStatuses;

        }

        private List<TeamMember> GetMembersByActivity(string ActivityName, DateTime StartDate, DateTime EndDate)
        {
            List<TeamMember> members = new List<TeamMember>();
            List<GeneralSignInRecord> records = GetSignInRecords(StartDate, EndDate, false, true, Guid.Empty, ActivityName);
            foreach(GeneralSignInRecord rec in records)
            {
                if(!members.Any(o=>o.PersonID == rec.MemberID))
                {
                    members.Add(rec.teamMember);
                }
            }

            return members;
        }

        private List<TeamMember> GetMembersFromRecords(List<GeneralSignInRecord> fromTheseRecords)
        {
            List<TeamMember> members = new List<TeamMember>();
           
            foreach (GeneralSignInRecord rec in fromTheseRecords)
            {
                if (!members.Any(o => o.PersonID == rec.MemberID))
                {
                    members.Add(rec.teamMember);
                }
            }

            return members;
        }

        public List<TeamMember> GetAllMembers()
        {

            List<GeneralSignInRecord> records = GetSignInRecords(DateTime.MinValue, DateTime.MaxValue);
            List<TeamMember> members = new List<TeamMember>();
            foreach (GeneralSignInRecord rec in records)
            {
                if (!members.Any(o => o.PersonID == rec.MemberID))
                {
                    members.Add(rec.teamMember);
                }
            }
            members = members.OrderBy(o => o.Name).ToList();
            return members;
        }

        public List<Activity> GetAllActivities(List<GeneralSignInRecord> fromTheseRecords = null)
        {
            List<Activity> activities = new List<Activity>();

            //List<GeneralSignInRecord> AllSignInRecords = GetSignInRecords(DateTime.MinValue, DateTime.MaxValue);
            if(fromTheseRecords == null || fromTheseRecords.Count == 0)
            {
                fromTheseRecords = GetSignInRecords(DateTime.MinValue, DateTime.MaxValue);
            }

            IEnumerable<string> AllActivities = fromTheseRecords.Select(o => o.ActivityName).Distinct();
            foreach (string s in AllActivities)
            {
                if (!string.IsNullOrEmpty(s))
                {
                    bool isContinuous = ActivityIsContinuous(s);
                    if (isContinuous)
                    {
                        Activity a = new Activity();
                        a.ActivityName = s;
                        a.StartDate = fromTheseRecords.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)).Min(o => o.StatusChangeTime);
                        a.EndDate = fromTheseRecords.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)).Max(o => o.StatusChangeTime);
                        activities.Add(a);
                    }
                    else
                    {
                        List<GeneralSignInRecord> recordsThisActivity = fromTheseRecords.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)).ToList();

                        for (int x = 1; x < recordsThisActivity.Count; x++)
                        {
                            TimeSpan gap = recordsThisActivity[x].StatusChangeTime - recordsThisActivity[x - 1].StatusChangeTime;
                            if (gap.TotalDays >= 3)
                            {
                                DateTime endOfLastIteration = DateTime.MinValue;
                                if (activities.Any(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)))
                                {
                                    endOfLastIteration = activities.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)).Max(o => o.EndDate);
                                }

                                Activity a = new Activity();
                                a.ActivityName = recordsThisActivity[x - 1].ActivityName;
                                a.StartDate = recordsThisActivity.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase) && o.StatusChangeTime > endOfLastIteration).Min(o => o.StatusChangeTime);
                                a.EndDate = recordsThisActivity[x - 1].StatusChangeTime;
                                activities.Add(a);
                            }

                        }
                        //because it is always looking back, the final actiivty is needed
                        DateTime LastDate = activities.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)).Max(o => o.EndDate);
                        if (LastDate < recordsThisActivity.Max(o => o.StatusChangeTime))
                        {
                            DateTime endOfLastIteration = DateTime.MinValue;
                            if (activities.Any(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)))
                            {
                                endOfLastIteration = activities.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase)).Max(o => o.EndDate);
                            }

                            Activity a = new Activity();
                            a.ActivityName = recordsThisActivity.Last().ActivityName;
                            a.StartDate = recordsThisActivity.Where(o => !string.IsNullOrEmpty(o.ActivityName) && o.ActivityName.Equals(s, StringComparison.InvariantCultureIgnoreCase) && o.StatusChangeTime > endOfLastIteration).Min(o => o.StatusChangeTime);
                            a.EndDate = recordsThisActivity.Last().StatusChangeTime;
                            activities.Add(a);
                        }


                    }
                }
            }

            return activities;
        }

        private bool ActivityIsContinuous (string ActivityName)
        {

            List<GeneralSignInRecord> AllSignInRecords = GetSignInRecords(DateTime.MinValue, DateTime.MaxValue, false, true, Guid.Empty, ActivityName);
            if(AllSignInRecords.Count <= 1) { return true; }
            
            TimeSpan minVsMax = AllSignInRecords.Max(o => o.StatusChangeTime) - AllSignInRecords.Min(o => o.StatusChangeTime);

            if (minVsMax.TotalDays < 3) { return true; }
            else
            {
                double largestGapInDays = -1;

                for (int x = 1; x<AllSignInRecords.Count; x++)
                {
                    TimeSpan gap = AllSignInRecords[x].StatusChangeTime - AllSignInRecords[x - 1].StatusChangeTime;
                    if(gap.TotalDays > largestGapInDays) { largestGapInDays = gap.TotalDays; }
                }

                if(largestGapInDays < 3) { return true; }

            }
            return false;
        }

        private List<MemberStatus> getAllMemberStatus(string ActivityName, DateTime startDate = new DateTime(), DateTime endDate = new DateTime(), bool getMultipleLinesAsNeeded = false)
        {
            List<MemberStatus> statuses = new List<MemberStatus>();
            List<TeamMember> members = GetMembersByActivity(ActivityName, startDate, endDate);
            List<GeneralSignInRecord> AllSignInRecords = GetSignInRecords(startDate, endDate, false, true, Guid.Empty, ActivityName);

            foreach (TeamMember member in members)
            {
                int signInCount = AllSignInRecords.Where(o => o.IsSignIn && o.teamMember.PersonID == member.PersonID).Count();
                if (signInCount == 1 || !getMultipleLinesAsNeeded)
                {

                    MemberStatus status = getMemberStatus(ActivityName,  member, startDate, endDate);
                    statuses.Add(status);
                }
                else
                {
                    foreach (SignInRecord record in AllSignInRecords.Where(o => o.IsSignIn && o.teamMember.PersonID == member.PersonID))
                    {

                        MemberStatus status = getMemberStatus(ActivityName, member, startDate, endDate, record);
                        statuses.Add(status);
                    }

                }
            }
            return statuses;
        }

        private MemberStatus getMemberStatus(string ActivityName, TeamMember member, DateTime start_date, DateTime end_date = new DateTime(), SignInRecord signIn = null)
        {
            List<GeneralSignInRecord> AllSignInRecords = GetSignInRecords(start_date, end_date, false, true, Guid.Empty, ActivityName);

            MemberStatus status = new MemberStatus();
            status.setTeamMember(member);
            if (signIn == null)
            {
                if (AllSignInRecords.Where(o =>  o.MemberID == member.PersonID && (o.StatusChangeTime <= end_date || end_date == DateTime.MinValue) && o.IsSignIn).Any())
                {
                    signIn = AllSignInRecords.Where(o =>  o.MemberID == member.PersonID && (o.StatusChangeTime <= end_date || end_date == DateTime.MinValue) && o.IsSignIn).OrderByDescending(o => o.StatusChangeTime).First();

                    status.SignInTime = signIn.StatusChangeTime;
                    if (signIn.TimeOutRequest > DateTime.MinValue) { status.TimeOutRequest = signIn.TimeOutRequest; }
                    status.KMs = signIn.KMs;
                }
                else { status.SignInTime = DateTime.MinValue; }
            }
            else { status.SignInTime = signIn.StatusChangeTime; status.KMs = signIn.KMs; }

            if (AllSignInRecords.Where(o =>  o.MemberID == member.PersonID && (o.StatusChangeTime <= end_date || end_date == DateTime.MinValue) && o.StatusChangeTime > status.SignInTime && !o.IsSignIn).Any())
            {
                SignInRecord signOut = AllSignInRecords.Where(o => o.MemberID == member.PersonID && (o.StatusChangeTime <= end_date || end_date == DateTime.MinValue) && o.StatusChangeTime > status.SignInTime && !o.IsSignIn).OrderBy(o => o.StatusChangeTime).First();
                status.SignOutTime = signOut.StatusChangeTime;
                if (status.KMs <= 0m)
                {
                    status.KMs = signOut.KMs;
                }
            }
            else { status.SignOutTime = DateTime.MaxValue; }



           
            DateTime today = DateTime.Now;
            if (status.SignOutTime < DateTime.MaxValue && status.SignOutTime > status.SignInTime && status.SignOutTime <= today)
            {
                Assignment signedout = new Assignment();
                signedout.AssignmentName = "Signed Out";
                signedout.currentStatus = new TeamStatus(38, "", false);
                status.currentAssignment = signedout;
            }
            else if (status.SignOutTime < DateTime.MaxValue && status.SignOutTime > status.SignInTime)
            {
                Assignment signedout = new Assignment();
                signedout.AssignmentName = "Travelling Home";
                signedout.currentStatus = new TeamStatus(39, "", false);
                status.currentAssignment = signedout;
            }

           
            return status;
        }




        private List<MemberStatus> getAllMemberStatus(List<GeneralSignInRecord> fromTheseRecords, bool getMultipleLinesAsNeeded = false)
        {
            List<MemberStatus> statuses = new List<MemberStatus>();
            List<TeamMember> members = GetMembersFromRecords(fromTheseRecords);
            

            foreach (TeamMember member in members)
            {
                int signInCount = fromTheseRecords.Where(o => o.IsSignIn && o.teamMember.PersonID == member.PersonID).Count();
                if (signInCount == 1 || !getMultipleLinesAsNeeded)
                {

                    MemberStatus status = getMemberStatus(fromTheseRecords, member);
                    statuses.Add(status);
                }
                else
                {
                    foreach (SignInRecord record in fromTheseRecords.Where(o => o.IsSignIn && o.teamMember.PersonID == member.PersonID))
                    {

                        MemberStatus status = getMemberStatus(fromTheseRecords, member,  record);
                        statuses.Add(status);
                    }

                }
            }
            return statuses;
        }

        private MemberStatus getMemberStatus(List<GeneralSignInRecord> fromTheseRecords, TeamMember member, SignInRecord signIn = null)
        {
            

            MemberStatus status = new MemberStatus();
            status.setTeamMember(member);
            if (signIn == null)
            {
                if (fromTheseRecords.Where(o => o.MemberID == member.PersonID &&  o.IsSignIn).Any())
                {
                    signIn = fromTheseRecords.Where(o => o.MemberID == member.PersonID && o.IsSignIn).OrderByDescending(o => o.StatusChangeTime).First();

                    status.SignInTime = signIn.StatusChangeTime;
                    if (signIn.TimeOutRequest > DateTime.MinValue) { status.TimeOutRequest = signIn.TimeOutRequest; }
                    status.KMs = signIn.KMs;
                }
                else { status.SignInTime = DateTime.MinValue; }
            }
            else { status.SignInTime = signIn.StatusChangeTime; status.KMs = signIn.KMs; }

            if (fromTheseRecords.Where(o => o.MemberID == member.PersonID && o.StatusChangeTime > status.SignInTime && !o.IsSignIn).Any())
            {
                SignInRecord signOut = fromTheseRecords.Where(o => o.MemberID == member.PersonID && o.StatusChangeTime > status.SignInTime && !o.IsSignIn).OrderBy(o => o.StatusChangeTime).First();
                status.SignOutTime = signOut.StatusChangeTime;
                if (status.KMs <= 0m)
                {
                    status.KMs = signOut.KMs;
                }
            }
            else { status.SignOutTime = DateTime.MaxValue; }




            DateTime today = DateTime.Now;
            if (status.SignOutTime < DateTime.MaxValue && status.SignOutTime > status.SignInTime && status.SignOutTime <= today)
            {
                Assignment signedout = new Assignment();
                signedout.AssignmentName = "Signed Out";
                signedout.currentStatus = new TeamStatus(38, "", false);
                status.currentAssignment = signedout;
            }
            else if (status.SignOutTime < DateTime.MaxValue && status.SignOutTime > status.SignInTime)
            {
                Assignment signedout = new Assignment();
                signedout.AssignmentName = "Travelling Home";
                signedout.currentStatus = new TeamStatus(39, "", false);
                status.currentAssignment = signedout;
            }


            return status;
        }






        private bool SaveSignInRecords()
        {
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SAR ICS Form Helper");
            Directory.CreateDirectory(path);
            path = Path.Combine(path, "SAR Sign-In Assist");
            Directory.CreateDirectory(path);
            bool saveSuccessful = false;


            using (StreamWriter myWriter = new StreamWriter(Path.Combine(path, _SaveFileName), false))
            {
                XmlSerializer mySerializer = null;
                try
                {
                    // Create an XmlSerializer for the 
                    // ApplicationSettings type.
                    mySerializer = new XmlSerializer(typeof(List<GeneralSignInRecord>));

                    // Serialize this instance of the ApplicationSettings 
                    // class to the config file.
                    mySerializer.Serialize(myWriter, _generalSignInRecords);
                    saveSuccessful = true;
                }
                catch (Exception)
                {
                    saveSuccessful = false;
                    //MessageBox.Show(ex.Message);
                }
                finally
                {
                    // If the FileStream is open, close it.
                    if (myWriter != null)
                    {
                        myWriter.Close();
                    }
                }
            }
            return saveSuccessful;
        }

        private void loadSignInRecordsByFilename(string fileName = null)
        {
            if (string.IsNullOrEmpty(fileName)) { fileName = _SaveFileName; }

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "SAR ICS Form Helper");
            path = Path.Combine(path, "SAR Sign-In Assist");


            XmlSerializer mySerializer = new XmlSerializer(typeof(List<GeneralSignInRecord>));

            try
            {
                System.IO.Directory.CreateDirectory(path);
                // Create an XmlSerializer for the ApplicationSettings type.

                FileInfo fi = new FileInfo(Path.Combine(path, fileName));
                // If the config file exists, open it.
                if (fi.Exists)
                {
                    using (FileStream myFileStream = fi.OpenRead())
                    {
                        // Create a new instance of the ApplicationSettings by
                        // deserializing the config file.
                        _generalSignInRecords = (List<GeneralSignInRecord>)mySerializer.Deserialize(myFileStream);
                        // Assign the property values to this instance of 
                        // the ApplicationSettings class.
                    }
                    _LoadFromFileSuccessful = true;

                }
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
                _LoadFromFileSuccessful = false;
                throw new Exception();
                
            }
        }
    }
}
