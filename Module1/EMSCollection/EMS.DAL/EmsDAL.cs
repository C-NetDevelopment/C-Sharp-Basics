using EMS.Entities;
using EMS.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace EMS.DAL
{
    public class EmsDAL
    {
        static List<Department> departmentList = new List<Department>();
        static int deptCounter = 1;
        static List<Employee> employeeList = new List<Employee>();
        static int empCounter = 1;

        static EmsDAL()
        {
            //deserialization
            try
            {
                // for emp data
               string path = ConfigurationManager.AppSettings["EmpFilePath"];
                if (File.Exists(path))
                {
                    using (FileStream stream = new FileStream(
                        path, FileMode.Open, FileAccess.Read))
                    {
                        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Employee>));
                        var data = serializer.ReadObject(stream);
                        if (data != null)
                        {
                            if (data is List<Employee> employees)
                            {
                                employeeList = employees;
                            }
                        }
                    }
                    //for dept data
                    path = ConfigurationManager.AppSettings["DeptFilePath"];
                    using (FileStream stream = new FileStream(
                        path, FileMode.Open, FileAccess.Read))
                    {
                        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Department>));
                        var data = serializer.ReadObject(stream);
                        if (data != null)
                        {
                            if (data is List<Department> departments)
                            {
                                departmentList = departments;
                            }
                        }
                    }

                }
            }
            catch (ArgumentException)
            {
                throw new EmsExceptions("Config file read fail");
            }
            catch (IOException ex)
            {
                throw new EmsExceptions(ex.Message);
            }
            catch (SerializationException ex)
            {
                throw new EmsExceptions(ex.Message);
            }
        }

        public static IEnumerable<Employee> EmpDetails(string empId)
        {
            List<Employee> list = null;
            if (int.TryParse(empId, out int employeeId))
            {
                list = employeeList.FindAll(e => e.Id == employeeId);
                if (list ==null)
                {
                    throw new EmsExceptions("Employee Does not exist");
                }
                else
                {
                    return employeeList;
                }
                
            }
            return list;
        }

        public static IEnumerable<Employee> EmpByDepartment(int deptId)
        {

            var department = employeeList.Find(e => e.DepartmentId == deptId);
            if (department==null)
            {
                throw new EmsExceptions("Deartment Not found");
            }
            else
            {
                return employeeList;
            }

        }

        public static IEnumerable<Employee> SearchEmployee(string criteria)
        {
            List<Employee> list = null;
            if (int.TryParse(criteria, out  int empId))
            {
                list = employeeList.FindAll(e => e.Id == empId);
            }
            else
            {
                if (DateTime.TryParse(criteria, out DateTime doj))
                {
                    list = employeeList.FindAll(e => e.DateOfJoining == doj);
                }
                else
                {
                    criteria = criteria.ToLower();
                    list = employeeList.FindAll(e => e.Name.ToLower() == criteria ||
                    e.Email.ToLower() == criteria);
                }
            }
            return list;
        }

        public static bool DeleteDepartment(int dId)
        {
            var department = departmentList.Find(e => e.DepartmentId == dId);
            if (department == null)
            {
                throw new EmsExceptions("Department does not exist");
            }
            else
            {
                if (departmentList.Remove(department))
                {
                    return true;
                }
                return false;
            }
        }
        public static bool DeleteEmployee(int empId)
        {
            var employee = employeeList.Find(e=> e.Id == empId);
            if (employee== null)
            {
                throw new EmsExceptions("Employee does not exist");
            }
            else
            {
                if (employeeList.Remove(employee))
                {
                    return true;
                }
                return false;
            }
            
        }

        public static bool UpdateDepartment(Department department)
        {
            var existDepartment = departmentList.Find(e => e.DepartmentId == department.DepartmentId);
            if (existDepartment == null)
            {
                return false;
                throw new EmsExceptions("Deartment Not found");
            }
            else
            {
                existDepartment.DepartmentName = department.DepartmentName;
                return true;
            }
        }

        public static bool UpdateEmployee(Employee emp)
        {
            var existingEmp = employeeList.Find(e=> e.Id == emp.Id);
            if (existingEmp== null)
            {
                return false;
                throw new EmsExceptions("Employee not found");
            }
            else
            {
                
                existingEmp.Name = emp.Name;
                existingEmp.Salary = emp.Salary;
                existingEmp.Email = emp.Email;
                existingEmp.Gender = emp.Gender;
                existingEmp.Hobbies = emp.Hobbies;
                existingEmp.DateOfJoining = emp.DateOfJoining;
                existingEmp.DepartmentId = emp.DepartmentId;

                return true;
            }
        }

        public static bool DepartmentExist(int dId)
        {
            var department = departmentList.Find(e => e.DepartmentId == dId);
            if (department == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool EmployeeExist(int empId)
        {
            var employee = employeeList.Find(e => e.Id == empId);
            if (employee == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static IEnumerable<Employee> EmployeeList()
        {
            return employeeList;
        }

        public static void SerializeData()
        {
            try
            {
                // for emp data
                string path = ConfigurationManager.AppSettings["EmpFilePath"];
                using (FileStream stream = new FileStream(
                    path, FileMode.Create, FileAccess.Write))
                {
                    System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Employee>));
                    serializer.WriteObject(stream, employeeList);

                }
                //for dept data
                path = ConfigurationManager.AppSettings["DeptFilePath"];
                using (FileStream stream = new FileStream(
                    path, FileMode.Create, FileAccess.Write))
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Department>));
                    serializer.WriteObject(stream, departmentList);

                }

            }
            catch (ArgumentException)
            {
                throw new EmsExceptions("Config file read fail");
            }
            catch (IOException ex)
            {
                throw new EmsExceptions(ex.Message);
            }
            catch (SerializationException ex)
            {
                throw new EmsExceptions(ex.Message);
            }
        }


        public static bool AddDepartment(Department department)
        {
            //check if department already exist
            var dept = departmentList.Where(d => d.DepartmentName == department.DepartmentName);
            if (dept != null)
            {
                department.DepartmentId = deptCounter++;
                departmentList.Add(department);
                return true;
            }
            else
            {
                throw new EmsExceptions("Department already exist");
            }
        }

        public static bool AddEmployee(Employee emp)
        {
            Employee existEmployee = employeeList.FirstOrDefault(e =>
                                    e.Email == emp.Email);
            if (existEmployee == null)
            {
                emp.Id = empCounter++;
                employeeList.Add(emp);
                return true;
            }
            else
            {
                throw new EmsExceptions("Employee Already exist");
            }
        }

        public static IEnumerable<Department> DepartmentList()
        {
            return departmentList;
        }
    }
}
