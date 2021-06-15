using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAR_Sign_In_Assist.Models
{
   public  class Activity
    {
        private Guid _ActivityID;
        private string _ActivityName;
        private DateTime _StartDate;
        private DateTime _EndDate;

        public Guid ActivityID { get => _ActivityID; set => _ActivityID = value; }
        public string ActivityName { get => _ActivityName; set => _ActivityName = value; }
        public DateTime StartDate { get => _StartDate; set => _StartDate = value; }
        public DateTime EndDate { get => _EndDate; set => _EndDate = value; }
        public string NameWithDates
        {
            get
            {
                TimeSpan ts = EndDate - StartDate;
                if(ts.TotalDays <= 1)
                {
                    return ActivityName + " (" + StartDate.ToString("yyyy-MMM-dd") + ")";
                }

                return ActivityName + " ("+ StartDate.ToString("yyyy-MMM-dd") + " to " + EndDate.ToString("yyyy-MMM-dd") + ")";
            }
        }

        public Activity() { ActivityID = Guid.NewGuid(); }
    }
}
