using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter weekday");
            string input = Console.ReadLine();

            //valid enum
            //var day = (WeekDay)Enum.Parse(typeof(WeekDay), input);
            if(Enum.TryParse(input, out WeekDay day))
            {
                Console.WriteLine("Success");
            }
       
            Console.Read();
        }
    }
}
