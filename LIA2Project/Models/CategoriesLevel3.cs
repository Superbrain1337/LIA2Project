using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class CategoriesLevel3
    {
        public int SysId { get; set; }
        public int? Code { get; set; }
        public string Name { get; set; }
        public int? Category1 { get; set; }
        public int? Category2 { get; set; }
    }
}
