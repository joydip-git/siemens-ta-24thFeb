using EMS.Entities;
using System;

namespace EMS.UserInterface
{
    class Program
    {
        /// <summary>
        /// Method to accept values for an employee from user and create an object based on that data
        /// </summary>
        /// <param name="empType">choice of employee: either developer (if the value is 1) or hr (if the value is 2)</param>
        /// <returns>
        /// returns reference of the Employee class object
        /// </returns>
        static Employee AcceptValuesandCreateObject(int empType)
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

            Employee employee = null;
            switch (empType)
            {
                case 1:
                    Console.Write("Incentive Payment: ");
                    decimal incentive = decimal.Parse(Console.ReadLine());
                    employee = new Developer(name, id, basic, da, hra, incentive);
                    break;

                case 2:
                    Console.Write("Gratuity Payment: ");
                    decimal gratuity = decimal.Parse(Console.ReadLine());
                    employee = new Hr(name, id, basic, da, hra, gratuity);
                    break;

                default:
                    break;
            }
            return employee;
        }
        static int GetCount()
        {
            Console.Write("How many records? ");
            return int.Parse(Console.ReadLine());
        }
        static void ShowEmployeeChoice()
        {
            Console.WriteLine("\n1.Developer");
            Console.WriteLine("2.Hr");
        }
        static int GetChoice()
        {
            Console.Write("Enter choice[1/2]: ");
            return int.Parse(Console.ReadLine());
        }
        static void Main()
        {
            //1. ask user about number of records
            int recordCount = GetCount();

            //2. create an array to store references of employee types
            Employee[] employees = new Employee[recordCount];

            //3. create as many employee type objects
            for (int i = 0; i < employees.Length; i++)
            {
                //3.1 give user choice to create either object of Developer or HR
                ShowEmployeeChoice();
                int choice = GetChoice();

                //3.2 create the object and store the reference in the array
                employees[i] = AcceptValuesandCreateObject(choice);
            }

            //4. create a separate method and pass that array in order to iterate through and calculate salary of every employee
            PrintSalary(employees);

        }

        /// <summary>
        /// Prints salary of an employee
        /// </summary>
        /// <param name="employees">
        /// refernce of an array storing references of employees
        /// </param>
        static void PrintSalary(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                //calling method to calculate salary
                decimal totalSal = employee.CalculateSalary();

                //printing the name along with total salary of an employee
                Console.WriteLine($"{ employee.EmployeeName} has salary of {totalSal}");

                //Type empType = employee.GetType();
                //Type devType = typeof(Developer);
                //Type hrType = typeof(Hr);

                //if(empType == devType)
                //{
                //    Developer developer = (Developer)employee;
                //    developer.CalculateSalary();
                //}
                //else if(empType == hrType)
                //{
                //    Hr hr = (Hr)employee;
                //}
                //if (employee is Developer)
                //{
                //    Developer developer = (Developer)employee;
                //    developer.CalculateSalary();
                //}
                //else if (employee is Hr)
                //{
                //    Hr hr = employee as Hr;
                //}
            }
        }
    }
}
