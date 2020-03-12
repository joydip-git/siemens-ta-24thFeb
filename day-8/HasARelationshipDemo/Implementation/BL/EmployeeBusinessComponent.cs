using Implementation.Contracts;
using Implementation.DAL;
using Implementation.Models;
using System.Collections.Generic;

namespace Implementation.BL
{
    public class EmployeeBusinessComponent : IBusinessComponent<Employee>
    {
        private EmployeeDataAccessObject employeeDao;

        public EmployeeBusinessComponent()
        {
            employeeDao = new EmployeeDataAccessObject();
        }
        public bool AddRecord(Employee item)
        {
            if (item != null)
                return employeeDao.Add(item);
            else
                return false;
        }

        public ICollection<Employee> GetRecordById(int id)
        {
            return employeeDao.GetById(id);
        }

        public ICollection<Employee> GetRecords()
        {
            return employeeDao.GetAll();
        }

        public ICollection<Employee> SortRecords(ICollection<Employee> collection, EmployeeSortChoice choice)
        {
            var employees = collection as List<Employee>;
            EmployeeComparison employeeComparison = new EmployeeComparison(choice);
            employees.Sort(employeeComparison);
            return employees;
        }
    }
}
