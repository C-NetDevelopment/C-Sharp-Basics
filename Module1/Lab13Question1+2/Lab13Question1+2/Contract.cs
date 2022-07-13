using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Question1_2
{
    [Serializable]
    public class Contract
    {
        public int ContractNo { get; set; }
        public string ContractName { get; set; }
        public string CellNo { get; set; }

        public override string ToString() => $"Contract (No: {ContractNo}, Name: {ContractName}, Cell No: {CellNo})";
    }
}
