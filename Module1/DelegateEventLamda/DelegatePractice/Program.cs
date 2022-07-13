using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    public delegate void HandlerDelegate(int x, int y);
    public delegate void SayDelegate(string Name);
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.AddNums(10,20);

            //string sr = Program.SayHello("Saurabh");

            HandlerDelegate ad = new HandlerDelegate(p.AddNums);
            ad.Invoke(21,20);

            SayDelegate sd = new SayDelegate(SayHello);  //staatic method direct call
            sd("saurabh");

            HandlerDelegate obj = p.AddNums;
            Console.ReadLine();
        }

        public void AddNums(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public static void SayHello(string Name)
        {
            Console.WriteLine($" Hello {Name}");
           
        }
    }
}
