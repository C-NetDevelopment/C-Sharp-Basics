using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLab
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            List<string> fruitList = new List<string>();
            fruitList.Add("Mango");
            fruitList.Add("Apple");
            fruitList.Add("Strawberry");
            fruitList.Add("Watermelon");
            fruitList.Sort();

            var arList = new ArrayList()
            {
                "saurabh", 1212, true, false
            };

            arList.InsertRange(1, fruitList);

            arList.RemoveRange(1,5);
            arList.Insert(2, "saurabh");
            arList.Add(511);
            arList.Add("Cotton");
            foreach (var item in arList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine(fruitList.Count());

            for (int i = 0; i < fruitList.Count; i++)
            {
                Console.WriteLine(fruitList[i]);
            }

            foreach (string item in fruitList)
            {
                Console.WriteLine(item);
            }

            */

            Hashtable ht = new Hashtable();

            ht.Add(1, "Saurabh");
            ht.Add(2, "Nikam");
            ht.Add(3,"data");
            ht.Add(5,"dering");
            
            if (ht.ContainsKey(2))
            {
                Console.WriteLine(ht[2]);
            }
            ICollection key = ht.Keys;

            foreach (var K in key)
            {
                Console.WriteLine(ht[K]);
            }
            Console.ReadLine();
        }
    }
}
