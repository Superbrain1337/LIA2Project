using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class AppInfo
    {
        public Guid AppInfoId { get; set; }
        public string AppInfoApplication { get; set; }
        public string AppInfoVersion { get; set; }
        public string AppInfoDescription { get; set; }
        public string AppInfoCompany { get; set; }
        public string AppInfoProduct { get; set; }
        public string AppInfoProductVersion { get; set; }
    }
}
