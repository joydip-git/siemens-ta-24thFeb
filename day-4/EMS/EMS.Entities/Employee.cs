using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class Employee
    {
        //data members
        private string employeeName;
        private int employeeId;
        private decimal basicPayment;
        private decimal daPayment;
        private decimal hraPayment;
        //private decimal totalSalary;

        public void Assign(string empName, int empId, decimal basicPay, decimal daPay, decimal hraPay)
        {
            employeeName = empName;
            employeeId = empId;
            basicPayment = basicPay;
            daPayment = daPay;
            hraPayment = hraPay;
        }

        public decimal CalculateSalary()
        {
            decimal total = basicPayment + daPayment + hraPayment;
            return total;
        }
    }
}
