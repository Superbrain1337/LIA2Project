using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class MgmtLog
    {
        public long MgmtLogId { get; set; }
        public DateTime? MgmtLogTime { get; set; }
        public string MgmtLogHost { get; set; }
        public string MgmtLogText { get; set; }
        public int? MgmtLogSeverity { get; set; }
        public string MgmtLogSource { get; set; }
        public long? MgmtLogEventId { get; set; }
        public string MgmtLogUser { get; set; }
        public string MgmtLogCategory { get; set; }
        public string MgmtLogOrigin { get; set; }
        public string MgmtLogGroup { get; set; }
        public byte? MgmtLogStatus { get; set; }
    }
}
