using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeLab
{
    abstract class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    [Author("Saurabh", Bio =".Net Authority")]
    [Author("Samrudhi")]
    class DotNetFreshers: Book
    {

    }

    [Author("Saurabh", Bio ="Cloud Authority")]
    [Author("Surabhi")]
    class AzureForDevelopers: Book
    {

    }

}
