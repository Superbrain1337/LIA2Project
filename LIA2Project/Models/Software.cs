using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Software
    {
        public long SoftwareId { get; set; }
        public Guid SoftwareInventoryId { get; set; }
        public string SoftwareName { get; set; }
        public string SoftwareLanguage { get; set; }
        public DateTime? SoftwareInstallDate { get; set; }
        public string SoftwareVersion { get; set; }
        public string SoftwareUninstall { get; set; }
        public string SoftwareInstallType { get; set; }
        public bool? SoftwareIs64Bit { get; set; }
        public bool? SoftwareIsOfficeSuite { get; set; }
        public bool? SoftwareIsOfficeStandalone { get; set; }
        public int? SoftwareLicenseType { get; set; }
    }
}
