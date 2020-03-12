using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation.Models
{
    public class Employee
    {
        private Department _departmentInfo;

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal Salary { get; set; }
        public int DepartmentId { get; protected set; }
        public Department DepartmentInfo
        {
            get { return _departmentInfo; }
            set
            {
                _departmentInfo = value;
                if (value != null)
                {
                    DepartmentId = value.DepartmentId;
                }
            }
        }
        public Employee()
        {

        }
        public Employee(int id, string name, decimal salary, Department department = null)
        {
            EmployeeId = id;
            EmployeeName = name;
            Salary = salary;
            DepartmentInfo = department;
        }

        public override string ToString()
        {
            return $"Id:{EmployeeId}, Name:{EmployeeName}, Salary:{Salary}";
        }
        public override int GetHashCode()
        {
            return this.EmployeeId.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Employee)
                {
                    Employee other = obj as Employee;

                    if (other == this)
                        return true;

                    if (!this.EmployeeId.Equals(other.EmployeeId))
                        return false;

                    return true;
                }
                else
                    return false;
            }
            else
                return false; 
        }
    }
}
