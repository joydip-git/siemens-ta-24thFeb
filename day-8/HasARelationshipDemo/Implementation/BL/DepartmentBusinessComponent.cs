using Implementation.Contracts;
using Implementation.Models;
using System;
using System.Collections.Generic;

namespace Implementation.BL
{
    public class DepartmentBusinessComponent : IBusinessComponent<Department>
    {
        public bool AddRecord(Department item)
        {
            throw new NotImplementedException();
        }

        public ICollection<Department> GetRecordById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Department> GetRecords()
        {
            throw new NotImplementedException();
        }

        public ICollection<Department> SortRecords(ICollection<Department> collection, EmployeeSortChoice choice)
        {
            return null;
        }
    }
}
