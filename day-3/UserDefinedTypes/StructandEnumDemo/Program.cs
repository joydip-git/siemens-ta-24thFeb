using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructandEnumDemo
{
    class Program
    {
        static void Main()
        {
            Console.Write("name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Departments\n1. HR \n2.Training");
            Console.Write("Enter choice[h/t]: ");
            char choice = char.Parse(Console.ReadLine());

            Departments department = Departments.NotAllocated;
            //Console.WriteLine(department);
            switch (choice)
            {
                case 'h':
                    department = Departments.HR;
                    break;

                case 't':
                    department = Departments.TRNG;
                    break;

                default:
                    department = Departments.NotAllocated;
                    break;
            }

            //Console.WriteLine($"{name} belongs to {department} = { Convert.ToInt64(department)} department");


            switch (department)
            {
                case Departments.HR:
                    Console.WriteLine("welcome to Human Resource department");
                    break;

                case Departments.TRNG:
                    Console.WriteLine("welcome to Training department");
                    break;

                case Departments.NotAllocated:
                    Console.WriteLine("wait for few days for department allocation");
                    break;

                default:
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("hi...");
        }
    }
}
