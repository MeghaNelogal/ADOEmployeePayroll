using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

namespace EmployeePayrollADO

{ 
=======
namespace EmployeePayrollADO
{
>>>>>>> UC2-RetrieveFromDatabase
    public class CustomException : Exception
    {
        public enum ExceptionType
        {
            No_data_found, Connection_Failed
        }
        public ExceptionType exceptionType;
        public CustomException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }

    }
}
<<<<<<< HEAD
=======

>>>>>>> UC2-RetrieveFromDatabase
