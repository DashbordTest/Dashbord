using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS.Dashboard.Common.CustomExceptions
{
    public class ManagementException : ISDashboardExceptionBase
    {
        public ManagementException(Type entitysType, Exception inner)
            : base(entitysType.Name + "表存在异常", inner)
        {

        }
    }

    public class PermissionsException : ISDashboardExceptionBase
    {
        public PermissionsException(string message)
            : base(message)
        {

        }
    }

    public class LoginUserException : ISDashboardExceptionBase
    {
        public LoginUserException()
            : base("当前用户不存在!或者密码错误!")
        {
        }
    }

    public class ReportViewException : ISDashboardExceptionBase
    {
        public ReportViewException()
            : base("你没有对于当前报表查看的权限!")
        {
        }
    }

    public class ExecuteReportSSISException : ISDashboardExceptionBase
    {
        public ExecuteReportSSISException(string reportName, Exception e)
            : base(reportName + "ssis 执行异常", e)
        {
        }
    }
}
