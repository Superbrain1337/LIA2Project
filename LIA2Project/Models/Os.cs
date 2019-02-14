using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Os
    {
        public long Osid { get; set; }
        public Guid OsinventoryId { get; set; }
        public string Osname { get; set; }
        public string Ostype { get; set; }
        public string Osbuild { get; set; }
        public string OsservicePack { get; set; }
        public string Oslanguage { get; set; }
        public DateTime? OsinstallDate { get; set; }
    }
}
