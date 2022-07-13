using EMS.DAL;
using EMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.BL
{
    public class EMSBL
    {
        public static bool AddDepartment(Department department)
        {
            bool isAdded = EmsDAL.AddDepartment(department);
            return isAdded;
        }

        public static IEnumerable<Department> DepartmentList()
        {
            return EmsDAL.DepartmentList();
        }

        public static bool AddEmployee(Employee emp)
        {
            bool isAdded = EmsDAL.AddEmployee(emp);
            return isAdded;
        }

        public static void SerializeData()
        {
            EmsDAL.SerializeData();
        }

        public static IEnumerable<Employee> EmployeeList()
        {
            return EmsDAL.EmployeeList();
        }

        public static bool EmployeeExist(int empId)
        {
            bool isEmpExist = EmsDAL.EmployeeExist(empId);
            return isEmpExist;
        }

        public static bool UpdateEmployee(Employee emp)
        {
            bool isUpdated = EmsDAL.UpdateEmployee(emp);
            return isUpdated;
        }

        public static bool DeleteEmployee(int empId)
        {
            bool isDeleted = EmsDAL.DeleteEmployee(empId);
            return isDeleted;
        }

        public static IEnumerable<Employee> SearchEmployee(string criteria)
        {
            IEnumerable<Employee> list = EmsDAL.SearchEmployee(criteria);
            return list;
        }

        public static IEnumerable<Employee> EmpByDepartment(int deptId)
        {
            IEnumerable<Employee> list = EmsDAL.EmpByDepartment(deptId);
            return list;
        }

        public static bool UpdateDepartment(Department department)
        {
            bool isUpdated = EmsDAL.UpdateDepartment(department);
            return isUpdated;
        }

        public static bool DepartmentExist(int dId)
        {
            bool isEmpExist = EmsDAL.DepartmentExist(dId);
            return isEmpExist;
        }

        public static bool DeleteDepartment(int dId)
        {
            bool isDeleted = EmsDAL.DeleteDepartment(dId);
            return isDeleted;
        }

        public static IEnumerable<Employee> EmpDetail(string empId)
        {
            IEnumerable<Employee> list = EmsDAL.EmpDetails(empId);
            return list;
        }
    }
}
