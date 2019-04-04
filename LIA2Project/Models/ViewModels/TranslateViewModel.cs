using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIA2Project.Models.ViewModels
{
    public class TranslateViewModel
    {
        public string StartPageText { get; set; }
        public string Home { get; set; }
        public string Cases { get; set; }
        public string Devices { get; set; }
        public string Login { get; set; }
        public string Logout { get; set; }

        //CaseDevices
        public string CaseDeviceId { get; set; }
        public string CaseId { get; set; }
        public string CaseDeviceInventoryId { get; set; }
        public string CaseDeviceGroup { get; set; }
        public string CaseDeviceName { get; set; }

        //Cases
        public string CaseName { get; set; }
        public string CaseType { get; set; }
        public string CasePriority { get; set; }
        public string CaseNotes { get; set; }
        public string CaseCreatedDate { get; set; }
        public string CaseCreatedUser { get; set; }
        public string CaseChangedDate { get; set; }
        public string CaseChangedUser { get; set; }
        public string CaseStatus { get; set; }
        public string CaseStatusDate { get; set; }
        public string CaseStatusUser { get; set; }
        public string CaseLevel { get; set; }
        public string CaseLevelDate { get; set; }
        public string CaseLevelUser { get; set; }
        public string CaseCategory1 { get; set; }
        public string CaseCategory2 { get; set; }
        public string CaseCategory3 { get; set; }
        public string CaseGroupId { get; set; }
        public string CaseCustomerId { get; set; }
        public string CaseUniqueId { get; set; }
        public string CaseAssignedTo { get; set; }
        public string CaseAssignedUser { get; set; }
        public string CaseAssignedDate { get; set; }
        public string CaseDueDate { get; set; }
        public string CaseDueUser { get; set; }
        public string CaseCalcDate { get; set; }
        public string CaseCalcUser { get; set; }
        public string CaseNotify { get; set; }
        public string CaseRemind { get; set; }
        public string CaseRemindDate { get; set; }
        public string CaseKeywords { get; set; }
        public string CaseDescription { get; set; }
        public string CaseSolution { get; set; }
        public string CaseReportedBy { get; set; }
        public string CaseReportedDate { get; set; }
        public string CaseArchived { get; set; }
        public string CaseDebit { get; set; }
        public string CaseLangId { get; set; }
        public string CaseServiceId { get; set; }
        public string CaseServiceLevelUpdate { get; set; }
        public string CaseServiceLevelId { get; set; }
        public string CaseServiceLevelContractId { get; set; }
        public string CaseServiceLevelActionDate { get; set; }
        public string CaseServiceLevelEscalateDateLevel2 { get; set; }
        public string CaseServiceLevelEscalateDateLevel3 { get; set; }
        public string CaseServiceLevelNotifyDateHandler { get; set; }
        public string CaseServiceLevelNotifyDateManager { get; set; }
        public string CaseServiceLevelNotificationSentHandler { get; set; }
        public string CaseServiceLevelNotificationSentManager { get; set; }
        public string CaseCalcTime { get; set; }
        public string CaseVisibility { get; set; }
        public string CaseExternalNumber { get; set; }
        public string CaseRatingValue { get; set; }
        public string CaseRatingCount { get; set; }
        public string CaseIsTemplate { get; set; }

        //Inventory
        public string InventoryId { get; set; }
        public string InventoryGroup { get; set; }
        public string InventoryName { get; set; }
        public string InventoryDescription { get; set; }
        public string InventoryType { get; set; }
        public string InventoryLocation { get; set; }
        public string InventorySupplier { get; set; }
        public string InventoryPurchaseDate { get; set; }
        public string InventoryPurchaseAmount { get; set; }
        public string InventoryWarrantyTo { get; set; }
        public string InventorySerialNumber { get; set; }
        public string InventoryInvoiceNumber { get; set; }
        public string InventoryUserName { get; set; }
        public string InventoryAccessory { get; set; }
        public string InventoryParent { get; set; }
        public string InventorySecurityId { get; set; }
        public string InventoryOwner { get; set; }
        public string InventoryComment { get; set; }
        public string InventorySupportNumber { get; set; }
        public string InventorySupportFrom { get; set; }
        public string InventorySupportTo { get; set; }
        public string InventorySupportCost { get; set; }
        public string InventorySupportExtent { get; set; }
        public string InventoryInvDate { get; set; }
        public string InventoryAccount { get; set; }
        public string InventoryStatus { get; set; }
        public string InventorySubgroup { get; set; }
        public string InventoryDebitExist { get; set; }
        public string InventoryDebitId { get; set; }
        public string InventoryDebitOwner { get; set; }
        public string InventoryDebitAccount { get; set; }
        public string InventoryDebitReceiver { get; set; }
        public string InventoryDebitDepartment { get; set; }
        public string InventoryDebitActivity { get; set; }
        public string InventoryDebitActive { get; set; }
        public string InventorySynchronized { get; set; }
        public string InventorySyncSource { get; set; }
        public string InventoryCustomerId { get; set; }
        public string InventoryExternalId { get; set; }
        public string InventoryManufacturer { get; set; }
        public string InventoryModel { get; set; }
        public string InventoryVirtualHost { get; set; }
        public string InventoryVirtualType { get; set; }
        public string InventoryDebitObject { get; set; }
        public string InventoryLastLogon { get; set; }
        public string InventorySyncDate { get; set; }
        public string InventorySyncId { get; set; }
        public string InventoryUniqueId { get; set; }
        public string InventoryLocationLatitude { get; set; }
        public string InventoryLocationLongitude { get; set; }
        public string InventoryLocationAltitude { get; set; }
        public string InventoryLocationTime { get; set; }
        public string InventoryWarrantyToReminderSent { get; set; }
        public string InventorySupportToReminderSent { get; set; }
        public string InventoryProductNumber { get; set; }
        public string InventoryDebitProject { get; set; }
        public string InventoryDistinguishedName { get; set; }
        public string InventorySupportType { get; set; }
        public string InventoryProductionDate { get; set; }
        public string InventoryImportMdm { get; set; }

        //Users
        public string UserId { get; set; }
        public string UserGroupName { get; set; }
        public string UserLoginName { get; set; }
        public string UserFullName { get; set; }
        public string UserPosition { get; set; }
        public string UserTelephone { get; set; }
        public string UserMail { get; set; }
        public string UserDescription { get; set; }
        public string UserDepartment { get; set; }
        public string UserAccountEnabled { get; set; }
        public string UserSynchronized { get; set; }
        public string UserSyncSource { get; set; }
        public string UserAuthPassword { get; set; }
        public string UserAuthType { get; set; }
        public string UserHandler { get; set; }
        public string UserDecisionmaker { get; set; }
        public string UserAdministrator { get; set; }
        public string UserCustomerId { get; set; }
        public string UserDebitExist { get; set; }
        public string UserDebitId { get; set; }
        public string UserDebitOwner { get; set; }
        public string UserDebitAccount { get; set; }
        public string UserDebitReceiver { get; set; }
        public string UserDebitDepartment { get; set; }
        public string UserDebitActivity { get; set; }
        public string UserDebitActive { get; set; }
        public string UserLastLogon { get; set; }
        public string UserMobile { get; set; }
        public string UserDebitObject { get; set; }
        public string UserSyncDate { get; set; }
        public string UserSyncId { get; set; }
        public string UserDebitProject { get; set; }
        public string UserDistinguishedName { get; set; }
        public string UserExportMdm { get; set; }
        public string UserPersonalId { get; set; }
        public string UserCompany { get; set; }
    }
}
