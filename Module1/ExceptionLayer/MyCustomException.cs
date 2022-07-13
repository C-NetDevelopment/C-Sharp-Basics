using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLayer
{
    public class MyCustomException : ApplicationException
    {
        public MyCustomException()
        {
        }

        public MyCustomException(string message) : base(message)
        {
        }

        public MyCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
