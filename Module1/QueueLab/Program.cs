using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue games = new Queue();
            games.Enqueue("Football");
            games.Enqueue("Cricket");
            games.Enqueue("Kabaddi");
            games.Enqueue("BasketBall");
            games.Enqueue(123);
            var item1 = games.Dequeue();
            Console.WriteLine(item1);


            foreach (var item in games)
            {
                Console.WriteLine(item);
            }

            



            Console.ReadLine();
        }
    }
}
