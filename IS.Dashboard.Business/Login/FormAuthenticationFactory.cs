using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Dashboard.Business.Login
{
    public class FormAuthenticationFactory : AuthenticationFactory
    {
        public override Authentication Create()
        {
            return new FormAuthentication();
        }
    }
}
