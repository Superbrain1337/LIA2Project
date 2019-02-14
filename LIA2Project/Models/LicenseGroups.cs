using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class LicenseGroups
    {
        public int LicenseGroupId { get; set; }
        public int? LicenseGroupParentId { get; set; }
        public string LicenseGroupName { get; set; }
        public string LicenseGroupNotes { get; set; }
        public Guid LicenseGroupUniqueId { get; set; }
    }
}
