using Implementation.Contracts;
using Implementation.Models;
using Implementation.Repository;
using System.Collections.Generic;
using System.Linq;

namespace Implementation.DAL
{
    public class DepartmentDataAccessObject : IDataAccess<Department>
    {
        public bool Add(Department department)
        {
            var departments = DataRepository.GetDepartments() as HashSet<Department>;
            bool exists = false;
            exists = departments.Add(department);           
            return exists;
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
