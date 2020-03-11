using Implementation.Models;
using Implementation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.DAL
{
    public class DepartmentDataAccessObject
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
    }
}
