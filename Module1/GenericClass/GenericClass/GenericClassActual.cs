using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass   //generic class allow us to specify the type while creating instance of that class
{
    class GenericClassActual<T>  //specify type in angle bracket 
    {
        T name;
        public void Method1(T value)
        {

        }
    }
}
