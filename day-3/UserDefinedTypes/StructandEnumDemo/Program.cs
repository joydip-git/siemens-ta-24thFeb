using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructandEnumDemo.Structures;
using StructandEnumDemo.Enums;

namespace StructandEnumDemo
{
    class Program
    {
        static void TestEnum()
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

        }
        static void Main()
        {
            TestEnum();
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.WriteLine("hi...");

            //double margin_left = 12.34;
            //double margin_right = 56.70;
            //double margin_top = 56.70;
            //double margin_bottom = 56.70;

            Margin marginOfTextBox;
            marginOfTextBox.margin_bottom = 12;
            marginOfTextBox.margin_left = 30;
            marginOfTextBox.margin_right = 40;
            marginOfTextBox.margin_top = 50;

            Margin marginOfButton;
            marginOfButton.margin_bottom = 20;
            marginOfButton.margin_left = 45;
            marginOfButton.margin_right = 68;
            marginOfButton.margin_top = 90;

        }
    }
}
