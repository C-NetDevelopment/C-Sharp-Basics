using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Question5
{
    class BookDemo
    {
        private string[] colName = { "BookTitle", "Author", "Publisher", "Price" };
        private string[,] bookDetails = new string[2, 4];

       //default constructor ......


        //method to read the books details which is entered by user
        public void BooksDetails()
        {
            Console.WriteLine("Books Record");
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < colName.Length; i++)
                {
                    Console.Write("Enter {0}: ", colName[i]); //here {0} indicating col or key 
                    bookDetails[j, i] = Console.ReadLine();
                }
                Console.Write("\n");
            }
        }

        // method to display the stored details
        public void DisplayBooks()
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < colName.Length; i++)
                {
                    Console.Write("{0}: {1}\n", colName[i], bookDetails[j, i]);  //"{0}: {1}\n" indicating key and value
                }
                Console.Write("\n");


            }
        }
    }
}
