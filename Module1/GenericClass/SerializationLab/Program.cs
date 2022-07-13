using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationLab
{
    class Program
    {
        static void Main(string[] args)
        {


            Employee emp = new Employee   // object initializer
            {
                Id = 1,
                Name = "Param",
                DateOfJoining = new DateTime(2021, 01, 01)
            };

            //SerializeBinary(emp);
            DeserializeBinary();
        }

        private static void DeserializeBinary()
        {
            try
            {
                string path = ConfigurationManager.AppSettings["BinaryFile"];

                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    var data=formatter.Deserialize(stream);
                    if (true)
                    {

                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Config file App Settings");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

       /* private static void SerializeBinary(Employee emp)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["BinaryFile"];

                using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, emp);
                    Console.WriteLine("We AAare done");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Config file App Settings");
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SerializationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }

    
}

