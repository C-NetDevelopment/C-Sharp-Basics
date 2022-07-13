using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLabPractice
{
    public delegate void LogHandler(string message);
    class EventP
    {
        public event LogHandler Alert = null;

        public void FireEvent(string message)
        {
            if (Alert != null)
            {
                Alert(message);
            }

        }
        static void Main(string[] args)
        {
            EventP pub = new EventP();

            EventS sub1 = new EventS();

            pub.Alert += sub1.Alerting;

            pub.FireEvent("Event Get fired");
            Console.Read();
        }
    }

    public class EventS
    {
        public void Alerting(string message)
        {
            Console.WriteLine(message);
        }
    }
}
