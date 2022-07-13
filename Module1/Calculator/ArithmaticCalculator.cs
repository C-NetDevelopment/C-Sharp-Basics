using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ArithmaticCalculator
    {
        private decimal Num1;
        private decimal Num2;

        public ArithmaticCalculator(decimal Num1, decimal Num2)
        {
            this.Num1 = Num1;
            this.Num2 = Num2;
            
        }

        public decimal Addition()
        {
            return Num1 + Num2;
        }
        public decimal Subtract()
        {
            return Num1 - Num2;
        }
        public decimal Multiplication()
        {
            return Num1 * Num2;
        }
        public decimal Devision()
        {
            return Num1 / Num2;
        }

        public decimal Modulus()
        {
            return Num1 % Num2;
        }
    }
}
