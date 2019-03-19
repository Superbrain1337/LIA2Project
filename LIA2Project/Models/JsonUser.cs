using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA2Project.Models
{
    public class JsonUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public string AccountName { get; set; }
        public string AccountGroup { get; set; }
        public bool AccountEnabled { get; set; }
        public string Group_Id { get; set; }
        public string VppClientUserIdStr { get; set; }
        public string LastInvitation { get; set; }
        public bool AccountUseDuoSTATION { get; set; }
        public string DuoSTATIONConnectionId { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string PERMISSION_GROUP_ID { get; set; }
        public string GROUP_NAME { get; set; }
        public string DEV_COUNT { get; set; }
        public string VPP_STATUS { get; set; }
        public string VPP_ORG_NAME { get; set; }
    }
}
