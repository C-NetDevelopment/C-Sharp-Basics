using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisher = new Publisher();     //object for bublisher


            Subscriber subscriber1 = new Subscriber();  //object for subscriber1 2 
            Subscriber subscriber2 = new Subscriber();

            publisher.Log += subscriber1.Logger;
            publisher.Log += subscriber2.Logger;

            publisher.FireEvent("Event raised");
            Console.Read();
        }
    }
}
