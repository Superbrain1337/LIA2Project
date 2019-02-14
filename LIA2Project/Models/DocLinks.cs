using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class DocLinks
    {
        public Guid DocLinkId { get; set; }
        public Guid DocLinkDocumentId { get; set; }
        public string DocLinkLinkType { get; set; }
        public Guid? DocLinkLinkId { get; set; }
    }
}
