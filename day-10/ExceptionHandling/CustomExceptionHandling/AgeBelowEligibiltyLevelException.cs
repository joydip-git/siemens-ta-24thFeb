using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandling
{
    class AgeBelowEligibiltyLevelException : ApplicationException
    {
        string message;
        public AgeBelowEligibiltyLevelException()
        {

        }
        public AgeBelowEligibiltyLevelException(string message) //: base(message)
        {
            this.message = message;
        }
        //public override string Message
        //{
        //    get { return message; }
        //}
        //public override string Message
        //{
        //    get => message;
        //}
        public override string Message => message;
    }
}
