using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class ObjectLinks
    {
        public Guid ObjectLinkId { get; set; }
        public Guid ObjectLinkSourceId { get; set; }
        public string ObjectLinkSourceType { get; set; }
        public Guid ObjectLinkDestinationId { get; set; }
        public string ObjectLinkDestinationType { get; set; }
        public short ObjectLinkLinkType { get; set; }
        public short ObjectLinkPriority { get; set; }
        public string ObjectLinkText { get; set; }
        public string ObjectLinkNotes { get; set; }
    }
}
