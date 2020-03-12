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
            var departments = DataRepository.GetDepartments();
            bool exists = false;

            if (departments != null && departments.Count > 0)
            {
                foreach (var d in departments)
                {
                    if (d.DepartmentId == department.DepartmentId)
                    {
                        exists = true;
                        break;
                    }
                }
            }

            if (!exists)
                departments.Add(department);

            return !exists;
        }

        public List<Department> GetAll()
        {
            return DataRepository.GetDepartments();
        }

        public List<Department> GetById(int id)
        {
            return null;
        }
    }
}
