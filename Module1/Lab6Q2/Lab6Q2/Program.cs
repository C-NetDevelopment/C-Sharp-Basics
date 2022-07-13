using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int ProductId;
                string ProductName;
                double Price;
                ProductMock productMock = new ProductMock();
                Console.WriteLine("-------------------");

                Console.WriteLine("Enter the Product Id :");
                //ProductId =int.Parse(Console.ReadLine());
                string input = Console.ReadLine();
                ProductId = Convert.ToInt32(input);

                Console.WriteLine("Enter the Product Name :");
                ProductName = Console.ReadLine();

                Console.WriteLine("Enter the Price :");
                //Price =double.Parse(Console.ReadLine());
                input = Console.ReadLine();
                Price = Convert.ToDouble(input);

                productMock.productId = ProductId;
                productMock.productName = ProductName;
                productMock.price = Price;
            }
            catch (DataEntryException ex)
            {
                Console.WriteLine(ex.Message);

            }
            Console.ReadLine();

        }
    }
}
