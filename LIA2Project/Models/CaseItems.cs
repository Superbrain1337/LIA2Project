using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class CaseItems
    {
        public int CaseItemId { get; set; }
        public int CaseId { get; set; }
        public string CaseItemNumber { get; set; }
        public string CaseItemName { get; set; }
        public string CaseItemDescription { get; set; }
        public double? CaseItemPrice { get; set; }
        public int? CaseItemCount { get; set; }
        public bool? CaseItemDebit { get; set; }
        public DateTime CaseItemDate { get; set; }
        public bool CaseItemNeedsApproval { get; set; }
    }
}
