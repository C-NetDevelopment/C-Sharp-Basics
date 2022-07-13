using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Question2
{
    public class Product
    {
        public int ProductNo { get; set; }
        public string ProductName { get; set; }
        public double ProductRate { get; set; }
        public double ProductStock { get; set; }

        public override string ToString()
        {
            return $"ProductNo:{ProductNo}, ProductName:{ProductName}," +
                $"ProductRate:{ProductRate}, ProductStock:{ProductStock}"; 
        }
    }
}
