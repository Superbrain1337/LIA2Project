using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class CaseDevices
    {
        public int CaseDeviceId { get; set; }
        public int CaseId { get; set; }
        public Guid? CaseDeviceInventoryId { get; set; }
        public string CaseDeviceGroup { get; set; }
        public string CaseDeviceName { get; set; }
    }
}
