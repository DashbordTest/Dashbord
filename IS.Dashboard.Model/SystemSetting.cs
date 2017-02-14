using System;
using System.Collections.Generic;
using Castle.ActiveRecord;

namespace IS.Dashboard.Model
{
    [ActiveRecord("SystemSetting")]
    public class SystemSetting : BaseModel
    {
        [PrimaryKey(PrimaryKeyType.Identity, "SettingID")]
        public string SettingID { get; set; }

        [Property("SettingName")]
        public string SettingName { get; set; }

        [Property("CategoryNode")]
        public string CategoryNode { get; set; }

        [Property("CategoryLevel")]
        public int CategoryLevel { get; set; }

        [Property("Value")]
        public string Value { get; set; }

        [Property("ModifiedDate")]
        public string DateTime { get; set; }
    }
}
