using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIA2Project.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "A_History",
                columns: table => new
                {
                    HistoryID = table.Column<Guid>(nullable: false),
                    HistoryInventoryID = table.Column<Guid>(nullable: true),
                    HistoryType = table.Column<byte>(nullable: true),
                    HistorySubject = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HistoryText = table.Column<string>(type: "text", nullable: true),
                    HistoryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HistorySeverity = table.Column<byte>(nullable: true),
                    HistoryUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HistorySource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HistoryCategory = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HistoryGroup = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_History", x => x.HistoryID);
                });

            migrationBuilder.CreateTable(
                name: "A_Inventory",
                columns: table => new
                {
                    InventoryID = table.Column<Guid>(nullable: false),
                    InventoryGroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InventoryDescription = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryType = table.Column<int>(nullable: false),
                    InventoryLocation = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySupplier = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryPurchaseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryPurchaseAmount = table.Column<double>(nullable: true),
                    InventoryWarrantyTo = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySerialNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryInvoiceNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryAccessory = table.Column<bool>(nullable: true),
                    InventoryParent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySecurityID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryOwner = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryComment = table.Column<string>(type: "text", nullable: true),
                    InventorySupportNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySupportFrom = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySupportTo = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySupportCost = table.Column<double>(nullable: true),
                    InventorySupportExtent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryInvDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InventoryAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySubgroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitExist = table.Column<bool>(nullable: true),
                    InventoryDebitID = table.Column<Guid>(nullable: true),
                    InventoryDebitOwner = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitReceiver = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitDepartment = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitActivity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitActive = table.Column<bool>(nullable: true),
                    InventorySynchronized = table.Column<bool>(nullable: true),
                    InventorySyncSource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryCustomerID = table.Column<Guid>(nullable: true),
                    InventoryExternalID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryManufacturer = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryModel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryVirtualHost = table.Column<Guid>(nullable: true),
                    InventoryVirtualType = table.Column<byte>(nullable: true),
                    InventoryDebitObject = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryLastLogon = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySyncDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySyncID = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    InventoryUniqueID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryLocationLatitude = table.Column<double>(nullable: true),
                    InventoryLocationLongitude = table.Column<double>(nullable: true),
                    InventoryLocationAltitude = table.Column<double>(nullable: true),
                    InventoryLocationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryWarrantyToReminderSent = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySupportToReminderSent = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryProductNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitProject = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDistinguishedName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InventorySupportType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    InventoryProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryImportMDM = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_A_Inventory", x => x.InventoryID);
                });

            migrationBuilder.CreateTable(
                name: "Actions",
                columns: table => new
                {
                    ActionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActionType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ActionTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActionData = table.Column<string>(type: "text", nullable: true),
                    ActionSource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ActionStatus = table.Column<short>(nullable: true),
                    ActionRetryCount = table.Column<short>(nullable: true),
                    ActionRetryMax = table.Column<short>(nullable: true),
                    ActionLastTry = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actions", x => x.ActionID);
                });

            migrationBuilder.CreateTable(
                name: "AppInfo",
                columns: table => new
                {
                    AppInfoID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    AppInfoApplication = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AppInfoVersion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AppInfoDescription = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AppInfoCompany = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AppInfoProduct = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    AppInfoProductVersion = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppInfo", x => x.AppInfoID);
                });

            migrationBuilder.CreateTable(
                name: "AppLinks",
                columns: table => new
                {
                    AppLinkID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    AppLinkLicense = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    AppLinkApplication = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    AppLinkVersion = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLinks", x => x.AppLinkID);
                });

            migrationBuilder.CreateTable(
                name: "CaseContacts",
                columns: table => new
                {
                    CaseContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseID = table.Column<int>(nullable: false),
                    CaseContactName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CaseContactGroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseContactRole = table.Column<short>(nullable: true),
                    CaseContactNotify = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseContacts", x => x.CaseContactID);
                });

            migrationBuilder.CreateTable(
                name: "CaseDevices",
                columns: table => new
                {
                    CaseDeviceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseID = table.Column<int>(nullable: false),
                    CaseDeviceInventoryID = table.Column<Guid>(nullable: true),
                    CaseDeviceGroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseDeviceName = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseDevices", x => x.CaseDeviceID);
                });

            migrationBuilder.CreateTable(
                name: "CaseEvents",
                columns: table => new
                {
                    CaseEventID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseID = table.Column<int>(nullable: false),
                    CaseEventText = table.Column<string>(type: "text", nullable: true),
                    CaseEventTime = table.Column<double>(nullable: true),
                    CaseEventCreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseEventCreatedUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseEventStatus = table.Column<byte>(nullable: true, defaultValueSql: "((0))"),
                    CaseEventWeb = table.Column<bool>(nullable: true),
                    CaseEventType = table.Column<short>(nullable: true),
                    CaseEventDebit = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    CaseEventObjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseEvents", x => x.CaseEventID);
                });

            migrationBuilder.CreateTable(
                name: "CaseGroups",
                columns: table => new
                {
                    CaseGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseGroupName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseGroupNotes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseGroups", x => x.CaseGroupID);
                });

            migrationBuilder.CreateTable(
                name: "CaseItems",
                columns: table => new
                {
                    CaseItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseID = table.Column<int>(nullable: false),
                    CaseItemNumber = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    CaseItemName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CaseItemDescription = table.Column<string>(type: "text", nullable: true),
                    CaseItemPrice = table.Column<double>(nullable: true),
                    CaseItemCount = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    CaseItemDebit = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    CaseItemDate = table.Column<DateTime>(type: "smalldatetime", nullable: false, defaultValueSql: "(getutcdate())"),
                    CaseItemNeedsApproval = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseItems", x => x.CaseItemID);
                });

            migrationBuilder.CreateTable(
                name: "CaseMail",
                columns: table => new
                {
                    CaseMailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseMailCaseId = table.Column<int>(nullable: false),
                    CaseMailMailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseMail", x => x.CaseMailId);
                });

            migrationBuilder.CreateTable(
                name: "CaseReferences",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseID = table.Column<int>(nullable: false),
                    CaseReferenceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseReferences", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    CaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CaseName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseType = table.Column<byte>(nullable: true),
                    CasePriority = table.Column<short>(nullable: true, defaultValueSql: "((0))"),
                    CaseNotes = table.Column<string>(type: "text", nullable: true),
                    CaseCreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseCreatedUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseChangedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseChangedUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseStatus = table.Column<byte>(nullable: true),
                    CaseStatusDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseStatusUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseLevel = table.Column<byte>(nullable: true),
                    CaseLevelDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseLevelUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseCategory1 = table.Column<byte>(nullable: true),
                    CaseCategory2 = table.Column<byte>(nullable: true),
                    CaseCategory3 = table.Column<byte>(nullable: true),
                    CaseGroupID = table.Column<int>(nullable: true),
                    CaseCustomerID = table.Column<Guid>(nullable: true),
                    CaseUniqueID = table.Column<Guid>(nullable: true, defaultValueSql: "(newid())"),
                    CaseAssignedTo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseAssignedUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseAssignedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseDueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseDueUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseCalcDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseCalcUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseNotify = table.Column<bool>(nullable: true),
                    CaseRemind = table.Column<bool>(nullable: true),
                    CaseRemindDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseKeywords = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CaseDescription = table.Column<string>(type: "text", nullable: true),
                    CaseSolution = table.Column<string>(type: "text", nullable: true),
                    CaseReportedBy = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CaseReportedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseArchived = table.Column<bool>(nullable: false),
                    CaseDebit = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    CaseLangID = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    CaseServiceID = table.Column<Guid>(nullable: true),
                    CaseServiceLevelUpdate = table.Column<bool>(nullable: false),
                    CaseServiceLevelID = table.Column<Guid>(nullable: true),
                    CaseServiceLevelContractID = table.Column<Guid>(nullable: true),
                    CaseServiceLevelActionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseServiceLevelEscalateDateLevel2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseServiceLevelEscalateDateLevel3 = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseServiceLevelNotifyDateHandler = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseServiceLevelNotifyDateManager = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseServiceLevelNotificationSentHandler = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseServiceLevelNotificationSentManager = table.Column<DateTime>(type: "datetime", nullable: true),
                    CaseCalcTime = table.Column<double>(nullable: true),
                    CaseVisibility = table.Column<byte>(nullable: true, defaultValueSql: "((0))"),
                    CaseExternalNumber = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CaseRatingValue = table.Column<double>(nullable: true),
                    CaseRatingCount = table.Column<int>(nullable: true),
                    CaseIsTemplate = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.CaseID);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesLevel1",
                columns: table => new
                {
                    SysID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<int>(nullable: true),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesLevel1", x => x.SysID);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesLevel2",
                columns: table => new
                {
                    SysID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<int>(nullable: true),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Category1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesLevel2", x => x.SysID);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesLevel3",
                columns: table => new
                {
                    SysID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<int>(nullable: true),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Category1 = table.Column<int>(nullable: true),
                    Category2 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesLevel3", x => x.SysID);
                });

            migrationBuilder.CreateTable(
                name: "ChangeLog",
                columns: table => new
                {
                    ChangeLogID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChangeLogDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    ChangeLogAction = table.Column<int>(nullable: false),
                    ChangeLogObjectType = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    ChangeLogObjectName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ChangeLogObjectID = table.Column<Guid>(nullable: true),
                    ChangeLogObjectProperty = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ChangeLogObjectOldValue = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ChangeLogObjectNewValue = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    ChangeLogObjectUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChangeLog", x => x.ChangeLogID);
                });

            migrationBuilder.CreateTable(
                name: "Connections",
                columns: table => new
                {
                    ConnID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConnDeviceID = table.Column<Guid>(nullable: false),
                    ConnIfIndex = table.Column<int>(nullable: true),
                    ConnIfName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ConnPort = table.Column<short>(nullable: true),
                    ConnMACAddress = table.Column<string>(unicode: false, maxLength: 17, nullable: true),
                    ConnVLAN = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ConnSpeed = table.Column<long>(nullable: true),
                    ConnDuplexMode = table.Column<short>(nullable: true),
                    ConnDuplexType = table.Column<short>(nullable: true),
                    ConnDuplexConfig = table.Column<byte>(nullable: true),
                    ConnAdminStatus = table.Column<short>(nullable: true),
                    ConnOperStatus = table.Column<short>(nullable: true),
                    ConnRemoteMACAddress = table.Column<string>(unicode: false, maxLength: 17, nullable: true),
                    ConnRemoteIP = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    ConnRemotePort = table.Column<short>(nullable: true),
                    ConnRemoteIfName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ConnRemoteStatus = table.Column<short>(nullable: false, defaultValueSql: "((1))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Connections", x => x.ConnID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    CustomerName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CustomerNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CustomerDescription = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CustomerParentID = table.Column<Guid>(nullable: true),
                    CustomerType = table.Column<short>(nullable: true),
                    CustomerSynchronized = table.Column<bool>(nullable: true),
                    CustomerSyncSource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CustomerSyncDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CustomerSyncID = table.Column<string>(unicode: false, maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Debits",
                columns: table => new
                {
                    DebitID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    DebitCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DebitName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DebitComment = table.Column<string>(type: "text", nullable: true),
                    DebitAmount = table.Column<double>(nullable: true),
                    DebitType = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Debits", x => x.DebitID);
                });

            migrationBuilder.CreateTable(
                name: "DocLinks",
                columns: table => new
                {
                    DocLinkID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    DocLinkDocumentID = table.Column<Guid>(nullable: false),
                    DocLinkLinkType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DocLinkLinkID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocLinks", x => x.DocLinkID);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    DocumentName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DocumentPath = table.Column<string>(type: "text", nullable: true),
                    DocumentType = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentID);
                });

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    HistoryID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    HistoryInventoryID = table.Column<Guid>(nullable: true),
                    HistoryType = table.Column<byte>(nullable: true),
                    HistorySubject = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    HistoryText = table.Column<string>(type: "text", nullable: true),
                    HistoryDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    HistorySeverity = table.Column<byte>(nullable: true, defaultValueSql: "((0))"),
                    HistoryUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HistorySource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    HistoryCategory = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    HistoryGroup = table.Column<string>(unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.HistoryID);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    InfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InfoType = table.Column<byte>(nullable: true),
                    InfoTitle = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InfoText = table.Column<string>(type: "text", nullable: true),
                    InfoTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InfoVisibility = table.Column<byte>(nullable: true),
                    InfoUniqueID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    InfoSolution = table.Column<string>(type: "text", nullable: true),
                    InfoExpires = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InfoLangID = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    InfoCategory1 = table.Column<byte>(nullable: true),
                    InfoCategory2 = table.Column<byte>(nullable: true),
                    InfoCategory3 = table.Column<byte>(nullable: true),
                    InfoRatingValue = table.Column<double>(nullable: true),
                    InfoRatingCount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.InfoID);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    InventoryID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    InventoryGroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InventoryDescription = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryType = table.Column<int>(nullable: false),
                    InventoryLocation = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySupplier = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryPurchaseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryPurchaseAmount = table.Column<double>(nullable: true),
                    InventoryWarrantyTo = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySerialNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryInvoiceNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryUserName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryAccessory = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    InventoryParent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySecurityID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryOwner = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryComment = table.Column<string>(type: "text", nullable: true),
                    InventorySupportNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySupportFrom = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySupportTo = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySupportCost = table.Column<double>(nullable: true),
                    InventorySupportExtent = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryInvDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    InventoryAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryStatus = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventorySubgroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitExist = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    InventoryDebitID = table.Column<Guid>(nullable: true),
                    InventoryDebitOwner = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitReceiver = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitDepartment = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitActivity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitActive = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    InventorySynchronized = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    InventorySyncSource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryCustomerID = table.Column<Guid>(nullable: true),
                    InventoryExternalID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryManufacturer = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryModel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryVirtualHost = table.Column<Guid>(nullable: true),
                    InventoryVirtualType = table.Column<byte>(nullable: true),
                    InventoryDebitObject = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryLastLogon = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySyncDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySyncID = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    InventoryUniqueID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryLocationLatitude = table.Column<double>(nullable: true),
                    InventoryLocationLongitude = table.Column<double>(nullable: true),
                    InventoryLocationAltitude = table.Column<double>(nullable: true),
                    InventoryLocationTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryWarrantyToReminderSent = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventorySupportToReminderSent = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryProductNumber = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDebitProject = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    InventoryDistinguishedName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    InventorySupportType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    InventoryProductionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    InventoryImportMDM = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.InventoryID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    ItemNumber = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    ItemName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ItemDescription = table.Column<string>(type: "text", nullable: true),
                    ItemPrice = table.Column<double>(nullable: false),
                    ItemWeb = table.Column<bool>(nullable: false),
                    ItemNeedsApproval = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "ITServiceContracts",
                columns: table => new
                {
                    ITServiceContractID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    ITServiceContractName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ITServiceContractDescription = table.Column<string>(type: "text", nullable: true),
                    ITServiceContractValidFrom = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceContractValidTo = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceContractCustomerID = table.Column<Guid>(nullable: false),
                    ITServiceContractUseForSubCustomers = table.Column<bool>(nullable: false),
                    ITServiceContractCustomerContact = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ITServiceContractCustomerContactSendMail = table.Column<bool>(nullable: false),
                    ITServiceContractManager = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ITServiceContractManagerSendMail = table.Column<bool>(nullable: false),
                    ITServiceContractCustomerContactReminderSent = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceContractManagerReminderSent = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITServiceContracts", x => x.ITServiceContractID);
                });

            migrationBuilder.CreateTable(
                name: "ITServiceLevels",
                columns: table => new
                {
                    ITServiceLevelID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    ITServiceLevelServiceContractID = table.Column<Guid>(nullable: false),
                    ITServiceLevelServiceID = table.Column<Guid>(nullable: false),
                    ITServiceLevelCaseType = table.Column<byte>(nullable: true),
                    ITServiceLevelCaseGroupID = table.Column<int>(nullable: true),
                    ITServiceLevelCaseCategory1 = table.Column<byte>(nullable: true),
                    ITServiceLevelCaseCategory2 = table.Column<byte>(nullable: true),
                    ITServiceLevelCaseCategory3 = table.Column<byte>(nullable: true),
                    ITServiceLevelCasePriority = table.Column<short>(nullable: true),
                    ITServiceLevelActionTime = table.Column<int>(nullable: true),
                    ITServiceLevelEscalateTimeLevel2 = table.Column<int>(nullable: true),
                    ITServiceLevelEscalateTimeLevel3 = table.Column<int>(nullable: true),
                    ITServiceLevelNotifyHandlerTime = table.Column<int>(nullable: true),
                    ITServiceLevelNotifyManagerTime = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITServiceLevels", x => x.ITServiceLevelID);
                });

            migrationBuilder.CreateTable(
                name: "ITServices",
                columns: table => new
                {
                    ITServiceID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    ITServiceName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ITServiceDescription = table.Column<string>(type: "text", nullable: true),
                    ITServiceManager = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ITServiceOpenDay1 = table.Column<bool>(nullable: false),
                    ITServiceOpenFromDay1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenToDay1 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenDay2 = table.Column<bool>(nullable: false),
                    ITServiceOpenFromDay2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenToDay2 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenDay3 = table.Column<bool>(nullable: false),
                    ITServiceOpenFromDay3 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenToDay3 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenDay4 = table.Column<bool>(nullable: false),
                    ITServiceOpenFromDay4 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenToDay4 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenDay5 = table.Column<bool>(nullable: false),
                    ITServiceOpenFromDay5 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenToDay5 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenDay6 = table.Column<bool>(nullable: false),
                    ITServiceOpenFromDay6 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenToDay6 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenDay7 = table.Column<bool>(nullable: false),
                    ITServiceOpenFromDay7 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenToDay7 = table.Column<DateTime>(type: "datetime", nullable: true),
                    ITServiceOpenTimeZoneCode = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ITServiceOpenTimeZoneBias = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITServices", x => x.ITServiceID);
                });

            migrationBuilder.CreateTable(
                name: "JobMembers",
                columns: table => new
                {
                    JobMemberID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    JobMemberDomain = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobMemberName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobMemberStatus = table.Column<byte>(nullable: true, defaultValueSql: "((0))"),
                    JobMemberDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    JobMemberJobID = table.Column<Guid>(nullable: true),
                    JobMemberErrorID = table.Column<int>(nullable: true),
                    JobMemberStatusText = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobMembers", x => x.JobMemberID);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    JobID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    JobStatus = table.Column<byte>(nullable: true, defaultValueSql: "((0))"),
                    JobName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobDescription = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobCreated = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    JobType = table.Column<byte>(nullable: true, defaultValueSql: "((0))"),
                    JobUser = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobPassword = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobDomain = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobCommand = table.Column<string>(type: "text", nullable: true),
                    JobResult = table.Column<byte>(nullable: true, defaultValueSql: "((0))"),
                    JobStartTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    JobScheduleDay1 = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    JobScheduleDay2 = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    JobScheduleDay3 = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    JobScheduleDay4 = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    JobScheduleDay5 = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    JobScheduleDay6 = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    JobScheduleDay7 = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    JobScheduleTime = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "((0))"),
                    JobManagerDomain = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobManagerName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    JobStartType = table.Column<byte>(nullable: true),
                    JobSettings = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobID);
                });

            migrationBuilder.CreateTable(
                name: "LicenseGroups",
                columns: table => new
                {
                    LicenseGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LicenseGroupParentID = table.Column<int>(nullable: true),
                    LicenseGroupName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    LicenseGroupNotes = table.Column<string>(type: "text", nullable: true),
                    LicenseGroupUniqueID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseGroups", x => x.LicenseGroupID);
                });

            migrationBuilder.CreateTable(
                name: "LicensePurchases",
                columns: table => new
                {
                    LicensePurchaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LicensePurchaseLicenseID = table.Column<Guid>(nullable: true),
                    LicensePurchaseType = table.Column<int>(nullable: true),
                    LicensePurchaseDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LicensePurchaseCount = table.Column<int>(nullable: true),
                    LicensePurchaseCost = table.Column<double>(nullable: true),
                    LicensePurchaseNotes = table.Column<string>(type: "text", nullable: true),
                    LicensePurchaseCustomerID = table.Column<Guid>(nullable: true),
                    LicensePurchaseSupplier = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    LicensePurchaseInvoiceID = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicensePurchases", x => x.LicensePurchaseID);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    LicenseID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    LicenseName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    LicenseComment = table.Column<string>(type: "text", nullable: true),
                    LicenseType = table.Column<int>(nullable: true, defaultValueSql: "((1))"),
                    LicenseGroupID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.LicenseID);
                });

            migrationBuilder.CreateTable(
                name: "LicenseSupport",
                columns: table => new
                {
                    LicenseSupportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LicenseSupportStartDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LicenseSupportEndDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LicenseSupportCost = table.Column<double>(nullable: true),
                    LicenseSupportPeriod = table.Column<byte>(nullable: true),
                    LicenseSupportType = table.Column<byte>(nullable: true),
                    LicenseSupportNotes = table.Column<string>(type: "text", nullable: true),
                    LicenseSupportLicenseID = table.Column<Guid>(nullable: true),
                    LicenseSupportCustomerID = table.Column<Guid>(nullable: true),
                    LicenseSupportReminderSent = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseSupport", x => x.LicenseSupportID);
                });

            migrationBuilder.CreateTable(
                name: "Mail",
                columns: table => new
                {
                    MailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MailSubject = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    MailBody = table.Column<string>(type: "text", nullable: true),
                    MailFormat = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MailPlainText = table.Column<string>(type: "text", nullable: true),
                    MailPrio = table.Column<short>(nullable: true),
                    MailBox = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MailDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MailType = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    MailThread = table.Column<string>(unicode: false, maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mail", x => x.MailId);
                });

            migrationBuilder.CreateTable(
                name: "MailAttachments",
                columns: table => new
                {
                    MailAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MailAttachmentMailId = table.Column<int>(nullable: false),
                    MailAttachmentName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    MailAttachmentFilename = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailAttachments", x => x.MailAttachmentId);
                });

            migrationBuilder.CreateTable(
                name: "MailRecipients",
                columns: table => new
                {
                    MailRecipientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MailRecipientMailId = table.Column<int>(nullable: false),
                    MailRecipientType = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    MailRecipientAddress = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    MailRecipientName = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailRecipients", x => x.MailRecipientId);
                });

            migrationBuilder.CreateTable(
                name: "MeterApps",
                columns: table => new
                {
                    MeterAppID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    MeterAppGroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterAppName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterAppDomain = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterAppAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterAppApplication = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterAppVersion = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterAppLastUse = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MeterAppCount = table.Column<int>(nullable: true, defaultValueSql: "((0))"),
                    MeterAppClient = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MeterAppFirstUse = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MeterAppTotalUse = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeterApps", x => x.MeterAppID);
                });

            migrationBuilder.CreateTable(
                name: "MgmtLog",
                columns: table => new
                {
                    MgmtLogID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MgmtLogTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    MgmtLogHost = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    MgmtLogText = table.Column<string>(type: "text", nullable: true),
                    MgmtLogSeverity = table.Column<int>(nullable: true),
                    MgmtLogSource = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    MgmtLogEventID = table.Column<long>(nullable: true),
                    MgmtLogUser = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    MgmtLogCategory = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    MgmtLogOrigin = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    MgmtLogGroup = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    MgmtLogStatus = table.Column<byte>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MgmtLog", x => x.MgmtLogID);
                });

            migrationBuilder.CreateTable(
                name: "ObjectLinks",
                columns: table => new
                {
                    ObjectLinkID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    ObjectLinkSourceID = table.Column<Guid>(nullable: false),
                    ObjectLinkSourceType = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    ObjectLinkDestinationID = table.Column<Guid>(nullable: false),
                    ObjectLinkDestinationType = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    ObjectLinkLinkType = table.Column<short>(nullable: false),
                    ObjectLinkPriority = table.Column<short>(nullable: false),
                    ObjectLinkText = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ObjectLinkNotes = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObjectLinks", x => x.ObjectLinkID);
                });

            migrationBuilder.CreateTable(
                name: "OS",
                columns: table => new
                {
                    OSID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OSInventoryID = table.Column<Guid>(nullable: false),
                    OSName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    OSType = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    OSBuild = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    OSServicePack = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    OSLanguage = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    OSInstallDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OS", x => x.OSID);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RatingUser = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    RatingValue = table.Column<byte>(nullable: false),
                    RatingDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    RatingObjectType = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    RatingObjectID = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceInventoryID = table.Column<Guid>(nullable: false),
                    ServiceName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    ServiceDisplayName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    ServiceStartMode = table.Column<string>(unicode: false, maxLength: 8, nullable: true),
                    ServiceStarted = table.Column<bool>(nullable: true),
                    ServiceAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ServiceVersion = table.Column<string>(unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingScope = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    SettingIdentifier = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SettingModule = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    SettingKey = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SettingName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    SettingType = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    SettingValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => new { x.SettingScope, x.SettingIdentifier, x.SettingModule, x.SettingKey, x.SettingName, x.SettingType });
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    SoftwareID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SoftwareInventoryID = table.Column<Guid>(nullable: false),
                    SoftwareName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    SoftwareLanguage = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    SoftwareInstallDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    SoftwareVersion = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    SoftwareUninstall = table.Column<string>(type: "text", nullable: true),
                    SoftwareInstallType = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    SoftwareIs64Bit = table.Column<bool>(nullable: true),
                    SoftwareIsOfficeSuite = table.Column<bool>(nullable: true),
                    SoftwareIsOfficeStandalone = table.Column<bool>(nullable: true),
                    SoftwareLicenseType = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.SoftwareID);
                });

            migrationBuilder.CreateTable(
                name: "SysInfo",
                columns: table => new
                {
                    SysInfoID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SysInfoInventoryID = table.Column<Guid>(nullable: false),
                    SysInfoCategory = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    SysInfoGroup = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    SysInfoItem = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    SysInfoProperty = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    SysInfoValue = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysInfo", x => x.SysInfoID);
                });

            migrationBuilder.CreateTable(
                name: "System",
                columns: table => new
                {
                    LicenseKey = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LicensePIN = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DatabaseVersion = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    CaseIDPrefix = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    LastReport = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System", x => x.LicenseKey);
                });

            migrationBuilder.CreateTable(
                name: "Updates",
                columns: table => new
                {
                    UpdateID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UpdateInventoryID = table.Column<Guid>(nullable: false),
                    UpdateName = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    UpdateLanguage = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    UpdateInstallDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateVersion = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    UpdateUninstall = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Updates", x => x.UpdateID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    UserGroupName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserLoginName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserFullName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UserPosition = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserTelephone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserMail = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UserDescription = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    UserDepartment = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserAccountEnabled = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    UserSynchronized = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    UserSyncSource = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserAuthPassword = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserAuthType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserHandler = table.Column<bool>(nullable: true),
                    UserDecisionmaker = table.Column<bool>(nullable: true),
                    UserAdministrator = table.Column<bool>(nullable: true),
                    UserCustomerID = table.Column<Guid>(nullable: true),
                    UserDebitExist = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    UserDebitID = table.Column<Guid>(nullable: true),
                    UserDebitOwner = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserDebitAccount = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserDebitReceiver = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserDebitDepartment = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserDebitActivity = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserDebitActive = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    UserLastLogon = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserMobile = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    UserDebitObject = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserSyncDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserSyncID = table.Column<string>(unicode: false, maxLength: 60, nullable: true),
                    UserDebitProject = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserDistinguishedName = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    UserExportMDM = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    UserPersonalID = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    UserCompany = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "VmGuestAdapters",
                columns: table => new
                {
                    VmGuestAdapterID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    VmGuestAdapterGuestID = table.Column<Guid>(nullable: true),
                    VmGuestAdapterMACAddress = table.Column<string>(unicode: false, maxLength: 17, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VmGuestAdapters", x => x.VmGuestAdapterID);
                });

            migrationBuilder.CreateTable(
                name: "VmGuests",
                columns: table => new
                {
                    VmGuestID = table.Column<Guid>(nullable: false, defaultValueSql: "(newid())"),
                    VmGuestHostID = table.Column<Guid>(nullable: false),
                    VmGuestName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    VmGuestPowerState = table.Column<int>(nullable: true),
                    VmGuestUUID = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VmGuests", x => x.VmGuestID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_A_History_HistoryDate",
                table: "A_History",
                column: "HistoryDate");

            migrationBuilder.CreateIndex(
                name: "IX_A_Inventory_InventoryName",
                table: "A_Inventory",
                column: "InventoryName");

            migrationBuilder.CreateIndex(
                name: "IX_CaseContacts_CaseContactName",
                table: "CaseContacts",
                column: "CaseContactName");

            migrationBuilder.CreateIndex(
                name: "IX_CaseDevices_CaseDeviceName",
                table: "CaseDevices",
                column: "CaseDeviceName");

            migrationBuilder.CreateIndex(
                name: "IX_CaseEvents_CaseEventCreatedDate",
                table: "CaseEvents",
                column: "CaseEventCreatedDate");

            migrationBuilder.CreateIndex(
                name: "IX_CaseEvents_CaseID",
                table: "CaseEvents",
                column: "CaseID");

            migrationBuilder.CreateIndex(
                name: "IX_History_HistoryDate",
                table: "History",
                column: "HistoryDate");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_InventoryName",
                table: "Inventory",
                column: "InventoryName");

            migrationBuilder.CreateIndex(
                name: "IX_Items",
                table: "Items",
                column: "ItemNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceContracts",
                table: "ITServiceContracts",
                columns: new[] { "ITServiceContractName", "ITServiceContractCustomerID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceLevels",
                table: "ITServiceLevels",
                columns: new[] { "ITServiceLevelServiceContractID", "ITServiceLevelServiceID", "ITServiceLevelCaseType", "ITServiceLevelCaseGroupID", "ITServiceLevelCaseCategory1", "ITServiceLevelCaseCategory2", "ITServiceLevelCaseCategory3", "ITServiceLevelCasePriority" },
                unique: true,
                filter: "[ITServiceLevelCaseType] IS NOT NULL AND [ITServiceLevelCaseGroupID] IS NOT NULL AND [ITServiceLevelCaseCategory1] IS NOT NULL AND [ITServiceLevelCaseCategory2] IS NOT NULL AND [ITServiceLevelCaseCategory3] IS NOT NULL AND [ITServiceLevelCasePriority] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices",
                table: "ITServices",
                column: "ITServiceName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MgmtLog_MgmtLogTime",
                table: "MgmtLog",
                column: "MgmtLogTime");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings",
                table: "Ratings",
                columns: new[] { "RatingUser", "RatingObjectType", "RatingObjectID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings",
                table: "Settings",
                columns: new[] { "SettingScope", "SettingIdentifier", "SettingKey", "SettingModule", "SettingName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserLoginName",
                table: "Users",
                column: "UserLoginName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "A_History");

            migrationBuilder.DropTable(
                name: "A_Inventory");

            migrationBuilder.DropTable(
                name: "Actions");

            migrationBuilder.DropTable(
                name: "AppInfo");

            migrationBuilder.DropTable(
                name: "AppLinks");

            migrationBuilder.DropTable(
                name: "CaseContacts");

            migrationBuilder.DropTable(
                name: "CaseDevices");

            migrationBuilder.DropTable(
                name: "CaseEvents");

            migrationBuilder.DropTable(
                name: "CaseGroups");

            migrationBuilder.DropTable(
                name: "CaseItems");

            migrationBuilder.DropTable(
                name: "CaseMail");

            migrationBuilder.DropTable(
                name: "CaseReferences");

            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "CategoriesLevel1");

            migrationBuilder.DropTable(
                name: "CategoriesLevel2");

            migrationBuilder.DropTable(
                name: "CategoriesLevel3");

            migrationBuilder.DropTable(
                name: "ChangeLog");

            migrationBuilder.DropTable(
                name: "Connections");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Debits");

            migrationBuilder.DropTable(
                name: "DocLinks");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "History");

            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "ITServiceContracts");

            migrationBuilder.DropTable(
                name: "ITServiceLevels");

            migrationBuilder.DropTable(
                name: "ITServices");

            migrationBuilder.DropTable(
                name: "JobMembers");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "LicenseGroups");

            migrationBuilder.DropTable(
                name: "LicensePurchases");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "LicenseSupport");

            migrationBuilder.DropTable(
                name: "Mail");

            migrationBuilder.DropTable(
                name: "MailAttachments");

            migrationBuilder.DropTable(
                name: "MailRecipients");

            migrationBuilder.DropTable(
                name: "MeterApps");

            migrationBuilder.DropTable(
                name: "MgmtLog");

            migrationBuilder.DropTable(
                name: "ObjectLinks");

            migrationBuilder.DropTable(
                name: "OS");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "SysInfo");

            migrationBuilder.DropTable(
                name: "System");

            migrationBuilder.DropTable(
                name: "Updates");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "VmGuestAdapters");

            migrationBuilder.DropTable(
                name: "VmGuests");
        }
    }
}
