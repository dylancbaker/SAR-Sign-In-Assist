using ICAClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAR_Sign_In_Assist.Models
{
    public class GroupSignInRecord
    {
        public string GroupName { get; set; }
        public List<MemberStatus> MemberStatuses { get; set; }
        public int totalPages
        {
            get
            {
                int totalPages = Convert.ToInt32(Math.Floor(Convert.ToDecimal(MemberStatuses.Count) / 6m));
                //if (OpAssignments.Count() % 7 > 0) { totalPages += 1; }
                if (totalPages == 0) { totalPages = 1; }
                return totalPages;
            }
        }

        public GroupSignInRecord() { MemberStatuses = new List<MemberStatus>(); }
        public GroupSignInRecord(string name) { GroupName = name; MemberStatuses = new List<MemberStatus>(); }
    }
}
