using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using IS.Dashboard.Presentation.Web.App_Start;

namespace IS.Dashboard.Presentation.Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            // XmlConfigurationSource source = new XmlConfigurationSource("MyConfig.xml");
             
        /*  Castle.ActiveRecord.Framework.IConfigurationSource source = System.Configuration.ConfigurationManager.GetSection("activerecord") as Castle.ActiveRecord.Framework.IConfigurationSource;
            Castle.ActiveRecord.ActiveRecordStarter.Initialize(typeof(User).Assembly, source);
            //ActiveRecordStarter.Initialize(source, typeof(ActiveRecordBase)); 
            Castle.ActiveRecord.ActiveRecordStarter.Initialize(typeof(Department).Assembly, source);
            Castle.ActiveRecord.ActiveRecordStarter.Initialize(typeof(UserDepartRelationship).Assembly, source);  */
         }
    }
}