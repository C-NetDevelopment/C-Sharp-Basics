using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Question2
{
    class Program
    {
       static Hashtable hashtable = new Hashtable();
        static void Main(string[] args)
        {
            GetHashtable();
            
            if (hashtable.Contains("Perimeter"))
            {
                Console.WriteLine("Key is Present in HashTable");
            }
            else
            {
                Console.WriteLine("Key not present");
            }
            if (hashtable.Contains("Area"))
            {
                Console.WriteLine(hashtable["Area"]);
            }
            else
            {
                Console.WriteLine("Key is not present");
            }


            hashtable.Remove("Mortgage");
            Console.ReadLine();
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Key:{entry.Key}, Value:{entry.Value}");
            }
        }
        static Hashtable GetHashtable()
        {
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }
    }
}
