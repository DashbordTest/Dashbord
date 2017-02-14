using IS.Dashboard.Model;
using IS.Dashboard.Service;

namespace IS.Dashboard.Business.Login
{
    public class FormAuthentication : Authentication
    {
        
       //public FormAuthentication(IAuthenticationService service): base(service)
       // {
            
       // }

        //public User TryLogin(string userName, string password)
        //{
        //    return new User() {FirstName = "Test", LogOnName = userName};
        //    //string tag = "";

        //    //User user = new IS.Dashboard.Service().findOne(username, password);

        //    //if (user == null)
        //    //{
        //    //    tag = "用户名或密码错误";
        //    //}

        //    //else
        //    //{
        //    //    tag = "登录成功";
        //    //}
        //    //return tag;
        //}

        public override User Authenticate(string userName, string password)
        {
            //return new User() { FirstName = "Test", LogOnName = userName };
            return new FormAuthenticationService().FindOne(userName, password);
        }
    }
}
