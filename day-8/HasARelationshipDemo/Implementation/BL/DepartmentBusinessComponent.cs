using Implementation.Contracts;
using Implementation.DAL;
using Implementation.Exceptions;
using Implementation.Models;
using System;
using System.Collections.Generic;

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
            try
            {
                return departmentDao.Add(item);
            }
            catch (DepartmentDaoException ex)
            {
                throw ex;
            }
            catch(Exception ex)
            {
                throw ex;
            }
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
