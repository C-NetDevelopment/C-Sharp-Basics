using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Dictionary
{
    class Program
    {
        static IDictionary<string, string> fileExtensions = new Dictionary<string, string>(); 
        static void Main(string[] args)
        {
            fileExtensions.Add(".docs", "Microsoft Word file");
            fileExtensions.Add(".odt", "OpenOffice Writer document file");
            fileExtensions.Add(".pdf", "PDF file");
            fileExtensions.Add(".rtf", "Rich Text Format");
            fileExtensions.Add(".tex", "LaTeX document file");
            fileExtensions.Add(".wpd", "WordPerfect document");
            fileExtensions.Add(".pdf1", "PDF file");

            for (int i = 0; i < fileExtensions.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        fileExtensions.ElementAt(i).Key,
                                                        fileExtensions.ElementAt(i).Value);
            }
            try
            {
                fileExtensions.Add(".pdf", "PDF file");
            }
            catch (Exception)
            {

                Console.WriteLine("Key Already Exist");
            }
            //indexer
            fileExtensions[".pdf"] = "saurabh";  //update value
            Console.WriteLine(fileExtensions[".pdf"]);
            

            try
            {
                fileExtensions[".ktm"] = "DataBase";
                
            }
            catch (Exception)
            {

                Console.WriteLine("Key not Exist");
            }
            Console.WriteLine();
            foreach ( KeyValuePair<string, string> extensions in fileExtensions)
            {
                Console.WriteLine($"Key :{extensions.Key}, Value:{extensions.Value}");
            }

            fileExtensions.Remove(".ktm");


            Console.WriteLine();
            foreach (KeyValuePair<string, string> extensions in fileExtensions)
            {
                Console.WriteLine($"Key :{extensions.Key}, Value:{extensions.Value}");
            }
            Console.ReadLine();
        }
    }
}
