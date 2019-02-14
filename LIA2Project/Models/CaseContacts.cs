using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class CaseContacts
    {
        public int CaseContactId { get; set; }
        public int CaseId { get; set; }
        public string CaseContactName { get; set; }
        public string CaseContactGroup { get; set; }
        public short? CaseContactRole { get; set; }
        public bool? CaseContactNotify { get; set; }
    }
}
