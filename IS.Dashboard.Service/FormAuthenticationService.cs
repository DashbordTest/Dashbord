using IS.Dashboard.Common.Entity;
using IS.Dashboard.Model;
using IS.Dashboard.Repository;
using System.Linq;

namespace IS.Dashboard.Service
{
    public class FormAuthenticationService:IAuthenticationService
    {
        //IRepository<User> iuser;
        //public FormAuthenticationService()
        //{
        //    if (iuser == null)
        //    {
        //        iuser = new UserRepository();
        //    }
             
        //}

        public User FindOne(string userName,string password)
        {
            User user = new UserRepository().Find("LogOnName", userName).First();
            if (user.Password != password)
            {
                return null;
            }
            return user;
        }
        		
    }
}
