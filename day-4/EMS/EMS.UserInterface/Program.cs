using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMS.Entities;

namespace EMS.UserInterface
{
    class Program
    {
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

            Employee anilObjectRef = new Employee();
            anilObjectRef.Assign(empId: id, empName: name, hraPay: hra, daPay: da, basicPay: basic);           
            return anilObjectRef;
        }
        static void Main()
        {
            Employee anilRef = AcceptValuesandCreateObject();
            PrintSalary(anilRef);
            //string str = "siemens";


            //Employee sunilObjRef = new Employee();
            //sunilObjRef.CalculateSalary();
        }
        static void PrintSalary(Employee anil)
        {
            decimal totalSal = anil.CalculateSalary();
            Console.WriteLine(totalSal);
        }
    }
}
