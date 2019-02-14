using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Cases
    {
        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public byte? CaseType { get; set; }
        public short? CasePriority { get; set; }
        public string CaseNotes { get; set; }
        public DateTime? CaseCreatedDate { get; set; }
        public string CaseCreatedUser { get; set; }
        public DateTime? CaseChangedDate { get; set; }
        public string CaseChangedUser { get; set; }
        public byte? CaseStatus { get; set; }
        public DateTime? CaseStatusDate { get; set; }
        public string CaseStatusUser { get; set; }
        public byte? CaseLevel { get; set; }
        public DateTime? CaseLevelDate { get; set; }
        public string CaseLevelUser { get; set; }
        public byte? CaseCategory1 { get; set; }
        public byte? CaseCategory2 { get; set; }
        public byte? CaseCategory3 { get; set; }
        public int? CaseGroupId { get; set; }
        public Guid? CaseCustomerId { get; set; }
        public Guid? CaseUniqueId { get; set; }
        public string CaseAssignedTo { get; set; }
        public string CaseAssignedUser { get; set; }
        public DateTime? CaseAssignedDate { get; set; }
        public DateTime? CaseDueDate { get; set; }
        public string CaseDueUser { get; set; }
        public DateTime? CaseCalcDate { get; set; }
        public string CaseCalcUser { get; set; }
        public bool? CaseNotify { get; set; }
        public bool? CaseRemind { get; set; }
        public DateTime? CaseRemindDate { get; set; }
        public string CaseKeywords { get; set; }
        public string CaseDescription { get; set; }
        public string CaseSolution { get; set; }
        public string CaseReportedBy { get; set; }
        public DateTime? CaseReportedDate { get; set; }
        public bool CaseArchived { get; set; }
        public bool? CaseDebit { get; set; }
        public string CaseLangId { get; set; }
        public Guid? CaseServiceId { get; set; }
        public bool CaseServiceLevelUpdate { get; set; }
        public Guid? CaseServiceLevelId { get; set; }
        public Guid? CaseServiceLevelContractId { get; set; }
        public DateTime? CaseServiceLevelActionDate { get; set; }
        public DateTime? CaseServiceLevelEscalateDateLevel2 { get; set; }
        public DateTime? CaseServiceLevelEscalateDateLevel3 { get; set; }
        public DateTime? CaseServiceLevelNotifyDateHandler { get; set; }
        public DateTime? CaseServiceLevelNotifyDateManager { get; set; }
        public DateTime? CaseServiceLevelNotificationSentHandler { get; set; }
        public DateTime? CaseServiceLevelNotificationSentManager { get; set; }
        public double? CaseCalcTime { get; set; }
        public byte? CaseVisibility { get; set; }
        public string CaseExternalNumber { get; set; }
        public double? CaseRatingValue { get; set; }
        public int? CaseRatingCount { get; set; }
        public bool CaseIsTemplate { get; set; }
    }
}
