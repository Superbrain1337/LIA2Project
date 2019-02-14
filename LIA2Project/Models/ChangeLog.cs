using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class ChangeLog
    {
        public int ChangeLogId { get; set; }
        public DateTime ChangeLogDate { get; set; }
        public int ChangeLogAction { get; set; }
        public string ChangeLogObjectType { get; set; }
        public string ChangeLogObjectName { get; set; }
        public Guid? ChangeLogObjectId { get; set; }
        public string ChangeLogObjectProperty { get; set; }
        public string ChangeLogObjectOldValue { get; set; }
        public string ChangeLogObjectNewValue { get; set; }
        public string ChangeLogObjectUser { get; set; }
    }
}
