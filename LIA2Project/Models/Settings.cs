using System;
using System.Collections.Generic;

namespace LIA2Project.Models
{
    public partial class Settings
    {
        public string SettingScope { get; set; }
        public string SettingIdentifier { get; set; }
        public string SettingModule { get; set; }
        public string SettingKey { get; set; }
        public string SettingName { get; set; }
        public string SettingType { get; set; }
        public string SettingValue { get; set; }
    }
}
