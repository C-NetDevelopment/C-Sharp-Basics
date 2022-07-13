using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var taskA = new Task(()=> Console.WriteLine("Hello form Task"));
            taskA.Start();
            Console.WriteLine("Hello from main");
            Console.ReadLine();
        }
    }
}
