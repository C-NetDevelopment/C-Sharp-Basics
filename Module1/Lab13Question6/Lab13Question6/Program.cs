using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Lab13Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. serialize student,\n" +
                                    "2. Deserialize student,\n" +
                                    "3.Quit");
                Console.Write("Choose an option: ");
                var input = Console.ReadLine();


                if (int.TryParse(input, out var option))
                {
                    switch (option)
                    {
                        case 1:
                            SerializeStudent();
                            break;
                        case 2:
                            DeserializeStudent();
                            break;                       
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }

                }
                Console.WriteLine();
            }
        }
        private static void SerializeStudent()
        {
            Console.Write("Enter filename: ");
            var input = Console.ReadLine();
            var path = @"D:\Lab\" + input;


            var student = new Student();
            Console.Write("Input roll no: ");
            student.RollNo = int.Parse(Console.ReadLine());
            Console.Write("Input name: ");
            student.Name = Console.ReadLine();
            Console.Write("Input city: ");
            student.City = Console.ReadLine();
            Console.Write("Input degree: ");
            student.Degree = Console.ReadLine();


            var serializer = new ContractSerializer();
            serializer.SerializeStudent(path, student);


            Console.WriteLine($"Student has been serialized to file {path}");
        }
        private static void DeserializeStudent()
        {
            Console.Write("Enter filename: ");
            var input = Console.ReadLine();
            var path1 = @"D:\Lab\" + input;


            var serializer = new ContractSerializer();
            var student = serializer.DeserializeStudent(path1);


            Console.WriteLine(student);
        }

        public class ContractSerializer
        {

            public void SerializeStudent(string path, Student student)
            {
                var binaryFormatter = new BinaryFormatter();


                using (var fs = new FileStream(path, FileMode.OpenOrCreate))
                    binaryFormatter.Serialize(fs, student);
            }


            public Student DeserializeStudent(string path1)
            {
                var binaryFormatter = new BinaryFormatter();


                using (var fs = new FileStream(path1, FileMode.OpenOrCreate))
                    return (Student)binaryFormatter.Deserialize(fs);
            }
        }
    }
}
