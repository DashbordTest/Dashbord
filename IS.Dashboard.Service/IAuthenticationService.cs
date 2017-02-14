using IS.Dashboard.Common.Entity;
using IS.Dashboard.Model;

namespace IS.Dashboard.Service
{
    public interface IAuthenticationService
    {
         User FindOne(string userName, string password);
    }
}