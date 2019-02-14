using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Inventory
    {
        public Guid InventoryId { get; set; }
        public string InventoryGroup { get; set; }
        public string InventoryName { get; set; }
        public string InventoryDescription { get; set; }
        public int InventoryType { get; set; }
        public string InventoryLocation { get; set; }
        public string InventorySupplier { get; set; }
        public DateTime? InventoryPurchaseDate { get; set; }
        public double? InventoryPurchaseAmount { get; set; }
        public DateTime? InventoryWarrantyTo { get; set; }
        public string InventorySerialNumber { get; set; }
        public string InventoryInvoiceNumber { get; set; }
        public string InventoryUserName { get; set; }
        public bool? InventoryAccessory { get; set; }
        public string InventoryParent { get; set; }
        public string InventorySecurityId { get; set; }
        public string InventoryOwner { get; set; }
        public string InventoryComment { get; set; }
        public string InventorySupportNumber { get; set; }
        public DateTime? InventorySupportFrom { get; set; }
        public DateTime? InventorySupportTo { get; set; }
        public double? InventorySupportCost { get; set; }
        public string InventorySupportExtent { get; set; }
        public DateTime? InventoryInvDate { get; set; }
        public string InventoryAccount { get; set; }
        public string InventoryStatus { get; set; }
        public string InventorySubgroup { get; set; }
        public bool? InventoryDebitExist { get; set; }
        public Guid? InventoryDebitId { get; set; }
        public string InventoryDebitOwner { get; set; }
        public string InventoryDebitAccount { get; set; }
        public string InventoryDebitReceiver { get; set; }
        public string InventoryDebitDepartment { get; set; }
        public string InventoryDebitActivity { get; set; }
        public bool? InventoryDebitActive { get; set; }
        public bool? InventorySynchronized { get; set; }
        public string InventorySyncSource { get; set; }
        public Guid? InventoryCustomerId { get; set; }
        public string InventoryExternalId { get; set; }
        public string InventoryManufacturer { get; set; }
        public string InventoryModel { get; set; }
        public Guid? InventoryVirtualHost { get; set; }
        public byte? InventoryVirtualType { get; set; }
        public string InventoryDebitObject { get; set; }
        public DateTime? InventoryLastLogon { get; set; }
        public DateTime? InventorySyncDate { get; set; }
        public string InventorySyncId { get; set; }
        public string InventoryUniqueId { get; set; }
        public double? InventoryLocationLatitude { get; set; }
        public double? InventoryLocationLongitude { get; set; }
        public double? InventoryLocationAltitude { get; set; }
        public DateTime? InventoryLocationTime { get; set; }
        public DateTime? InventoryWarrantyToReminderSent { get; set; }
        public DateTime? InventorySupportToReminderSent { get; set; }
        public string InventoryProductNumber { get; set; }
        public string InventoryDebitProject { get; set; }
        public string InventoryDistinguishedName { get; set; }
        public string InventorySupportType { get; set; }
        public DateTime? InventoryProductionDate { get; set; }
        public bool? InventoryImportMdm { get; set; }
    }
}
