using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class DivideMethodException : ApplicationException
    {
        private string message;
        private Exception actualException;

        public DivideMethodException()
        {

        }
        public DivideMethodException(string errorMessage) //: base(errorMessage)
        {
            this.message = errorMessage;
        }
        public DivideMethodException(string errorMessage, Exception ex) //: base(null, ex)
        {
            this.message = errorMessage;
            this.actualException = ex;
        }
        public Exception ActualException
        {
            get { return actualException; }
        }
        public override string Message
        {
            get { return message; }
        }
    }
}
