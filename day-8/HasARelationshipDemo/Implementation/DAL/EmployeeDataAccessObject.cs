using Implementation.Contracts;
using Implementation.Models;
using Implementation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.DAL
{
    public class EmployeeDataAccessObject : IDataAccess<Employee>
    {
        public ICollection<Employee> GetAll()
        {
            return DataRepository.GetEmployees();
        }
        public bool Add(Employee employee)
        {
            var employees = DataRepository.GetEmployees() as HashSet<Employee>;
            bool exists = false;
            exists = employees.Add(employee);
            return exists;
            //if (employees != null && employees.Count > 0)
            //{
            //    foreach (var item in employees)
            //    {
            //        if (item.EmployeeId == employee.EmployeeId)
            //        {
            //            exists = true;
            //            break;
            //        }
            //    }
            //}

            //if (!exists)
            //    employees.Add(employee);

            //return !exists;
        }
        public ICollection<Employee> GetById(int departmentId)
        {
            var employees = DataRepository.GetEmployees();
            List<Employee> found = null;

            if (employees != null && employees.Count > 0)
            {
                found = new List<Employee>();
                foreach (var item in employees)
                {
                    if (item.DepartmentId == departmentId)
                    {
                        found.Add(item);
                    }
                }
            }

            return found;
        }
    }
}
