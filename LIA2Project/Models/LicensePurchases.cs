using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class LicensePurchases
    {
        public int LicensePurchaseId { get; set; }
        public Guid? LicensePurchaseLicenseId { get; set; }
        public int? LicensePurchaseType { get; set; }
        public DateTime? LicensePurchaseDate { get; set; }
        public int? LicensePurchaseCount { get; set; }
        public double? LicensePurchaseCost { get; set; }
        public string LicensePurchaseNotes { get; set; }
        public Guid? LicensePurchaseCustomerId { get; set; }
        public string LicensePurchaseSupplier { get; set; }
        public string LicensePurchaseInvoiceId { get; set; }
    }
}
