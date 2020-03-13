using Implementation.Contracts;
using Implementation.Models;
using Implementation.Repository;
using Implementation.Exceptions;
using Implementation.Utility;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Implementation.DAL
{
    public class DepartmentDataAccessObject : IDataAccess<Department>
    {
        public bool Add(Department department)
        {
            bool exists = false;

            try
            {
                var departments = DataRepository.GetDepartments() as HashSet<Department>;
                if (departments != null)
                    exists = departments.Add(department);
                else
                {
                    DataNotAddedException e = new DataNotAddedException(ErrorMessages.DATA_NOT_ADDED);
                    throw e;
                }

                return exists;
            }
            catch (DataNotAddedException ex)
            {
                DepartmentDaoException deptDaoEx = new DepartmentDaoException(ErrorMessages.ADD_METHOD_ERROR, ex);
                throw deptDaoEx;
            }
            catch (Exception ex)
            {
                DepartmentDaoException deptDaoEx = new DepartmentDaoException(ex.Message, ex);
                throw deptDaoEx;
            }
        }

        public ICollection<Department> GetAll()
        {
            return DataRepository.GetDepartments().ToList<Department>();
        }

        public ICollection<Department> GetById(int id)
        {
            return null;
        }
    }
}
