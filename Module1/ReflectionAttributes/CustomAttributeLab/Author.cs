using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeLab
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class Author: Attribute
    {
        //positional parameter  take it as input in ctor | pp are private fields | madotory
        string name;

        public Author(string name)
        {
            this.name = name;
        }
        //named parameter    | public properties | optional
        public string Bio { get; set; }

        public string GetName()
        {
            return name;
        }
    }
}
