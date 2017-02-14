using IS.Dashboard.Model;
using IS.Dashboard.Repository;

namespace IS.DashBoard.Repository
{
    public interface IUserRepository : IRepository<User>
    {
          User FindByUid(string uid,string password);
    }
}
