using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDemo booksDemo = new BookDemo();

            booksDemo.BooksDetails();
            booksDemo.DisplayBooks(); ;

            Console.ReadLine();
        }
    }
}
