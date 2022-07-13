using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Rectangle : Shape
    {
        private decimal length;
        private decimal breadth;

        public Rectangle(decimal length, decimal breadth)
        {
            this.length = length;
            this.breadth = breadth;

        }
        public override decimal Area()
        {
            return length * breadth;
        }
    }
}
