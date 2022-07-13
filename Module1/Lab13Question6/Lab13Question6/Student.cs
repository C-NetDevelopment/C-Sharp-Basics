using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Question6
{
    [Serializable]
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Degree { get; set; }


        public override string ToString() => $"Student (No: {RollNo}, Name: {Name}, City: {City}, Degree: {Degree})";

    }
}
