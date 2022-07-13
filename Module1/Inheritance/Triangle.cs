using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Triangle : Shape
    {
        
        private decimal baseValue;
        private decimal height;

        public Triangle(decimal baseValue, decimal height)
        {
            this.baseValue = baseValue;
            this.height = height;

        }
        public override decimal Area()
        {
            return (decimal)0.5 * baseValue * height;
        }
    }
}
