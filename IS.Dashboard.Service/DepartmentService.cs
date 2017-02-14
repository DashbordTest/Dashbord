using IS.Dashboard.Common.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IS.Dashboard.Model;
using IS.Dashboard.Common.Entity;

namespace Service
{
    public class DepartmentService
    {
        IRepository<Department> iDepart;
        public DepartmentService()
        {
            if (iDepart == null)
            {
                iDepart = new DepartmentRepository();
            }
        }

        public Department findOne(int userID){
            return iDepart.Find("UserID", userID)[0];
        }

    }
}
