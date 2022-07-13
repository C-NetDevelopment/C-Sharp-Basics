using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLab
{
    public class Contact
    {
        public int ContactNo { get; set; }
        public string ContactName { get; set; }
        public string CellNo { get; set; }

        public Contact()
        {
                
        }

        public override string ToString()
        {
          return  $"Contact No:{ContactNo}, Contact Name:{ContactName}, Cell No: {CellNo}";

        }
    }
}
