using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question2Event
{
    class Program
    {
        static void Main(string[] args)
        {
            FileDownloader fd = new FileDownloader("http://www.microsoft.com/vstudio/expressv10.zip",
 "D:\\setups");
            //Register Event Handler
            fd.DownLoadComplete += DownLoadComplete;
            //Start the task...
            fd.DownLoadResource();
            Console.ReadKey();
        }

        static void DownLoadComplete(int perc)
        {
            Console.SetCursorPosition(1, 1);
            Console.Write("Downloading {0} Percent Complete", perc);
        }
    }
}
