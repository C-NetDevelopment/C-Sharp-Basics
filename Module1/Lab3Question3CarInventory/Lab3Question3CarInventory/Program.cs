using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Question3CarInventory
{
    class Program
    {
        static void Main(string[] args)
        {


            Car[] cars = new Car[100];

            int totalCars = 0;

            int carNo;
            string make;
            string model;
            int year;
            double salePrice;

            Console.WriteLine("-------------Car Inventory Menu-------------\n");
            Console.WriteLine("1. Add new Car\n" +
                              "2. Modify Car DEtail\n" +
                              "3. Search Car\n" +
                              "4. Car List\n" +
                              "5. Delete\n" +
                              "6. Exit\n");

            Console.WriteLine("Please select option from menu\n");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("------Enter Make");
                    make = Console.ReadLine();
                    Console.WriteLine("------Enter model");
                    model = Console.ReadLine();
                    Console.WriteLine("------Enter Year");
                    year = int.Parse(Console.ReadLine());
                    Console.WriteLine("------Enter Price of Car");
                    salePrice = double.Parse(Console.ReadLine());
                    cars[totalCars] = new Car(make, model, year, salePrice);
                    totalCars++;
                    break;
                case 2:
                    if (totalCars > 0)
                    {
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}", "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i < totalCars; i++)
                        {
                            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}",
                                (i + 1), cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                            Console.Write("Enter car number you want to edit: ");
                            carNo = int.Parse(Console.ReadLine());
                            carNo--;

                            if (carNo >= 0 && carNo > totalCars)
                            {
                                Console.Write("Enter new make");
                                make = Console.ReadLine();
                                Console.Write("Enter new model ");
                                model = Console.ReadLine();
                                Console.Write("Enter new year");
                                year = int.Parse(Console.ReadLine());
                                Console.Write("Enter new price ");
                                salePrice = double.Parse(Console.ReadLine());
                                cars[carNo] = new Car(make, model, year, salePrice);
                                Console.WriteLine("\nDetails for new car has been updated.\n");
                                Console.Read();
                            }
                            else
                            {
                                Console.WriteLine("Select Correct car number");
                            }
                        }
                    }
                    break;
                case 3:
                    if (totalCars > 0)
                    {
                        Console.WriteLine("Enter make or model of car to search car");
                        make = Console.ReadLine();
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}",
                            "ID", "Make", "Model", "Year", "Sale Price");

                        for (int i = 0; i < totalCars; i++)
                        {
                            bool isSearch = false;
                            if (cars[i].Make.CompareTo(make) == 0 || cars[i].Model.CompareTo(make) == 0)
                            {
                                Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}",
                                    (i + 1),
                                    cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                                isSearch = true;
                            }
                            if (isSearch == false)
                            {
                                Console.WriteLine("Car for this make or model Not exist");
                            }
                        }
                    }
                    break;
                case 4:
                    if (totalCars > 0)
                    {
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}",
                            "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i < totalCars; i++)
                        {
                            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}",
                                (i + 1),
                                cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                        }
                    }
                    break;
                case 5:
                    if (totalCars > 0)
                    {
                        Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}",
                            "ID", "Make", "Model", "Year", "Sale Price");
                        for (int i = 0; i < totalCars; i++)
                        {
                            Console.WriteLine("{0,10}{1,15}{2,15}{3,15}{4,15}",
                                (i + 1),
                                cars[i].Make, cars[i].Model, cars[i].Year, cars[i].SalePrice);
                        }
                        Console.Write("Enter Car Number of car you want to delete ");
                        carNo = int.Parse(Console.ReadLine());
                        carNo--;
                        if (carNo >= 0 && carNo < totalCars)
                        {
                            for (int i = carNo; i < totalCars - 1; i++)
                            {
                                cars[i] = cars[i + 1];
                            }
                            totalCars--;
                            Console.WriteLine("Selected car has been deleted.");
                        }
                        else
                        {
                            Console.WriteLine("\nSelect correct Car Number.\n");
                        }
                    }
                    Console.ReadLine();
                    break;
                case 6:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please select correct menu");
                    break;
            }
        }
    }
}
