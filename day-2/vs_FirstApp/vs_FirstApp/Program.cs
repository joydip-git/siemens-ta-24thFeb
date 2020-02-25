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
        static void Assign(out int value)
        {
            Console.Write("\nEnter Value: ");
            string val = Console.ReadLine();
            value = int.Parse(val);
        }
        static void GetValue(out int first, out int second)
        {
            Assign(out first);
            Assign(out second);
        }
        static void Main()
        {
            PrintMenu();
            int operationChoice = GetChoice();

            int firstValue;
            int secondValue;
            GetValue(out firstValue, out secondValue);

            string str = "abcd";
            int value;
            bool possible = int.TryParse(str, out value);
            if(possible)
                Console.WriteLine($"possible...value: {value}");
            else
                Console.WriteLine("not possible");

            Console.WriteLine("press any key to end...");
            Console.ReadLine();
        }
    }
}
