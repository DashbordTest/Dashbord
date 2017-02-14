using System;
using IS.Dashboard.Business.SystemSettings;
using IS.Dashboard.Model;

namespace IS.Dashboard.Business.Login
{
    public class AuthenticationBusiness
    {
        public User AuthenticateUser(string userName, string password)
        {
            var ssbBusiness = new SysemSettingBusiness();
            SystemSetting ss = ssbBusiness.FindAuthenticationModel(userName);
            AuthenticationFactory af;
            if (String.Equals(ss.Value, Common.Enums.Enums.AuthenticaionModel.AD.ToString()))
            {
                af = new ADAuthenticationFactory();
            }
            else
            {
                af = new FormAuthenticationFactory();
            }

            Authentication auth = af.Create();

            return auth.Authenticate(userName, password);
        }
    }
}
