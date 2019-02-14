using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class CaseEvents
    {
        public int CaseEventId { get; set; }
        public int CaseId { get; set; }
        public string CaseEventText { get; set; }
        public double? CaseEventTime { get; set; }
        public DateTime? CaseEventCreatedDate { get; set; }
        public string CaseEventCreatedUser { get; set; }
        public byte? CaseEventStatus { get; set; }
        public bool? CaseEventWeb { get; set; }
        public short? CaseEventType { get; set; }
        public bool? CaseEventDebit { get; set; }
        public int? CaseEventObjectId { get; set; }
    }
}
