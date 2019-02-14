using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class MailRecipients
    {
        public int MailRecipientId { get; set; }
        public int MailRecipientMailId { get; set; }
        public string MailRecipientType { get; set; }
        public string MailRecipientAddress { get; set; }
        public string MailRecipientName { get; set; }
    }
}
