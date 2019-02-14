using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class ItserviceLevels
    {
        public Guid ItserviceLevelId { get; set; }
        public Guid ItserviceLevelServiceContractId { get; set; }
        public Guid ItserviceLevelServiceId { get; set; }
        public byte? ItserviceLevelCaseType { get; set; }
        public int? ItserviceLevelCaseGroupId { get; set; }
        public byte? ItserviceLevelCaseCategory1 { get; set; }
        public byte? ItserviceLevelCaseCategory2 { get; set; }
        public byte? ItserviceLevelCaseCategory3 { get; set; }
        public short? ItserviceLevelCasePriority { get; set; }
        public int? ItserviceLevelActionTime { get; set; }
        public int? ItserviceLevelEscalateTimeLevel2 { get; set; }
        public int? ItserviceLevelEscalateTimeLevel3 { get; set; }
        public int? ItserviceLevelNotifyHandlerTime { get; set; }
        public int? ItserviceLevelNotifyManagerTime { get; set; }
    }
}
