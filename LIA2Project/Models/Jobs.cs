using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Jobs
    {
        public Guid JobId { get; set; }
        public byte? JobStatus { get; set; }
        public string JobName { get; set; }
        public string JobDescription { get; set; }
        public DateTime? JobCreated { get; set; }
        public byte? JobType { get; set; }
        public string JobUser { get; set; }
        public string JobPassword { get; set; }
        public string JobDomain { get; set; }
        public string JobCommand { get; set; }
        public byte? JobResult { get; set; }
        public DateTime? JobStartTime { get; set; }
        public bool? JobScheduleDay1 { get; set; }
        public bool? JobScheduleDay2 { get; set; }
        public bool? JobScheduleDay3 { get; set; }
        public bool? JobScheduleDay4 { get; set; }
        public bool? JobScheduleDay5 { get; set; }
        public bool? JobScheduleDay6 { get; set; }
        public bool? JobScheduleDay7 { get; set; }
        public DateTime? JobScheduleTime { get; set; }
        public string JobManagerDomain { get; set; }
        public string JobManagerName { get; set; }
        public byte? JobStartType { get; set; }
        public string JobSettings { get; set; }
    }
}
