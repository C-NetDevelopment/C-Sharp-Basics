using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLab
{
    partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public City City { get; internal set; }

        
    }
}
