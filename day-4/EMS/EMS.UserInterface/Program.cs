using EMS.Entities;
using System;

namespace EMS.UserInterface
{
    class Program
    {
        /// <summary>
        /// Method to accept values for an employee from user and create an object based on that data
        /// </summary>
        /// <returns>
        /// returns reference of the Employee class object
        /// </returns>
        static Employee AcceptValuesandCreateObject()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Basic Payment: ");
            decimal basic = decimal.Parse(Console.ReadLine());

            Console.Write("Da Payment: ");
            decimal da = decimal.Parse(Console.ReadLine());

            Console.Write("Hra Payment: ");
            decimal hra = decimal.Parse(Console.ReadLine());

            //Employee anilObjectRef = new Employee(employeeId: id, employeeName: name, hraPayment: hra, daPayment: da, basicPayment: basic, projectName: null);
            Employee objectReference = new Employee(employeeId: id, employeeName: name, hraPayment: hra, daPayment: da, basicPayment: basic);
                   
            return objectReference;
        }
        static void Main()
        {
            //calling a method to accept user values and create object of employee class
            Employee employeeReference = AcceptValuesandCreateObject();
            
            //setting project name for the employee
            employeeReference.ProjectName = "SITA";

            //calling method to print salary
            PrintSalary(employeeReference);
        }

        /// <summary>
        /// Prints salary of an employee
        /// </summary>
        /// <param name="employee">
        /// refernce of an employee whose salary has to be calculated
        /// </param>
        static void PrintSalary(Employee employee)
        {
            //calling method to calculate salary
            decimal totalSal = employee.CalculateSalary();
            //Console.WriteLine($"{ anil.GetEmployeeName()} has salary of {totalSal}");

            //printing the name along with total salary of an employee
            Console.WriteLine($"{ employee.EmployeeName} has salary of {totalSal}");
        }
    }
}
