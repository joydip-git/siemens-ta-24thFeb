using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculationLibrary;

namespace vs_FirstApp
{
    class Program
    {
        //static void Main(string[] args)
        //static int Main()
        //static int Main(string[] args)
        static void PrintMenu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }
        static int GetChoice()
        {
            Console.Write("\nEnter a choice[1/2/3/4]: ");
            string value = Console.ReadLine();
            int choice = int.Parse(value);
            return choice;
        }
        static int GetValue()
        {
            Console.Write("\nEnter 1st Value: ");
            string val = Console.ReadLine();
            int number = int.Parse(val);
            return number;
        }
        static void Main()
        {
            PrintMenu();
            int operationChoice = GetChoice();

            

            Console.WriteLine("press any key to end...");
            Console.ReadLine();
        }
    }
}
