using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// reflection is used to give type information of assembly duting runtime
//example intellisence

namespace ReflectionLab
{
    class Program
    {
        static void Main(string[] args)
        {

            //1st step load assembly
            Assembly assembly = Assembly.LoadFrom("EmployeeLibrary.dll");

            //get assembly type
            foreach (var type in assembly.GetTypes())
            {
                Console.WriteLine($"Type name: {type.Name}");
                if (type.IsClass)
                {
                    foreach (var member in type.GetMembers())    //return array of member info
                    {
                        Console.WriteLine($"\tName: {member.Name}, " +
                            $"Type: {member.MemberType}");
                    }
                }
            }
            Console.WriteLine("done");

            Console.WriteLine("Invoke employee - add mehod");


            object employee = assembly.CreateInstance("EmployeeLibrary.Employee");
            Type empType = assembly.GetType("EmployeeLibrary.Employee");
            if (empType != null && empType.IsClass)
            {
                MethodInfo addMethod = empType.GetMethod("Add");
                if (addMethod!= null && addMethod.MemberType == MemberTypes.Method)
                {
                    object result = addMethod.Invoke(employee, new object[] { 1, "Param" });
                    bool isAdded = Convert.ToBoolean(result);
                }

                Console.WriteLine("Done!");
            }

            Console.ReadLine();
        }
    }
}
