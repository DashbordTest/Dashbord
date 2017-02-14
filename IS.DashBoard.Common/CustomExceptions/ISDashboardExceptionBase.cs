using System;

namespace IS.Dashboard.Common.CustomExceptions
{
    public class ISDashboardExceptionBase : ApplicationException
    {
        public ISDashboardExceptionBase(string message, Exception inner)
            : base(message, inner)
        { }

        public ISDashboardExceptionBase(string message)
            : base(message)
        { }
    }
}
