using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class AppLinks
    {
        public Guid AppLinkId { get; set; }
        public string AppLinkLicense { get; set; }
        public string AppLinkApplication { get; set; }
        public string AppLinkVersion { get; set; }
    }
}
