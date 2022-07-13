using ProductDemo.Exception;
using ProductMock.Entities;
using System;
using 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductMock.BL;

namespace ProductMock.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("--------Product Details---------");
                Console.WriteLine("1. Add Product\n" +
                                  "2. List Product\n" +
                                  "3. Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddProduct();
                            break;
                        case 2:
                            //ListProduct();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            } while (true);
        }

        private static void AddProduct()
        {
            Product product = new Product();
            Console.WriteLine("Enter Product Id");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int prodId))
            {
                product.ProductId = prodId;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            try
            {
                bool isAdded = ProductMockBL.AddProduct(product);
                if (isAdded)
                {
                    Console.WriteLine("Product Added Successfully");
                }
                else
                {
                    Console.WriteLine("emp failed");
                }
            }
            catch (ProductMockException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
