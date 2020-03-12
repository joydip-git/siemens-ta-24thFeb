using Implementation.Contracts;
using Implementation.Models;
using Implementation.Repository;
using System.Collections.Generic;

namespace Implementation.DAL
{
    public class DepartmentDataAccessObject : IDataAccess<Department>
    {
        public bool Add(Department department)
        {
            var departments = DataRepository.GetDepartments() as HashSet<Department>;
            bool exists = false;
            exists = departments.Add(department);
            //if (departments != null && departments.Count > 0)
            //{
            //    foreach (var d in departments)
            //    {
            //        if (d.DepartmentId == department.DepartmentId)
            //        {
            //            exists = true;
            //            break;
            //        }
            //    }
            //}

            //if (!exists)
            //    departments.Add(department);

            //return !exists;
            return exists;
        }

        public ICollection<Department> GetAll()
        {
            return DataRepository.GetDepartments();
        }

        public ICollection<Department> GetById(int id)
        {
            return null;
        }
    }
}
