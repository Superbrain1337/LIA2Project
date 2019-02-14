using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Ratings
    {
        public int RatingId { get; set; }
        public string RatingUser { get; set; }
        public byte RatingValue { get; set; }
        public DateTime RatingDate { get; set; }
        public string RatingObjectType { get; set; }
        public string RatingObjectId { get; set; }
    }
}
