using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICAClassLibrary;
using ICAClassLibrary.Models;
using ProtoBuf;

namespace SAR_Sign_In_Assist.Models
{
    [ProtoContract]
    [Serializable]
    public class GeneralSignInRecord : SignInRecord
    {
        [ProtoMember(98)]
        private bool _Active;
        [ProtoMember(99)]
        private string _ActivityName;

        public GeneralSignInRecord()
        {
            SignInRecordID = Guid.NewGuid();
            teamMember = new TeamMember();
            Active = true;
        }

        public bool Active { get => _Active; set => _Active = value; }
        public string ActivityName { get => _ActivityName; set => _ActivityName = value; }
        public string MemberName { get => teamMember.Name; set { } }
        public string GroupName { get => teamMember.Group; set { } }
        public string MustBeOutTimeOrBlank
        {
            get
            {
                if (TimeOutRequest > DateTime.MinValue && TimeOutRequest < DateTime.MaxValue)
                {
                    return TimeOutRequest.ToString("HH:mm");
                }
                else { return null; }
            }
        }

    }
}
