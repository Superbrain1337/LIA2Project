using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class VmGuests
    {
        public Guid VmGuestId { get; set; }
        public Guid VmGuestHostId { get; set; }
        public string VmGuestName { get; set; }
        public int? VmGuestPowerState { get; set; }
        public string VmGuestUuid { get; set; }
    }
}
