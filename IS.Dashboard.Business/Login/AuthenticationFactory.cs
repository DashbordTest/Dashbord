using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Dashboard.Business.Login
{
    public abstract class AuthenticationFactory
    {
        public abstract Authentication Create();
    }
}
