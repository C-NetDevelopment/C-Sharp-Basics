using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add()
            //creating class and creating instance from that class
            GenericClassActual<string> generic = new GenericClassActual<string>();
            generic.Method1("de");
            GenericClassActual<int> generic1 = new GenericClassActual<int>();
            generic1.Method1(1);
        }
    }
}
