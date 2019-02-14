using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Documents
    {
        public Guid DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string DocumentPath { get; set; }
        public string DocumentType { get; set; }
    }
}
