using System;

namespace StaticKeywordDemo
{
    class Calculation
    {
        public static int Add(int x, int y)
        {
            return (x + y);
        }
    }
    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee("joy", 1, 1000, 1000, 1000);
            Employee emp2 = new Employee("anil", 2, 2000, 2000, 2000);

            Console.WriteLine(emp1.CalculateSalary());
            Console.WriteLine(emp2.CalculateSalary());

            Console.WriteLine(Employee.JoiningBonus);
            Console.WriteLine(Employee.YEARLYBONUS);
        }
    }
}
