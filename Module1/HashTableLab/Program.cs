`using System;
using System.Collections;

namespace HashTableLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable users = new Hashtable();
            users.Add(1,"Saurabh");
            users.Add(2,"Sona");
            users[3] = "krishna";
            users[4] = "krishnappa";

            //users.Remove(2);

            //bool result = users.Contains(2);

            Console.WriteLine("Keys and Values");
            foreach (DictionaryEntry item in users)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
                
            }
            Console.WriteLine("Enter User Id");
            string input = Console.ReadLine();
            int userId = Convert.ToInt32(input);

            if (users.ContainsKey(userId))
            {
                Console.WriteLine(users[userId]);
            }
            else
            {
                Console.WriteLine("user not found");
            }
            Console.ReadLine();
        }
    }
}
