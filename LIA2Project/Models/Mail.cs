using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Mail
    {
        public int MailId { get; set; }
        public string MailSubject { get; set; }
        public string MailBody { get; set; }
        public string MailFormat { get; set; }
        public string MailPlainText { get; set; }
        public short? MailPrio { get; set; }
        public string MailBox { get; set; }
        public DateTime? MailDate { get; set; }
        public string MailType { get; set; }
        public string MailThread { get; set; }
    }
}
