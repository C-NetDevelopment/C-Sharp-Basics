using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Square : Shape
    {
        private decimal lengthOfSide;

        public Square(decimal lengthOfSide)
        {
            this.lengthOfSide = lengthOfSide;
        }

        public override decimal Area()
        {
            return lengthOfSide * lengthOfSide;
        }
    }
}
