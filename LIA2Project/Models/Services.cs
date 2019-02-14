using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Services
    {
        public long ServiceId { get; set; }
        public Guid ServiceInventoryId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDisplayName { get; set; }
        public string ServiceStartMode { get; set; }
        public bool? ServiceStarted { get; set; }
        public string ServiceAccount { get; set; }
        public string ServiceVersion { get; set; }
    }
}
