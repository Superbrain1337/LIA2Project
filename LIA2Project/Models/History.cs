using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class History
    {
        public Guid HistoryId { get; set; }
        public Guid? HistoryInventoryId { get; set; }
        public byte? HistoryType { get; set; }
        public string HistorySubject { get; set; }
        public string HistoryText { get; set; }
        public DateTime? HistoryDate { get; set; }
        public byte? HistorySeverity { get; set; }
        public string HistoryUser { get; set; }
        public string HistorySource { get; set; }
        public string HistoryCategory { get; set; }
        public string HistoryGroup { get; set; }
    }
}
