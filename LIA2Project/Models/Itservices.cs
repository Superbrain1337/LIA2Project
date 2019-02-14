using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Itservices
    {
        public Guid ItserviceId { get; set; }
        public string ItserviceName { get; set; }
        public string ItserviceDescription { get; set; }
        public string ItserviceManager { get; set; }
        public bool ItserviceOpenDay1 { get; set; }
        public DateTime? ItserviceOpenFromDay1 { get; set; }
        public DateTime? ItserviceOpenToDay1 { get; set; }
        public bool ItserviceOpenDay2 { get; set; }
        public DateTime? ItserviceOpenFromDay2 { get; set; }
        public DateTime? ItserviceOpenToDay2 { get; set; }
        public bool ItserviceOpenDay3 { get; set; }
        public DateTime? ItserviceOpenFromDay3 { get; set; }
        public DateTime? ItserviceOpenToDay3 { get; set; }
        public bool ItserviceOpenDay4 { get; set; }
        public DateTime? ItserviceOpenFromDay4 { get; set; }
        public DateTime? ItserviceOpenToDay4 { get; set; }
        public bool ItserviceOpenDay5 { get; set; }
        public DateTime? ItserviceOpenFromDay5 { get; set; }
        public DateTime? ItserviceOpenToDay5 { get; set; }
        public bool ItserviceOpenDay6 { get; set; }
        public DateTime? ItserviceOpenFromDay6 { get; set; }
        public DateTime? ItserviceOpenToDay6 { get; set; }
        public bool ItserviceOpenDay7 { get; set; }
        public DateTime? ItserviceOpenFromDay7 { get; set; }
        public DateTime? ItserviceOpenToDay7 { get; set; }
        public string ItserviceOpenTimeZoneCode { get; set; }
        public int ItserviceOpenTimeZoneBias { get; set; }
    }
}
