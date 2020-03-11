using Implementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Repository
{
    public static class DataRepository
    {
        private static List<Department> departments;

        static DataRepository()
        {
            departments = new List<Department>();
        }
        public static List<Department> GetDepartments()
        {
            return departments;
        }        
    }
}
