using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            //menu 
            Console.WriteLine("1 Circle, 2 Rectangle, 3 Tringle, 4 Square");
            string input = Console.ReadLine();
            int shape = Convert.ToInt32(input);

            switch (shape) {
                case 1:
                    Console.WriteLine("Enter radius");
                    input = Console.ReadLine();
                    decimal radius = Convert.ToDecimal(input);
                    Circle circleObj = new Circle(radius);
                    decimal area = circleObj.Area();
                    Console.WriteLine($"Area of circle:{area}");
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("Enter Length");
                    input = Console.ReadLine();
                    decimal length = Convert.ToDecimal(input);
                    Console.WriteLine("Enter Breadth");
                    input = Console.ReadLine();
                    decimal breadth = Convert.ToDecimal(input);

                    Rectangle rectangleObj = new Rectangle(length, breadth);
                    area = rectangleObj.Area();
                    Console.WriteLine($"Area of Rectangle:{area}");
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("Enter Base Value");
                    input = Console.ReadLine();
                    decimal baseValue = Convert.ToDecimal(input);

                    Console.WriteLine("Enter Height");
                    input = Console.ReadLine();
                    decimal height = Convert.ToDecimal(input);

                    Triangle triangleObj = new Triangle(baseValue, height);
                    area = triangleObj.Area();
                    Console.WriteLine($"Area of Triangle:{area}");
                    Console.Read();
                    break;

                case 4:
                    Console.WriteLine("Enter Length of the side of Square");
                    input = Console.ReadLine();
                    decimal lengthOfSide = Convert.ToDecimal(input);
                    Square squareObj = new Square(lengthOfSide);
                    area = squareObj.Area();
                    Console.WriteLine($"Area of Square:{area}");
                    Console.Read();
                    break;
                default:
                    break;

            }


           




        }
    }
}
