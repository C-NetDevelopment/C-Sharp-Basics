using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Circle : Shape
    {
        private decimal radius;

        public Circle(decimal radius)     //pass value to the base class
        {
            this.radius = radius;
  
        }
        public override decimal Area()
        {
            //pi* r* r;
            return (decimal)Math.PI * radius * radius;
        }
    }
}
