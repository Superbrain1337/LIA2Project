using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class VmGuestAdapters
    {
        public Guid VmGuestAdapterId { get; set; }
        public Guid? VmGuestAdapterGuestId { get; set; }
        public string VmGuestAdapterMacaddress { get; set; }
    }
}
