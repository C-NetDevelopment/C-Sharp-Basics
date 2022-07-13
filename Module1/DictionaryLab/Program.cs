using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //recipe id, name
            Dictionary<int, string> recipe = new Dictionary<int, string>();
            recipe.Add(1, "Maggi");
            recipe.Add(2, "PuranPoli");
            recipe.Add(3, "Dal");
            recipe.Add(4, "chicken");
            recipe.Add(5, "Cake");

            
            // recipe.Add(4,"ooki");   throw an error
            // recipe[4] = "koki";     override the first value


            foreach  (KeyValuePair<int, string> item in recipe)
            {
                Console.WriteLine($"{item}\t{item.Value}");
            }

            recipe.Count();
            if (recipe.ContainsKey(3))
            {
               Console.WriteLine(recipe);
            }
            Console.WriteLine("Enter Recipe id:");
            string input = Console.ReadLine();
            int recipeId = Convert.ToInt32(input);

            if (recipe.ContainsKey(recipeId))
            {
                Console.WriteLine(recipe[recipeId]);
            }else
                {
                Console.WriteLine("not found");
            }
            Console.ReadLine();
        }

        /*public string Value(Dictionary<int, string> dict)
        {
            foreach (KeyValuePair<int, string> item in dict)
            {
                return $"{dict.Keys} {dict.Values}";
            }
            
        }

        public string Values(Dictionary<int, string> dict)
        {
            foreach (KeyValuePair<int, string> item in dict)
            {
                return $" {item.Key} {item.Value} ";
            }
            return $"{k}";
        }*/
    }
}
