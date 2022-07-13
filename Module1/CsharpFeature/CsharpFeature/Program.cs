using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFeature
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<double> { 1, 45, 2, 31, 54 };
            //var result = GetAggregateValues(numbers);
            //Console.WriteLine($"Min:{result.Item1}, Max:{result.Item2}," +
            //   $"Average: {result.Item3}");

            var result = GetAggregate(numbers);
            Console.WriteLine($"Min:{result.min}, Max:{result.max}," +
                  $"Average: {result.avg}");
            Console.ReadLine();
        }
        static Tuple<double,double,double> GetAggregateValues(List<double> numbers)
        {
           var result = Tuple.Create(numbers.Min(), numbers.Max(), numbers.Average());
            return result;
        }

        static (double min, double max, double avg) GetAggregate(List<double> numbers)
        {
            return (numbers.Min(), numbers.Max(), numbers.Average());
        }
    }
}
