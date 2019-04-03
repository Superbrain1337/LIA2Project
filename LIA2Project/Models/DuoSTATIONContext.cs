using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.IdentityModel.Protocols;

namespace LIA2Project.Models
{
    public partial class DuoSTATIONContext : DbContext
    {
        public DuoSTATIONContext()
        {
        }

        public DuoSTATIONContext(DbContextOptions<DuoSTATIONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<AHistory> AHistory { get; set; }
        public virtual DbSet<AInventory> AInventory { get; set; }
        public virtual DbSet<AppInfo> AppInfo { get; set; }
        public virtual DbSet<AppLinks> AppLinks { get; set; }
        public virtual DbSet<CaseContacts> CaseContacts { get; set; }
        public virtual DbSet<CaseDevices> CaseDevices { get; set; }
        public virtual DbSet<CaseEvents> CaseEvents { get; set; }
        public virtual DbSet<CaseGroups> CaseGroups { get; set; }
        public virtual DbSet<CaseItems> CaseItems { get; set; }
        public virtual DbSet<CaseMail> CaseMail { get; set; }
        public virtual DbSet<CaseReferences> CaseReferences { get; set; }
        public virtual DbSet<Cases> Cases { get; set; }
        public virtual DbSet<CategoriesLevel1> CategoriesLevel1 { get; set; }
        public virtual DbSet<CategoriesLevel2> CategoriesLevel2 { get; set; }
        public virtual DbSet<CategoriesLevel3> CategoriesLevel3 { get; set; }
        public virtual DbSet<ChangeLog> ChangeLog { get; set; }
        public virtual DbSet<Connections> Connections { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Debits> Debits { get; set; }
        public virtual DbSet<DocLinks> DocLinks { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Info> Info { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<ItserviceContracts> ItserviceContracts { get; set; }
        public virtual DbSet<ItserviceLevels> ItserviceLevels { get; set; }
        public virtual DbSet<Itservices> Itservices { get; set; }
        public virtual DbSet<JobMembers> JobMembers { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<LicenseGroups> LicenseGroups { get; set; }
        public virtual DbSet<LicensePurchases> LicensePurchases { get; set; }
        public virtual DbSet<Licenses> Licenses { get; set; }
        public virtual DbSet<LicenseSupport> LicenseSupport { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<MailAttachments> MailAttachments { get; set; }
        public virtual DbSet<MailRecipients> MailRecipients { get; set; }
        public virtual DbSet<MeterApps> MeterApps { get; set; }
        public virtual DbSet<MgmtLog> MgmtLog { get; set; }
        public virtual DbSet<ObjectLinks> ObjectLinks { get; set; }
        public virtual DbSet<Os> Os { get; set; }
        public virtual DbSet<Ratings> Ratings { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<Software> Software { get; set; }
        public virtual DbSet<SysInfo> SysInfo { get; set; }
        public virtual DbSet<System> System { get; set; }
        public virtual DbSet<Updates> Updates { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VmGuestAdapters> VmGuestAdapters { get; set; }
        public virtual DbSet<VmGuests> VmGuests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=SAMUEL-W10;Initial Catalog=DuoSTATION;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actions>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionData).HasColumnType("text");

                entity.Property(e => e.ActionLastTry).HasColumnType("datetime");

                entity.Property(e => e.ActionSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.ActionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("A_History");

                entity.HasIndex(e => e.HistoryDate);

                entity.Property(e => e.HistoryId)
                    .HasColumnName("HistoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HistoryCategory)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryInventoryId).HasColumnName("HistoryInventoryID");

                entity.Property(e => e.HistorySource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HistorySubject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryText).HasColumnType("text");

                entity.Property(e => e.HistoryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AInventory>(entity =>
            {
                entity.HasKey(e => e.InventoryId);

                entity.ToTable("A_Inventory");

                entity.HasIndex(e => e.InventoryName);

                entity.Property(e => e.InventoryId)
                    .HasColumnName("InventoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InventoryAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryComment).HasColumnType("text");

                entity.Property(e => e.InventoryCustomerId).HasColumnName("InventoryCustomerID");

                entity.Property(e => e.InventoryDebitAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitId).HasColumnName("InventoryDebitID");

                entity.Property(e => e.InventoryDebitObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitReceiver)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDistinguishedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryExternalId)
                    .HasColumnName("InventoryExternalID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryImportMdm).HasColumnName("InventoryImportMDM");

                entity.Property(e => e.InventoryInvDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InventoryInvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryLastLogon).HasColumnType("datetime");

                entity.Property(e => e.InventoryLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryLocationTime).HasColumnType("datetime");

                entity.Property(e => e.InventoryManufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryParent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryProductionDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryPurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.InventorySecurityId)
                    .HasColumnName("InventorySecurityID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySubgroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupplier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupportExtent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupportFrom).HasColumnType("datetime");

                entity.Property(e => e.InventorySupportNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupportTo).HasColumnType("datetime");

                entity.Property(e => e.InventorySupportToReminderSent).HasColumnType("datetime");

                entity.Property(e => e.InventorySupportType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySyncDate).HasColumnType("datetime");

                entity.Property(e => e.InventorySyncId)
                    .HasColumnName("InventorySyncID")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySyncSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryUniqueId)
                    .HasColumnName("InventoryUniqueID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryWarrantyTo).HasColumnType("datetime");

                entity.Property(e => e.InventoryWarrantyToReminderSent).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppInfo>(entity =>
            {
                entity.Property(e => e.AppInfoId)
                    .HasColumnName("AppInfoID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppInfoApplication)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppInfoCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppInfoDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppInfoProduct)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppInfoProductVersion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AppInfoVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppLinks>(entity =>
            {
                entity.HasKey(e => e.AppLinkId);

                entity.Property(e => e.AppLinkId)
                    .HasColumnName("AppLinkID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AppLinkApplication)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppLinkLicense)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppLinkVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaseContacts>(entity =>
            {
                entity.HasKey(e => e.CaseContactId);

                entity.HasIndex(e => e.CaseContactName);

                entity.Property(e => e.CaseContactId).HasColumnName("CaseContactID");

                entity.Property(e => e.CaseContactGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseContactName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseId).HasColumnName("CaseID");
            });

            modelBuilder.Entity<CaseDevices>(entity =>
            {
                entity.HasKey(e => e.CaseDeviceId);

                entity.HasIndex(e => e.CaseDeviceName);

                entity.Property(e => e.CaseDeviceId).HasColumnName("CaseDeviceID");

                entity.Property(e => e.CaseDeviceGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseDeviceInventoryId).HasColumnName("CaseDeviceInventoryID");

                entity.Property(e => e.CaseDeviceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseId).HasColumnName("CaseID");
            });

            modelBuilder.Entity<CaseEvents>(entity =>
            {
                entity.HasKey(e => e.CaseEventId);

                entity.HasIndex(e => e.CaseEventCreatedDate);

                entity.HasIndex(e => e.CaseId);

                entity.Property(e => e.CaseEventId).HasColumnName("CaseEventID");

                entity.Property(e => e.CaseEventCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CaseEventCreatedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseEventDebit).HasDefaultValueSql("((1))");

                entity.Property(e => e.CaseEventObjectId).HasColumnName("CaseEventObjectID");

                entity.Property(e => e.CaseEventStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.CaseEventText).HasColumnType("text");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");
            });

            modelBuilder.Entity<CaseGroups>(entity =>
            {
                entity.HasKey(e => e.CaseGroupId);

                entity.Property(e => e.CaseGroupId).HasColumnName("CaseGroupID");

                entity.Property(e => e.CaseGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseGroupNotes).HasColumnType("text");
            });

            modelBuilder.Entity<CaseItems>(entity =>
            {
                entity.HasKey(e => e.CaseItemId);

                entity.Property(e => e.CaseItemId).HasColumnName("CaseItemID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CaseItemCount).HasDefaultValueSql("((1))");

                entity.Property(e => e.CaseItemDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.CaseItemDebit).HasDefaultValueSql("((1))");

                entity.Property(e => e.CaseItemDescription).HasColumnType("text");

                entity.Property(e => e.CaseItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseItemNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaseReferences>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CaseReferenceId).HasColumnName("CaseReferenceID");
            });

            modelBuilder.Entity<Cases>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.Property(e => e.CaseId).HasColumnName("CaseID");

                entity.Property(e => e.CaseAssignedDate).HasColumnType("datetime");

                entity.Property(e => e.CaseAssignedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseAssignedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseCalcDate).HasColumnType("datetime");

                entity.Property(e => e.CaseCalcUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CaseChangedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CaseCreatedUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseCustomerId).HasColumnName("CaseCustomerID");

                entity.Property(e => e.CaseDebit).HasDefaultValueSql("((1))");

                entity.Property(e => e.CaseDescription).HasColumnType("text");

                entity.Property(e => e.CaseDueDate).HasColumnType("datetime");

                entity.Property(e => e.CaseDueUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseExternalNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CaseGroupId).HasColumnName("CaseGroupID");

                entity.Property(e => e.CaseKeywords)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CaseLangId)
                    .HasColumnName("CaseLangID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CaseLevelDate).HasColumnType("datetime");

                entity.Property(e => e.CaseLevelUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseNotes).HasColumnType("text");

                entity.Property(e => e.CasePriority).HasDefaultValueSql("((0))");

                entity.Property(e => e.CaseRemindDate).HasColumnType("datetime");

                entity.Property(e => e.CaseReportedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseReportedDate).HasColumnType("datetime");

                entity.Property(e => e.CaseServiceId).HasColumnName("CaseServiceID");

                entity.Property(e => e.CaseServiceLevelActionDate).HasColumnType("datetime");

                entity.Property(e => e.CaseServiceLevelContractId).HasColumnName("CaseServiceLevelContractID");

                entity.Property(e => e.CaseServiceLevelEscalateDateLevel2).HasColumnType("datetime");

                entity.Property(e => e.CaseServiceLevelEscalateDateLevel3).HasColumnType("datetime");

                entity.Property(e => e.CaseServiceLevelId).HasColumnName("CaseServiceLevelID");

                entity.Property(e => e.CaseServiceLevelNotificationSentHandler).HasColumnType("datetime");

                entity.Property(e => e.CaseServiceLevelNotificationSentManager).HasColumnType("datetime");

                entity.Property(e => e.CaseServiceLevelNotifyDateHandler).HasColumnType("datetime");

                entity.Property(e => e.CaseServiceLevelNotifyDateManager).HasColumnType("datetime");

                entity.Property(e => e.CaseSolution).HasColumnType("text");

                entity.Property(e => e.CaseStatusDate).HasColumnType("datetime");

                entity.Property(e => e.CaseStatusUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseUniqueId)
                    .HasColumnName("CaseUniqueID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CaseVisibility).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CategoriesLevel1>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.Property(e => e.SysId).HasColumnName("SysID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoriesLevel2>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.Property(e => e.SysId).HasColumnName("SysID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoriesLevel3>(entity =>
            {
                entity.HasKey(e => e.SysId);

                entity.Property(e => e.SysId).HasColumnName("SysID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChangeLog>(entity =>
            {
                entity.Property(e => e.ChangeLogId).HasColumnName("ChangeLogID");

                entity.Property(e => e.ChangeLogDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ChangeLogObjectId).HasColumnName("ChangeLogObjectID");

                entity.Property(e => e.ChangeLogObjectName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeLogObjectNewValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeLogObjectOldValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeLogObjectProperty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeLogObjectType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeLogObjectUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Connections>(entity =>
            {
                entity.HasKey(e => e.ConnId);

                entity.Property(e => e.ConnId).HasColumnName("ConnID");

                entity.Property(e => e.ConnDeviceId).HasColumnName("ConnDeviceID");

                entity.Property(e => e.ConnIfName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConnMacaddress)
                    .HasColumnName("ConnMACAddress")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ConnRemoteIfName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConnRemoteIp)
                    .HasColumnName("ConnRemoteIP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ConnRemoteMacaddress)
                    .HasColumnName("ConnRemoteMACAddress")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ConnRemoteStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.ConnVlan)
                    .HasColumnName("ConnVLAN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CustomerDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerParentId).HasColumnName("CustomerParentID");

                entity.Property(e => e.CustomerSyncDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerSyncId)
                    .HasColumnName("CustomerSyncID")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerSyncSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Debits>(entity =>
            {
                entity.HasKey(e => e.DebitId);

                entity.Property(e => e.DebitId)
                    .HasColumnName("DebitID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DebitCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DebitComment).HasColumnType("text");

                entity.Property(e => e.DebitName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocLinks>(entity =>
            {
                entity.HasKey(e => e.DocLinkId);

                entity.Property(e => e.DocLinkId)
                    .HasColumnName("DocLinkID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocLinkDocumentId).HasColumnName("DocLinkDocumentID");

                entity.Property(e => e.DocLinkLinkId).HasColumnName("DocLinkLinkID");

                entity.Property(e => e.DocLinkLinkType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Documents>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.Property(e => e.DocumentId)
                    .HasColumnName("DocumentID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath).HasColumnType("text");

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasIndex(e => e.HistoryDate);

                entity.Property(e => e.HistoryId)
                    .HasColumnName("HistoryID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.HistoryCategory)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDate).HasColumnType("datetime");

                entity.Property(e => e.HistoryGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryInventoryId).HasColumnName("HistoryInventoryID");

                entity.Property(e => e.HistorySeverity).HasDefaultValueSql("((0))");

                entity.Property(e => e.HistorySource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HistorySubject)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryText).HasColumnType("text");

                entity.Property(e => e.HistoryUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Info>(entity =>
            {
                entity.Property(e => e.InfoId).HasColumnName("InfoID");

                entity.Property(e => e.InfoExpires).HasColumnType("smalldatetime");

                entity.Property(e => e.InfoLangId)
                    .HasColumnName("InfoLangID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.InfoSolution).HasColumnType("text");

                entity.Property(e => e.InfoText).HasColumnType("text");

                entity.Property(e => e.InfoTime).HasColumnType("smalldatetime");

                entity.Property(e => e.InfoTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InfoUniqueId)
                    .HasColumnName("InfoUniqueID")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasIndex(e => e.InventoryName);

                entity.Property(e => e.InventoryId)
                    .HasColumnName("InventoryID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.InventoryAccessory).HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryComment).HasColumnType("text");

                entity.Property(e => e.InventoryCustomerId).HasColumnName("InventoryCustomerID");

                entity.Property(e => e.InventoryDebitAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryDebitActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitExist).HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryDebitId).HasColumnName("InventoryDebitID");

                entity.Property(e => e.InventoryDebitObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDebitReceiver)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryDistinguishedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryExternalId)
                    .HasColumnName("InventoryExternalID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryImportMdm).HasColumnName("InventoryImportMDM");

                entity.Property(e => e.InventoryInvDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InventoryInvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryLastLogon).HasColumnType("datetime");

                entity.Property(e => e.InventoryLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryLocationTime).HasColumnType("datetime");

                entity.Property(e => e.InventoryManufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryParent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryProductNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryProductionDate).HasColumnType("datetime");

                entity.Property(e => e.InventoryPurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.InventorySecurityId)
                    .HasColumnName("InventorySecurityID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySubgroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupplier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupportExtent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupportFrom).HasColumnType("datetime");

                entity.Property(e => e.InventorySupportNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySupportTo).HasColumnType("datetime");

                entity.Property(e => e.InventorySupportToReminderSent).HasColumnType("datetime");

                entity.Property(e => e.InventorySupportType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySyncDate).HasColumnType("datetime");

                entity.Property(e => e.InventorySyncId)
                    .HasColumnName("InventorySyncID")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySyncSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventorySynchronized).HasDefaultValueSql("((0))");

                entity.Property(e => e.InventoryUniqueId)
                    .HasColumnName("InventoryUniqueID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryWarrantyTo).HasColumnType("datetime");

                entity.Property(e => e.InventoryWarrantyToReminderSent).HasColumnType("datetime");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.HasIndex(e => e.ItemNumber)
                    .HasName("IX_Items")
                    .IsUnique();

                entity.Property(e => e.ItemId)
                    .HasColumnName("ItemID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItemDescription).HasColumnType("text");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemNumber)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItserviceContracts>(entity =>
            {
                entity.HasKey(e => e.ItserviceContractId);

                entity.ToTable("ITServiceContracts");

                entity.HasIndex(e => new { e.ItserviceContractName, e.ItserviceContractCustomerId })
                    .HasName("IX_ITServiceContracts")
                    .IsUnique();

                entity.Property(e => e.ItserviceContractId)
                    .HasColumnName("ITServiceContractID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItserviceContractCustomerContact)
                    .HasColumnName("ITServiceContractCustomerContact")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItserviceContractCustomerContactReminderSent)
                    .HasColumnName("ITServiceContractCustomerContactReminderSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceContractCustomerContactSendMail).HasColumnName("ITServiceContractCustomerContactSendMail");

                entity.Property(e => e.ItserviceContractCustomerId).HasColumnName("ITServiceContractCustomerID");

                entity.Property(e => e.ItserviceContractDescription)
                    .HasColumnName("ITServiceContractDescription")
                    .HasColumnType("text");

                entity.Property(e => e.ItserviceContractManager)
                    .HasColumnName("ITServiceContractManager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItserviceContractManagerReminderSent)
                    .HasColumnName("ITServiceContractManagerReminderSent")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceContractManagerSendMail).HasColumnName("ITServiceContractManagerSendMail");

                entity.Property(e => e.ItserviceContractName)
                    .IsRequired()
                    .HasColumnName("ITServiceContractName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItserviceContractUseForSubCustomers).HasColumnName("ITServiceContractUseForSubCustomers");

                entity.Property(e => e.ItserviceContractValidFrom)
                    .HasColumnName("ITServiceContractValidFrom")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceContractValidTo)
                    .HasColumnName("ITServiceContractValidTo")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ItserviceLevels>(entity =>
            {
                entity.HasKey(e => e.ItserviceLevelId);

                entity.ToTable("ITServiceLevels");

                entity.HasIndex(e => new { e.ItserviceLevelServiceContractId, e.ItserviceLevelServiceId, e.ItserviceLevelCaseType, e.ItserviceLevelCaseGroupId, e.ItserviceLevelCaseCategory1, e.ItserviceLevelCaseCategory2, e.ItserviceLevelCaseCategory3, e.ItserviceLevelCasePriority })
                    .HasName("IX_ITServiceLevels")
                    .IsUnique();

                entity.Property(e => e.ItserviceLevelId)
                    .HasColumnName("ITServiceLevelID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItserviceLevelActionTime).HasColumnName("ITServiceLevelActionTime");

                entity.Property(e => e.ItserviceLevelCaseCategory1).HasColumnName("ITServiceLevelCaseCategory1");

                entity.Property(e => e.ItserviceLevelCaseCategory2).HasColumnName("ITServiceLevelCaseCategory2");

                entity.Property(e => e.ItserviceLevelCaseCategory3).HasColumnName("ITServiceLevelCaseCategory3");

                entity.Property(e => e.ItserviceLevelCaseGroupId).HasColumnName("ITServiceLevelCaseGroupID");

                entity.Property(e => e.ItserviceLevelCasePriority).HasColumnName("ITServiceLevelCasePriority");

                entity.Property(e => e.ItserviceLevelCaseType).HasColumnName("ITServiceLevelCaseType");

                entity.Property(e => e.ItserviceLevelEscalateTimeLevel2).HasColumnName("ITServiceLevelEscalateTimeLevel2");

                entity.Property(e => e.ItserviceLevelEscalateTimeLevel3).HasColumnName("ITServiceLevelEscalateTimeLevel3");

                entity.Property(e => e.ItserviceLevelNotifyHandlerTime).HasColumnName("ITServiceLevelNotifyHandlerTime");

                entity.Property(e => e.ItserviceLevelNotifyManagerTime).HasColumnName("ITServiceLevelNotifyManagerTime");

                entity.Property(e => e.ItserviceLevelServiceContractId).HasColumnName("ITServiceLevelServiceContractID");

                entity.Property(e => e.ItserviceLevelServiceId).HasColumnName("ITServiceLevelServiceID");
            });

            modelBuilder.Entity<Itservices>(entity =>
            {
                entity.HasKey(e => e.ItserviceId);

                entity.ToTable("ITServices");

                entity.HasIndex(e => e.ItserviceName)
                    .HasName("IX_ITServices")
                    .IsUnique();

                entity.Property(e => e.ItserviceId)
                    .HasColumnName("ITServiceID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ItserviceDescription)
                    .HasColumnName("ITServiceDescription")
                    .HasColumnType("text");

                entity.Property(e => e.ItserviceManager)
                    .HasColumnName("ITServiceManager")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItserviceName)
                    .IsRequired()
                    .HasColumnName("ITServiceName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItserviceOpenDay1).HasColumnName("ITServiceOpenDay1");

                entity.Property(e => e.ItserviceOpenDay2).HasColumnName("ITServiceOpenDay2");

                entity.Property(e => e.ItserviceOpenDay3).HasColumnName("ITServiceOpenDay3");

                entity.Property(e => e.ItserviceOpenDay4).HasColumnName("ITServiceOpenDay4");

                entity.Property(e => e.ItserviceOpenDay5).HasColumnName("ITServiceOpenDay5");

                entity.Property(e => e.ItserviceOpenDay6).HasColumnName("ITServiceOpenDay6");

                entity.Property(e => e.ItserviceOpenDay7).HasColumnName("ITServiceOpenDay7");

                entity.Property(e => e.ItserviceOpenFromDay1)
                    .HasColumnName("ITServiceOpenFromDay1")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenFromDay2)
                    .HasColumnName("ITServiceOpenFromDay2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenFromDay3)
                    .HasColumnName("ITServiceOpenFromDay3")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenFromDay4)
                    .HasColumnName("ITServiceOpenFromDay4")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenFromDay5)
                    .HasColumnName("ITServiceOpenFromDay5")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenFromDay6)
                    .HasColumnName("ITServiceOpenFromDay6")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenFromDay7)
                    .HasColumnName("ITServiceOpenFromDay7")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenTimeZoneBias).HasColumnName("ITServiceOpenTimeZoneBias");

                entity.Property(e => e.ItserviceOpenTimeZoneCode)
                    .HasColumnName("ITServiceOpenTimeZoneCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItserviceOpenToDay1)
                    .HasColumnName("ITServiceOpenToDay1")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenToDay2)
                    .HasColumnName("ITServiceOpenToDay2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenToDay3)
                    .HasColumnName("ITServiceOpenToDay3")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenToDay4)
                    .HasColumnName("ITServiceOpenToDay4")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenToDay5)
                    .HasColumnName("ITServiceOpenToDay5")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenToDay6)
                    .HasColumnName("ITServiceOpenToDay6")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItserviceOpenToDay7)
                    .HasColumnName("ITServiceOpenToDay7")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<JobMembers>(entity =>
            {
                entity.HasKey(e => e.JobMemberId);

                entity.Property(e => e.JobMemberId)
                    .HasColumnName("JobMemberID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.JobMemberDate).HasColumnType("smalldatetime");

                entity.Property(e => e.JobMemberDomain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMemberErrorId).HasColumnName("JobMemberErrorID");

                entity.Property(e => e.JobMemberJobId).HasColumnName("JobMemberJobID");

                entity.Property(e => e.JobMemberName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobMemberStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobMemberStatusText).HasColumnType("text");
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.JobCommand).HasColumnType("text");

                entity.Property(e => e.JobCreated).HasColumnType("smalldatetime");

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobDomain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobManagerDomain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobManagerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobResult).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleDay1).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleDay2).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleDay3).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleDay4).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleDay5).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleDay6).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleDay7).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobScheduleTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.JobSettings).HasColumnType("text");

                entity.Property(e => e.JobStartTime).HasColumnType("datetime");

                entity.Property(e => e.JobStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobType).HasDefaultValueSql("((0))");

                entity.Property(e => e.JobUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LicenseGroups>(entity =>
            {
                entity.HasKey(e => e.LicenseGroupId);

                entity.Property(e => e.LicenseGroupId).HasColumnName("LicenseGroupID");

                entity.Property(e => e.LicenseGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseGroupNotes).HasColumnType("text");

                entity.Property(e => e.LicenseGroupParentId).HasColumnName("LicenseGroupParentID");

                entity.Property(e => e.LicenseGroupUniqueId)
                    .HasColumnName("LicenseGroupUniqueID")
                    .HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<LicensePurchases>(entity =>
            {
                entity.HasKey(e => e.LicensePurchaseId);

                entity.Property(e => e.LicensePurchaseId).HasColumnName("LicensePurchaseID");

                entity.Property(e => e.LicensePurchaseCustomerId).HasColumnName("LicensePurchaseCustomerID");

                entity.Property(e => e.LicensePurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.LicensePurchaseInvoiceId)
                    .HasColumnName("LicensePurchaseInvoiceID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.LicensePurchaseLicenseId).HasColumnName("LicensePurchaseLicenseID");

                entity.Property(e => e.LicensePurchaseNotes).HasColumnType("text");

                entity.Property(e => e.LicensePurchaseSupplier)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Licenses>(entity =>
            {
                entity.HasKey(e => e.LicenseId);

                entity.Property(e => e.LicenseId)
                    .HasColumnName("LicenseID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.LicenseComment).HasColumnType("text");

                entity.Property(e => e.LicenseGroupId).HasColumnName("LicenseGroupID");

                entity.Property(e => e.LicenseName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseType).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LicenseSupport>(entity =>
            {
                entity.Property(e => e.LicenseSupportId).HasColumnName("LicenseSupportID");

                entity.Property(e => e.LicenseSupportCustomerId).HasColumnName("LicenseSupportCustomerID");

                entity.Property(e => e.LicenseSupportEndDate).HasColumnType("datetime");

                entity.Property(e => e.LicenseSupportLicenseId).HasColumnName("LicenseSupportLicenseID");

                entity.Property(e => e.LicenseSupportNotes).HasColumnType("text");

                entity.Property(e => e.LicenseSupportReminderSent).HasColumnType("datetime");

                entity.Property(e => e.LicenseSupportStartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.Property(e => e.MailBody).HasColumnType("text");

                entity.Property(e => e.MailBox)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MailDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MailFormat)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MailPlainText).HasColumnType("text");

                entity.Property(e => e.MailSubject)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MailThread)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MailType)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailAttachments>(entity =>
            {
                entity.HasKey(e => e.MailAttachmentId);

                entity.Property(e => e.MailAttachmentFilename)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailAttachmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailRecipients>(entity =>
            {
                entity.HasKey(e => e.MailRecipientId);

                entity.Property(e => e.MailRecipientAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailRecipientName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MailRecipientType)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeterApps>(entity =>
            {
                entity.HasKey(e => e.MeterAppId);

                entity.Property(e => e.MeterAppId)
                    .HasColumnName("MeterAppID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.MeterAppAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterAppApplication)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterAppClient)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterAppCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.MeterAppDomain)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterAppFirstUse).HasColumnType("smalldatetime");

                entity.Property(e => e.MeterAppGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterAppLastUse).HasColumnType("smalldatetime");

                entity.Property(e => e.MeterAppName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeterAppVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MgmtLog>(entity =>
            {
                entity.HasIndex(e => e.MgmtLogTime);

                entity.Property(e => e.MgmtLogId).HasColumnName("MgmtLogID");

                entity.Property(e => e.MgmtLogCategory)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MgmtLogEventId).HasColumnName("MgmtLogEventID");

                entity.Property(e => e.MgmtLogGroup)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MgmtLogHost)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MgmtLogOrigin)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MgmtLogSource)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MgmtLogStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.MgmtLogText).HasColumnType("text");

                entity.Property(e => e.MgmtLogTime).HasColumnType("datetime");

                entity.Property(e => e.MgmtLogUser)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObjectLinks>(entity =>
            {
                entity.HasKey(e => e.ObjectLinkId);

                entity.Property(e => e.ObjectLinkId)
                    .HasColumnName("ObjectLinkID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ObjectLinkDestinationId).HasColumnName("ObjectLinkDestinationID");

                entity.Property(e => e.ObjectLinkDestinationType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectLinkNotes).HasColumnType("text");

                entity.Property(e => e.ObjectLinkSourceId).HasColumnName("ObjectLinkSourceID");

                entity.Property(e => e.ObjectLinkSourceType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectLinkText)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Os>(entity =>
            {
                entity.ToTable("OS");

                entity.Property(e => e.Osid).HasColumnName("OSID");

                entity.Property(e => e.Osbuild)
                    .HasColumnName("OSBuild")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OsinstallDate)
                    .HasColumnName("OSInstallDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OsinventoryId).HasColumnName("OSInventoryID");

                entity.Property(e => e.Oslanguage)
                    .HasColumnName("OSLanguage")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Osname)
                    .HasColumnName("OSName")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.OsservicePack)
                    .HasColumnName("OSServicePack")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Ostype)
                    .HasColumnName("OSType")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ratings>(entity =>
            {
                entity.HasKey(e => e.RatingId);

                entity.HasIndex(e => new { e.RatingUser, e.RatingObjectType, e.RatingObjectId })
                    .HasName("IX_Ratings")
                    .IsUnique();

                entity.Property(e => e.RatingId).HasColumnName("RatingID");

                entity.Property(e => e.RatingDate).HasColumnType("datetime");

                entity.Property(e => e.RatingObjectId)
                    .IsRequired()
                    .HasColumnName("RatingObjectID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RatingObjectType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RatingUser)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDisplayName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceInventoryId).HasColumnName("ServiceInventoryID");

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceStartMode)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceVersion)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.HasKey(e => new { e.SettingScope, e.SettingIdentifier, e.SettingModule, e.SettingKey, e.SettingName, e.SettingType });

                entity.HasIndex(e => new { e.SettingScope, e.SettingIdentifier, e.SettingKey, e.SettingModule, e.SettingName })
                    .HasName("IX_Settings")
                    .IsUnique();

                entity.Property(e => e.SettingScope)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SettingIdentifier)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingModule)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SettingKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SettingValue).HasColumnType("text");
            });

            modelBuilder.Entity<Software>(entity =>
            {
                entity.Property(e => e.SoftwareId).HasColumnName("SoftwareID");

                entity.Property(e => e.SoftwareInstallDate).HasColumnType("datetime");

                entity.Property(e => e.SoftwareInstallType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareInventoryId).HasColumnName("SoftwareInventoryID");

                entity.Property(e => e.SoftwareLanguage)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SoftwareUninstall).HasColumnType("text");

                entity.Property(e => e.SoftwareVersion)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysInfo>(entity =>
            {
                entity.Property(e => e.SysInfoId).HasColumnName("SysInfoID");

                entity.Property(e => e.SysInfoCategory)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SysInfoGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SysInfoInventoryId).HasColumnName("SysInfoInventoryID");

                entity.Property(e => e.SysInfoItem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SysInfoProperty)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SysInfoValue)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<System>(entity =>
            {
                entity.HasKey(e => e.LicenseKey);

                entity.Property(e => e.LicenseKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CaseIdprefix)
                    .HasColumnName("CaseIDPrefix")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DatabaseVersion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastReport).HasColumnType("datetime");

                entity.Property(e => e.LicensePin)
                    .HasColumnName("LicensePIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Updates>(entity =>
            {
                entity.HasKey(e => e.UpdateId);

                entity.Property(e => e.UpdateId).HasColumnName("UpdateID");

                entity.Property(e => e.UpdateInstallDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateInventoryId).HasColumnName("UpdateInventoryID");

                entity.Property(e => e.UpdateLanguage)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateName)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUninstall).HasColumnType("text");

                entity.Property(e => e.UpdateVersion)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasIndex(e => e.UserLoginName);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.UserAccountEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserAuthPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAuthType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCompany)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCustomerId).HasColumnName("UserCustomerID");

                entity.Property(e => e.UserDebitAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDebitActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserDebitActivity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDebitDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDebitExist).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserDebitId).HasColumnName("UserDebitID");

                entity.Property(e => e.UserDebitObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDebitOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDebitProject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDebitReceiver)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserDistinguishedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserExportMdm)
                    .HasColumnName("UserExportMDM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserFullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserLastLogon).HasColumnType("datetime");

                entity.Property(e => e.UserLoginName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserMobile)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UserPersonalId)
                    .HasColumnName("UserPersonalID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPosition)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserSyncDate).HasColumnType("datetime");

                entity.Property(e => e.UserSyncId)
                    .HasColumnName("UserSyncID")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.UserSyncSource)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserSynchronized).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VmGuestAdapters>(entity =>
            {
                entity.HasKey(e => e.VmGuestAdapterId);

                entity.Property(e => e.VmGuestAdapterId)
                    .HasColumnName("VmGuestAdapterID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VmGuestAdapterGuestId).HasColumnName("VmGuestAdapterGuestID");

                entity.Property(e => e.VmGuestAdapterMacaddress)
                    .HasColumnName("VmGuestAdapterMACAddress")
                    .HasMaxLength(17)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VmGuests>(entity =>
            {
                entity.HasKey(e => e.VmGuestId);

                entity.Property(e => e.VmGuestId)
                    .HasColumnName("VmGuestID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.VmGuestHostId).HasColumnName("VmGuestHostID");

                entity.Property(e => e.VmGuestName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VmGuestUuid)
                    .HasColumnName("VmGuestUUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
