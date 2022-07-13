using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.IsClass)
                {
                    Console.WriteLine($"Class:  {type.Name}");
                    var attributes = Attribute.GetCustomAttributes(type);

                    foreach (var attr in attributes)
                    {
                        if (attr is Author author)
                        {
                            Console.WriteLine($"Author name: {author.GetName()}," +
                                $"Bio: {author.Bio}");
                        }
                        
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
