using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class BussinessClass
    {
        public static void Method1()
        {
            throw new MyCustomException("Database problem");     // throwing an exe
        }
    }
}
