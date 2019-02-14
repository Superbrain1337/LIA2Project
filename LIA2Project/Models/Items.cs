using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Items
    {
        public Guid ItemId { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public double ItemPrice { get; set; }
        public bool ItemWeb { get; set; }
        public bool ItemNeedsApproval { get; set; }
    }
}
