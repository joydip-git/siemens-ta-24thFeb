using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Exceptions
{
    public class DepartmentDaoException : ApplicationException
    {
        public DepartmentDaoException()
        {

        }
        public DepartmentDaoException(string message) : base(message)
        {

        }
        public DepartmentDaoException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
