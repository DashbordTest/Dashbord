using System;
using System.Configuration;
using System.DirectoryServices;
using IS.Dashboard.Model;
using IS.DashBoard.Repository;

namespace IS.Dashboard.Repository
{
    public class UserRepository: BaseRepository<User>,IUserRepository
    {
        public User FindByUid(string uid, string password)
        {
           string strServerDns = "LDAP://" + ConfigurationManager.AppSettings["ServerDNS"] + "/ou=People,o=hp.com";

            string userName = string.Format("uid={0},ou=People,o=hp.com", uid);
            var user = new User();
            var objDirEntry = new DirectoryEntry(strServerDns, userName, password, AuthenticationTypes.None);
            try
            {
                var searcher = new DirectorySearcher(objDirEntry) { Filter = "(uid=" + uid + ")" };
                searcher.PropertiesToLoad.Add("hpLegalName");

                SearchResultCollection results = searcher.FindAll();
                foreach (SearchResult result in results)
                {
                    user.FirstName = result.Properties["hpLegalName"][0].ToString();
                    user.LogOnName = uid;
                }
            }
            catch (DirectoryServicesCOMException e)//服务器不处理该请求
            {
                throw new Exception("LDAP内部错误，请联系管理员", e);
            }

            return user;

        }
    }
} 
