using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Participent
    {
        private int empId;
        public int EmpId { get { return empId; } set { empId = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private static string companyName;
        public static string CompanyName { get { return companyName; } set { companyName = value; } }

        private int foundationMarks;
        public int FoundationMarks
        {
            get { return foundationMarks; }
            set
            {
                if (value < 0 && value > 100)
                {
                    foundationMarks = 0;
                    Console.Write("Please Enter marks between 0 to 100");
                }
                foundationMarks = value; 
            }
        }

        private int webBasicMarks;
        public int WebBasicMarks 
        { 
            get { return webBasicMarks; } 
            set 
            {
                if (value < 0 && value > 100)
                {
                    webBasicMarks = 0;
                    Console.WriteLine("Please Enter marks between 0 to 100");
                }
                webBasicMarks = value; 
            } 
        }

        private int dotNetMarks;
        public int DotNetMarks 
        { 
            get { return dotNetMarks; } 
            set 
            {
                if (value < 0 && value > 100)
                {
                    dotNetMarks = 0;
                    throw new ArgumentNullException("Please Enter marks between 1 to 100");
                }
                else
                {
                    dotNetMarks = value;
                }
            } 
        }

        private const int totalMarks = 300;
        public int TotalMarks
        {
            get { return totalMarks; }
        }

        private int obtainMarks;
        public int ObtainMarks { get { return obtainMarks; } set { obtainMarks = value; } }

        private decimal percentage;
        public decimal Percentage { get { return Percentage; } set { percentage = value; } }


        public Participent()
        {

        }

        static Participent()
        {
            companyName = "Corporate University";
        }

        public void CalculateTotalMarks()
        {
            obtainMarks = foundationMarks + webBasicMarks + dotNetMarks;
        }

        public void CalculatePercentage()
        {
            percentage = ((decimal)obtainMarks) / ((decimal)totalMarks) * 100;
        }

        public decimal ShowPercentage()
        {
            return percentage;
        }
    }
}
