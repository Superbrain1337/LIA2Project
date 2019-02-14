using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Customers
    {
        public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerNumber { get; set; }
        public string CustomerDescription { get; set; }
        public Guid? CustomerParentId { get; set; }
        public short? CustomerType { get; set; }
        public bool? CustomerSynchronized { get; set; }
        public string CustomerSyncSource { get; set; }
        public DateTime? CustomerSyncDate { get; set; }
        public string CustomerSyncId { get; set; }
    }
}
