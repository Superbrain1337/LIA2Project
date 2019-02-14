using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Actions
    {
        public int ActionId { get; set; }
        public string ActionType { get; set; }
        public DateTime? ActionTime { get; set; }
        public string ActionData { get; set; }
        public string ActionSource { get; set; }
        public short? ActionStatus { get; set; }
        public short? ActionRetryCount { get; set; }
        public short? ActionRetryMax { get; set; }
        public DateTime? ActionLastTry { get; set; }
    }
}
