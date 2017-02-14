using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;

namespace Business
{
    public class FormAuthentication : IAuthentication
    {
        
       public FormAuthentication(IAuthenticationService service): base(service)
        {
            
        }
    }
}
