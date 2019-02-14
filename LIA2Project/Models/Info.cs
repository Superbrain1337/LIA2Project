using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Info
    {
        public int InfoId { get; set; }
        public byte? InfoType { get; set; }
        public string InfoTitle { get; set; }
        public string InfoText { get; set; }
        public DateTime? InfoTime { get; set; }
        public byte? InfoVisibility { get; set; }
        public Guid InfoUniqueId { get; set; }
        public string InfoSolution { get; set; }
        public DateTime? InfoExpires { get; set; }
        public string InfoLangId { get; set; }
        public byte? InfoCategory1 { get; set; }
        public byte? InfoCategory2 { get; set; }
        public byte? InfoCategory3 { get; set; }
        public double? InfoRatingValue { get; set; }
        public int? InfoRatingCount { get; set; }
    }
}
