using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class MailAttachments
    {
        public int MailAttachmentId { get; set; }
        public int MailAttachmentMailId { get; set; }
        public string MailAttachmentName { get; set; }
        public string MailAttachmentFilename { get; set; }
    }
}
