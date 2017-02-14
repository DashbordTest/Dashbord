using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;

namespace MvcApplication4.models
{
    public class SystemSetting
    {
        public int SettingID { get; set; }
        public string SettingName { get; set; }
        public string CategoryNode { get; set; }
        public string CategoryLevel { get; set; }
        public string Value { get; set; }
        public DateTime DATE = DateTime.Now;
        public DateTime Date
        {
            get { return Date; }
            set { Date = value; }
        }
    }

    public class SystemSettingContext : DbContext
    {
        public DbSet<SystemSetting> SystemSettings { get; set; }
    }

}