using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionLab
{
    static class Extensions
    {
        public static int ToNumber(this string str)
        {
            return Convert.ToInt32(str);
        }
    }
}
