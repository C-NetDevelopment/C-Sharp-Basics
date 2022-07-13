using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Question1_2
{
    class Program
    {
        private static List<Contract> contracts = new List<Contract>();

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Add contract,\n" +
                                    "2. Serialize added contracts to file,\n" +
                                    "3. Deserialize contracts from from file\n," +
                                    "4.Quit");
                Console.Write("Choose an option: ");
                var input = Console.ReadLine();


                if (int.TryParse(input, out var option))
                {
                    switch (option)
                    {
                        case 1:
                            AddContract();
                            break;
                        case 2:
                            SerializeContracts();
                            break;
                        case 3:
                            DeserializeContracts();
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


        private static void AddContract()
        {
            var contract = new Contract();

            Console.Write("Enter contract no: ");
            contract.ContractNo = int.Parse(Console.ReadLine());


            Console.Write("Enter contract name: ");
            contract.ContractName = Console.ReadLine();


            Console.Write("Enter cell no: ");
            contract.CellNo = Console.ReadLine();


            contracts.Add(contract);
            Console.WriteLine("Contract added");
        }


        private static void SerializeContracts()
        {
            Console.Write("Enter filename: ");
            var input = Console.ReadLine();
            var path = @"D:\Lab\" + input; 

            var serializer = new ContractSerializer();
            serializer.Serialize(path, contracts);


            Console.WriteLine($"Contractsserialized to file {path}");
        }


        private static void DeserializeContracts()
        {
            Console.Write("Input path: ");
            var path = Console.ReadLine();


            var serializer = new ContractSerializer();
            var deserialized = serializer.Deserialize(path);


            if (deserialized.Count == 0)
            {
                Console.WriteLine("No contracts");
                return;
            }

            Console.WriteLine("Deserialized contracts:");
            for (var i = 0; i < deserialized.Count; i++)
                Console.WriteLine($"{i + 1}. {deserialized[i]}");
        }
    }


    public class ContractSerializer
    {
        public void Serialize(string path, List<Contract> contracts)
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contracts);
            }
        }


        public List<Contract> Deserialize(string path)
        {
            var formatter = new BinaryFormatter();


            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                return (List<Contract>)formatter.Deserialize(fs);
            }
        }

    }
}
