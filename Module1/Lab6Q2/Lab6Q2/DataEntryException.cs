using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q2
{
    class DataEntryException:Exception
    {
        public DataEntryException()
        {
        }

        public DataEntryException(string message) : base(message)
        {
        }
    }
}
