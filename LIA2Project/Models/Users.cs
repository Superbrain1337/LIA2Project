using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Users
    {
        public Guid UserId { get; set; }
        public string UserGroupName { get; set; }
        public string UserLoginName { get; set; }
        public string UserFullName { get; set; }
        public string UserPosition { get; set; }
        public string UserTelephone { get; set; }
        public string UserMail { get; set; }
        public string UserDescription { get; set; }
        public string UserDepartment { get; set; }
        public bool? UserAccountEnabled { get; set; }
        public bool? UserSynchronized { get; set; }
        public string UserSyncSource { get; set; }
        public string UserAuthPassword { get; set; }
        public string UserAuthType { get; set; }
        public bool? UserHandler { get; set; }
        public bool? UserDecisionmaker { get; set; }
        public bool? UserAdministrator { get; set; }
        public Guid? UserCustomerId { get; set; }
        public bool? UserDebitExist { get; set; }
        public Guid? UserDebitId { get; set; }
        public string UserDebitOwner { get; set; }
        public string UserDebitAccount { get; set; }
        public string UserDebitReceiver { get; set; }
        public string UserDebitDepartment { get; set; }
        public string UserDebitActivity { get; set; }
        public bool? UserDebitActive { get; set; }
        public DateTime? UserLastLogon { get; set; }
        public string UserMobile { get; set; }
        public string UserDebitObject { get; set; }
        public DateTime? UserSyncDate { get; set; }
        public string UserSyncId { get; set; }
        public string UserDebitProject { get; set; }
        public string UserDistinguishedName { get; set; }
        public bool? UserExportMdm { get; set; }
        public string UserPersonalId { get; set; }
        public string UserCompany { get; set; }
    }
}
