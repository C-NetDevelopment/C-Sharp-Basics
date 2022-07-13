using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
            list.Add(true);
            list.Add(12.2);
            list.Add("Hellod");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine($"Capacity:{list.Capacity}");
            Console.WriteLine($"Capacity:{list.Count}");
            //list.Remove();
            Console.ReadLine();
        }
    }
}
