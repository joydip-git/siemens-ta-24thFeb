using Implementation.Contracts;
using Implementation.Models;
using System;
using System.Collections.Generic;
using Implementation.DAL;

namespace Implementation.BL
{
    public class DepartmentBusinessComponent : IBusinessComponent<Department>
    {
        private DepartmentDataAccessObject departmentDao;
        public DepartmentBusinessComponent()
        {
            departmentDao = new DepartmentDataAccessObject();
        }
        public bool AddRecord(Department item)
        {            
            return departmentDao.Add(item);
        }

        public ICollection<Department> GetRecordById(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Department> GetRecords()
        {
            return departmentDao.GetAll();
            //var list = departmentDao.GetAll() as List<Department>;
            //list.Sort();
            //return list;
        }

        public ICollection<Department> SortRecords(ICollection<Department> collection, EmployeeSortChoice choice)
        {
            return null;
        }
    }
}
