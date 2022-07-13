using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Question1
{
    class Program
    {
        static Hashtable rTOHash;
        public static void Main(string[] args)
        {
             rTOHash = new Hashtable();
            do
            {
                Console.WriteLine("1. Add Record\n" +
                                  "2. Search Record\n" +
                                  "3. Display All Records\n" +
                                  "4. Display Count\n" +
                                  "5. Delete Record\n" +
                                  "6. Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddRecord(rTOHash);
                            break;
                        case 2:
                            SearchRecord(rTOHash);
                            break;
                        case 3:
                            DisplayRecord(rTOHash);
                            break;
                        case 4:
                            CountRecord(rTOHash);
                            break;
                        case 5:
                            DeleteRecord(rTOHash);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }

            } while (true);
        }

        private static void DeleteRecord(Hashtable rTOHash)
        {
            Console.WriteLine("Enter Key to delete record");
            var key = Console.ReadLine();
            rTOHash.Remove(key);
        }

        private static void CountRecord(Hashtable rTOHash)
        {
            Console.WriteLine(rTOHash.Count);
        }

        private static void DisplayRecord(Hashtable rTOHash)
        {
            foreach (DictionaryEntry entry in rTOHash)
            {
                Console.WriteLine("Key: "+ entry.Key + "Value: "+ entry.Value);
            }
        }

        private static void SearchRecord(Hashtable rTOHash)
        {
            Console.WriteLine("Enter Key to search value");
            var key = Console.ReadLine();
            if (rTOHash.ContainsKey(key))
            {
                Console.WriteLine(rTOHash[key]);
            }
            else
            {
                Console.WriteLine("Record Not Found");
            }
        }

        private static void AddRecord(Hashtable rTOHash)
        {
            Console.WriteLine("Enter Key");
            var key = Console.ReadLine();

            Console.WriteLine("Enter Value");
            var value = Console.ReadLine();
            rTOHash.Add(key, value);
            
        }
    }
}
