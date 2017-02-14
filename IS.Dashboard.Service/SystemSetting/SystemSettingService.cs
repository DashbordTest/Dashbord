using System.Linq;
using IS.Dashboard.Repository;

namespace IS.Dashboard.Service.SystemSetting
{
    public class SystemSettingService
    {
        public Model.SystemSetting FindByPropertyAndValue(string property, string value)
        {           
            return new BaseRepository<Model.SystemSetting>().Find(property, value).First();
        }
    }
}
