using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class JobMembers
    {
        public Guid JobMemberId { get; set; }
        public string JobMemberDomain { get; set; }
        public string JobMemberName { get; set; }
        public byte? JobMemberStatus { get; set; }
        public DateTime? JobMemberDate { get; set; }
        public Guid? JobMemberJobId { get; set; }
        public int? JobMemberErrorId { get; set; }
        public string JobMemberStatusText { get; set; }
    }
}
