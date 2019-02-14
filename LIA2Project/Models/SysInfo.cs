using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class SysInfo
    {
        public long SysInfoId { get; set; }
        public Guid SysInfoInventoryId { get; set; }
        public string SysInfoCategory { get; set; }
        public string SysInfoGroup { get; set; }
        public string SysInfoItem { get; set; }
        public string SysInfoProperty { get; set; }
        public string SysInfoValue { get; set; }
    }
}
