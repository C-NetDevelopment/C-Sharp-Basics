using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProductDemo.Exception
{
    public class ProductMockException : ApplicationException
    {
        public ProductMockException()
        {
        }

        public ProductMockException(string message) : base(message)
        {
        }

        public ProductMockException(string message, System.Exception innerException) : base(message, innerException)
        {
        }

        protected ProductMockException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
