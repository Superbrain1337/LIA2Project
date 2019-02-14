using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class System
    {
        public string LicenseKey { get; set; }
        public string LicensePin { get; set; }
        public string DatabaseVersion { get; set; }
        public string CaseIdprefix { get; set; }
        public DateTime? LastReport { get; set; }
    }
}
