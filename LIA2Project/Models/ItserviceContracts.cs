using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class ItserviceContracts
    {
        public Guid ItserviceContractId { get; set; }
        public string ItserviceContractName { get; set; }
        public string ItserviceContractDescription { get; set; }
        public DateTime? ItserviceContractValidFrom { get; set; }
        public DateTime? ItserviceContractValidTo { get; set; }
        public Guid ItserviceContractCustomerId { get; set; }
        public bool ItserviceContractUseForSubCustomers { get; set; }
        public string ItserviceContractCustomerContact { get; set; }
        public bool ItserviceContractCustomerContactSendMail { get; set; }
        public string ItserviceContractManager { get; set; }
        public bool ItserviceContractManagerSendMail { get; set; }
        public DateTime? ItserviceContractCustomerContactReminderSent { get; set; }
        public DateTime? ItserviceContractManagerReminderSent { get; set; }
    }
}
