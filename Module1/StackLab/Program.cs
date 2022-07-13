using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack studentName = new Stack();
            studentName.Push("SAurabh");
            studentName.Push("Kiran");
            studentName.Push("Sai");
            studentName.Push("Sidhesh");
            Console.WriteLine($"{studentName.Peek()}");
            

            //var stud = studentName.Pop();
            // Console.WriteLine(stud);
            foreach (var name in studentName)
            {
                Console.WriteLine($"{name}\t");
            }

            Stack<string> mystack = new Stack<string>();
            mystack.Push("kay");
            Console.ReadLine();

        }
    }
}
