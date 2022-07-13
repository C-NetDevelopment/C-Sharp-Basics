using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Question2
{
    class Program
    {
        static List<Product> productList = new List<Product>();
        static Product product = new Product();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("1. Add Product\n" +
                                  "2. Delete Product\n" +
                                  "3. Search Product\n" +
                                  "4. Exit");
                string input =Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddProduct(product);
                            break;
                        case 2:
                            DeleteProduct(product);
                            break;
                        case 3:
                            SearchProduct(product);
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            } while (true);
        }

        private static void SearchProduct(Product product)
        {
            Console.WriteLine("Enter Product Number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int prodNo))
            {
                var isExist = productList.Find(e => e.ProductNo == prodNo);
                if (isExist == null)
                {
                    Console.WriteLine("Record Not Found");
                }
                else
                {
                    Console.WriteLine(isExist);
                }
            }
        }

        private static void DeleteProduct(Product product)
        {
            Console.WriteLine("Enter Product Number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int prodNo))
            {
                var isExist = productList.Find(e => e.ProductNo == prodNo);
                if (isExist == null)
                {
                    Console.WriteLine("Record Not Found");
                }
                else
                {
                    productList.Remove(isExist);
                }
            }
        }

        private static void AddProduct(Product product)
        {
            Console.WriteLine("Enter Product Number");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int prodNo))
            {
                product.ProductNo = prodNo;

                Console.WriteLine("Enter Product Name");
                product.ProductName = Console.ReadLine();

                Console.WriteLine("Enter Product Rate");
                product.ProductRate = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Product Stock");
                product.ProductStock = double.Parse(Console.ReadLine());

                productList.Add(product);
                productList.Sort();
            }
            else{
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
