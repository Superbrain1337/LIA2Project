using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Licenses
    {
        public Guid LicenseId { get; set; }
        public string LicenseName { get; set; }
        public string LicenseComment { get; set; }
        public int? LicenseType { get; set; }
        public int? LicenseGroupId { get; set; }
    }
}
