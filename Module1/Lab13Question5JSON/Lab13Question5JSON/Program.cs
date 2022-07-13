using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Question5JSON
{
    class Program
    {
        private static List<Supplier> suppliers = new List<Supplier>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add contract,\n" +
                                    "2. Serialize added contracts to json file,\n" +
                                    "3. Deserialize contracts from from json file\n," +
                                    "4.Quit");
                Console.Write("Choose an option: ");
                var input = Console.ReadLine();


                if (int.TryParse(input, out var option))
                {
                    switch (option)
                    {
                        case 1:
                            AddSupplier();
                            break;
                        case 2:
                            SerializeSuppliers();
                            break;
                        case 3:
                            DeserializeSuppliers();
                            break;
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
        private static void AddSupplier()
        {
            var supplier = new Supplier();
            Console.Write("Enter supplier no: ");
            supplier.SupplierNo = int.Parse(Console.ReadLine());
            Console.Write("Enter supplier name: ");
            supplier.SupplierName = Console.ReadLine();


            suppliers.Add(supplier);
            Console.WriteLine("Supplier added");
        }

        private static void SerializeSuppliers()
        {
            Console.Write("Enter filename: ");
            var input = Console.ReadLine();
            var path = @"D:\Lab\" + input;

            var serializer = new ContractSerializer();
            serializer.SerializeSuppliers(path, suppliers);


            Console.WriteLine($"Suppliers has been serialized to file {path}");
        }


        private static void DeserializeSuppliers()
        {
            Console.Write("Enter filename: ");
            var input = Console.ReadLine();
            var path1 = @"D:\Lab\" + input;


            var serializer = new ContractSerializer();
            var deserialized = serializer.DeserializeSuppliers(path1);


            if (deserialized.Count == 0)
            {
                Console.WriteLine("No suppliers");
                return;
            }


            Console.WriteLine("Deserialized suppliers:");
            for (var i = 0; i < deserialized.Count; i++)
                Console.WriteLine($"{i + 1}. {deserialized[i]}");
        }

        public class ContractSerializer
        {
            public void SerializeSuppliers(string path, List<Supplier> suppliers)
            {
                using (FileStream stream = new FileStream(
                    path, FileMode.Create, FileAccess.Write))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Supplier>));
                    serializer.WriteObject(stream, suppliers);

                }
            }


            public List<Supplier> DeserializeSuppliers(string path1)
            {
                using (FileStream stream = new FileStream(
                        path1, FileMode.Open, FileAccess.Read))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Supplier>));

                    var data = serializer.ReadObject(stream);
                    if (data != null)
                    {
                        if (data is List<Supplier> employees)
                        {
                            suppliers = employees;
                        }
                    }
                }
                return suppliers;
            }

        }
    }
}
