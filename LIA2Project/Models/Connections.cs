using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Connections
    {
        public int ConnId { get; set; }
        public Guid ConnDeviceId { get; set; }
        public int? ConnIfIndex { get; set; }
        public string ConnIfName { get; set; }
        public short? ConnPort { get; set; }
        public string ConnMacaddress { get; set; }
        public string ConnVlan { get; set; }
        public long? ConnSpeed { get; set; }
        public short? ConnDuplexMode { get; set; }
        public short? ConnDuplexType { get; set; }
        public byte? ConnDuplexConfig { get; set; }
        public short? ConnAdminStatus { get; set; }
        public short? ConnOperStatus { get; set; }
        public string ConnRemoteMacaddress { get; set; }
        public string ConnRemoteIp { get; set; }
        public short? ConnRemotePort { get; set; }
        public string ConnRemoteIfName { get; set; }
        public short ConnRemoteStatus { get; set; }
    }
}
