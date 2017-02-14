using IS.Dashboard.Model;
using IS.Dashboard.Repository;

namespace IS.Dashboard.Service
{
   public class ADAuthenticationService : IAuthenticationService
    {
        //IUserRepository user;
        //public ADAuthenticationService()
        //{
        //    if (user == null)
        //    {
        //        user = new UserRepository();
        //    }
          
        //}
    
        public User FindOne(string userName, string password)
        {
            //return new UserRepository().FindByUid(userName, password);
            return null;
        }
    }
}
