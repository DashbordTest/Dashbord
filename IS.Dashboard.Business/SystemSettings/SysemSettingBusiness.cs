using IS.Dashboard.Common;
using IS.Dashboard.Common.Enums;
using IS.Dashboard.Service.SystemSetting;

namespace IS.Dashboard.Business.SystemSettings
{
    internal class SysemSettingBusiness
    {
        internal Model.SystemSetting FindAuthenticationModel(string username)
        {
            return new SystemSettingService().FindByPropertyAndValue(Const.SystemSettingName,
                username); 
        }

        internal Model.SystemSetting FindADInfo()
        {
            return new SystemSettingService().FindByPropertyAndValue(Const.SystemSettingName,
                Enums.SystemSettingName.ADServer.ToString());
        }
    }
}
