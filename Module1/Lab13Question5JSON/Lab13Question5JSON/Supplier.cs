using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Question5JSON
{
    [Serializable]
    public class Supplier
    {
        public int SupplierNo { get; set; }
        public string SupplierName { get; set; }


        public override string ToString() => $"Supplier (No: {SupplierNo}, Name: {SupplierName})";
    }
}
