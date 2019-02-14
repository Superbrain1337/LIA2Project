using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class MeterApps
    {
        public Guid MeterAppId { get; set; }
        public string MeterAppGroup { get; set; }
        public string MeterAppName { get; set; }
        public string MeterAppDomain { get; set; }
        public string MeterAppAccount { get; set; }
        public string MeterAppApplication { get; set; }
        public string MeterAppVersion { get; set; }
        public DateTime? MeterAppLastUse { get; set; }
        public int? MeterAppCount { get; set; }
        public string MeterAppClient { get; set; }
        public DateTime? MeterAppFirstUse { get; set; }
        public int? MeterAppTotalUse { get; set; }
    }
}
