using IS.Dashboard.Model;

namespace IS.Dashboard.Business.Login
{
    public abstract class Authentication
    {
        public abstract User Authenticate(string userName, string password);
    }
}
