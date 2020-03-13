using Implementation.Models;
using System.Collections.Generic;

namespace Implementation.Repository
{
    public static class DataRepository
    {
        private static HashSet<Department> departments;
        private static HashSet<Employee> employees;

        static DataRepository()
        {
            //departments = new HashSet<Department>();
            employees = new HashSet<Employee>();
        }
        public static ICollection<Department> GetDepartments()
        {
            return departments;
        }
        public static ICollection<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
