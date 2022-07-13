using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLab
{
    public delegate void LogHandler(string message);
    class Publisher
    {
        public event LogHandler Log = null;

        public void FireEvent(string message)
        {
            if (Log !=null)
            {
                Log(message);
            }
            
        }
    }
}
