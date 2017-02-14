using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using dashboard.Models;


namespace Business
{
    public class ADAuthentication : IAuthentication
    {
        public ADAuthentication(IAuthenticationService service)
            : base(service)
        {

        }
    }
}

