using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service;
using IS.Dashboard.Common.Entity;

namespace Business
{
    public class DepartmentSearch
    {
        DepartmentService departService;
        public DepartmentSearch()
        {
            if (departService == null)
            {
                departService = new DepartmentService();
            }
        }

        public  Department findOne(int userID){

            return departService.findOne(userID);
}
    }
}
