using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Updates
    {
        public long UpdateId { get; set; }
        public Guid UpdateInventoryId { get; set; }
        public string UpdateName { get; set; }
        public string UpdateLanguage { get; set; }
        public DateTime? UpdateInstallDate { get; set; }
        public string UpdateVersion { get; set; }
        public string UpdateUninstall { get; set; }
    }
}
