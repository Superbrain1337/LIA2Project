using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class LicenseSupport
    {
        public int LicenseSupportId { get; set; }
        public DateTime? LicenseSupportStartDate { get; set; }
        public DateTime? LicenseSupportEndDate { get; set; }
        public double? LicenseSupportCost { get; set; }
        public byte? LicenseSupportPeriod { get; set; }
        public byte? LicenseSupportType { get; set; }
        public string LicenseSupportNotes { get; set; }
        public Guid? LicenseSupportLicenseId { get; set; }
        public Guid? LicenseSupportCustomerId { get; set; }
        public DateTime? LicenseSupportReminderSent { get; set; }
    }
}
