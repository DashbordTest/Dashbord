using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using IS.Dashboard.Common.Entity;

namespace Business
{
    public class IAuthentication
    {
        public IAuthenticationService service;
        public IAuthentication(IAuthenticationService service)
        {
            this.service = service;
        }
        public string tryLogin(string username, string password)
        {
            string tag = "";

            User user = service.findOne(username, password);

            if (user == null)
            {
                tag = "用户名或密码错误";
            }

            else
            {
                tag = "登录成功";
            }
            return tag;
        }
   
    
    }
}
