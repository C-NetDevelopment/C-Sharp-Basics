using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Product Details");

            Console.WriteLine("Enter Product id:");
            string input = Console.ReadLine();
            int productId = Convert.ToInt32(input);

            Console.WriteLine("Enter Product Name:");
            string productName = Console.ReadLine();

            Console.WriteLine("Enter Prcie");
            input = Console.ReadLine();
            decimal price = Convert.ToDecimal(input);

            Console.WriteLine("Enter Quantity");
            input = Console.ReadLine();
            decimal quantity = Convert.ToDecimal(input);

            ProductDemo productRecord = new ProductDemo(productId, productName, price,
         quantity);
            Console.WriteLine("Product Details:");
            productRecord.Display();
            ProductDemo amntObj = new ProductDemo(productId, productName, price,
         quantity);
            Console.WriteLine("Amount Payble: "+ amntObj.AmountPayble());
            Console.ReadLine();
        }
        
    }
}
