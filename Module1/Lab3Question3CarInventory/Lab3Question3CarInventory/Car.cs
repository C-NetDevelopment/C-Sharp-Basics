using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Question3CarInventory
{
    class Car
    {
        private string make;
        public string Make { get { return make; } set { make = value; } }

        private string model;
        public string Model { get { return model; } set { model = value; } }

        private int year;
        public int Year { get { return year; } set { year = value; } }

        private double salePrice;
        public double SalePrice { get { return salePrice; } set { salePrice = value; } }

        public Car()
        {

        }

        public Car(string make, string model, int year, double saleprice)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.salePrice = saleprice;
        }


    }
}
