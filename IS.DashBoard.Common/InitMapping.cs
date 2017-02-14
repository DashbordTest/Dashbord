using System.Configuration;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework;
using System.Linq;
using IS.Dashboard.Model;


namespace IS.DashBoard.Common
{
    public static class InitMapping
    {
        private static readonly object StaticLock = new object();

        public static void Init()
        {
            lock (StaticLock)
            {
                ActiveRecordStarter.ResetInitializationFlag();
                const string sectionName = "activerecord";

                var source = ConfigurationManager.GetSection(sectionName) as IConfigurationSource;
                if (source == null)
                {
                    throw new ConfigurationErrorsException("缺少数据库配置 - " + sectionName);
                }
                var typeList = typeof(BaseModel).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(BaseModel)));
                ActiveRecordStarter.Initialize(source, typeList.ToArray());
            }
        }
    }
}
