using System;

namespace Implementation.Exceptions
{
    public class DataNotAddedException : ApplicationException
    {
        public DataNotAddedException()
        {

        }
        public DataNotAddedException(string message) : base(message)
        {

        }
    }
}
