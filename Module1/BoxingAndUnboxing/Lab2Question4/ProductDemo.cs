using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Question4
{
    class ProductDemo
    {
        public int productId;
        public string productName;
        public decimal price;
        public decimal quantity;
        

        public ProductDemo(int productId, string productName, decimal price,
        decimal quantity)
        {
            this.productId = productId;
            object obj1 = productId;
            this.productName = productName;
            object obj2 = productName;
            this.price = price;
            object obj3 = price;
            this.quantity = quantity;
            object obj4 = quantity;
        }

        public decimal AmountPayble()
        {
            return price * quantity;
        }

        public void Display()
        {
            Console.Write($"Product Id: {productId}\n" +
                $"Product Name: {productName}\n" +
                $"Price Of Product: {price}\n" +
                $"Qauntity of Product: {quantity}\n");
        }
    }
}
