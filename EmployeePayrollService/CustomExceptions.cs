using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    public class CustomExceptions : Exception
    {
        public ExceptionType exception;

        public enum ExceptionType
        {
            NOT_ADDED
        }

        public CustomExceptions(string message, ExceptionType exception) : base(message)
        {
            this.exception = exception;
        }
    }
}
