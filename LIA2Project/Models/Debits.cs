using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Debits
    {
        public Guid DebitId { get; set; }
        public string DebitCode { get; set; }
        public string DebitName { get; set; }
        public string DebitComment { get; set; }
        public double? DebitAmount { get; set; }
        public byte? DebitType { get; set; }
    }
}
