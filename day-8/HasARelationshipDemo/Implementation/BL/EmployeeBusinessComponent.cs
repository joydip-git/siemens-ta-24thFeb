using Implementation.Contracts;
using Implementation.Models;
using System;
using System.Collections.Generic;

namespace Implementation.BL
{
    public class EmployeeBusinessComponent : IBusinessComponent<Employee>
    {
        public bool AddRecord(Employee item)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetRecordById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Employee> GetRecords()
        {
            throw new NotImplementedException();
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
