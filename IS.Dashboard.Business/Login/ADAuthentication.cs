using System;
using System.DirectoryServices;
using IS.Dashboard.Business.SystemSettings;
using IS.Dashboard.Common.CustomExceptions;
using IS.Dashboard.Model;

namespace IS.Dashboard.Business.Login
{
    public class ADAuthentication : Authentication
    {
        public override User Authenticate(string userName, string password)
        {
            var ssb = new SysemSettingBusiness();
            var ss = ssb.FindADInfo();
            
            if (Equals(ss, null)) return null;

            string strServerDns = "LDAP://" + ss.Value + "/ou=People,o=hp.com";
            string filter = string.Format("uid={0},ou=People,o=hp.com", userName);
            User user = null;
            var objDirEntry = new DirectoryEntry(strServerDns, filter, password, AuthenticationTypes.None);
            try
            {
                var searcher = new DirectorySearcher(objDirEntry) { Filter = "(uid=" + userName + ")" };
                searcher.PropertiesToLoad.Add("hpLegalName");

                SearchResultCollection results = searcher.FindAll();
                foreach (SearchResult result in results)
                {
                    user = new User
                    {
                        FirstName = result.Properties["hpLegalName"][0].ToString(),
                        LogOnName = userName
                    };
                }
            }
            catch
                (DirectoryServicesCOMException)
            {
                throw new LoginUserException();
            }
            catch (Exception e)
            {
                throw new Exception("LDAP内部错误，请联系管理员", e);
            }
            return user;
        }
    }
}