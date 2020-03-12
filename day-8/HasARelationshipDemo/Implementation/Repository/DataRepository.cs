using Implementation.Models;
using System.Collections.Generic;

namespace Implementation.Repository
{
    public static class DataRepository
    {
        private static List<Department> departments;
        private static List<Employee> employees;

        static DataRepository()
        {
            departments = new List<Department>();
            employees = new List<Employee>();
        }
        public static List<Department> GetDepartments()
        {
            return departments;
        }
        public static List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
