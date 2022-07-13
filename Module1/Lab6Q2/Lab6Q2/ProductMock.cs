using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q2
{
    class ProductMock
    {
        private int ProductId;
        public int productId
        {
            get { return ProductId; }
            set
            {
                if (value <= 0)
                {
                    throw new DataEntryException("Product ID must be Greater than Zero");
                }
                else
                {
                    ProductId = value;
                }
            }
        }
        private string ProductName;
        public string productName
        {
            get { return ProductName; }
            set
            {
                if (value == "")
                {
                    throw new DataEntryException("Product Name cannot be left blank");
                }

                bool isLetterorNumbers = true;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]) && !char.IsDigit(value[i]))
                    {
                        isLetterorNumbers = false;
                    }
                }
                if (!isLetterorNumbers)
                {
                    throw new DataEntryException("Product Name should have alphabets");
                }
                ProductName = value;
            }

        }

        private double Price;
        public double price
        {
            get { return Price; }
            set
            {
                if (value <= 0)
                {
                    throw new DataEntryException("Product ID must be Greater than Zer0");
                }
                else
                {
                    Price = value;
                }
            }
        }
        public ProductMock(int ProductId, string ProductName, double Price)
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.Price = Price;
        }

        public ProductMock()
        {
        }

    }
}
