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
        
        static void InvokeOperation(int operationChoice, int firstValue, int secondValue)
        {
            switch (operationChoice)
            {
                case 1:
                    int addResult = Calculation.Add(firstValue, secondValue);
                    Console.WriteLine($"\naddition of {firstValue} and {secondValue} is {addResult}");
                    break;

                case 2:
                    int subtractionResult = Calculation.Subtract(firstValue, secondValue);
                    Console.WriteLine($"\nsubtraction of {firstValue} and {secondValue} is {subtractionResult}");
                    break;

                case 3:
                    int multiplicationResult = Calculation.Multiply(firstValue, secondValue);
                    Console.WriteLine($"\nmultiplication of {firstValue} and {secondValue} is {multiplicationResult}");
                    break;

                case 4:
                    int divisionResult = Calculation.Divide(firstValue, secondValue);
                    Console.WriteLine($"\ndivision of {firstValue} and {secondValue} is {divisionResult}");
                    break;

                default:
                    Console.WriteLine($"\nmake a proper choice");
                    break;
            }
        }
        
        static void ChangeDecision(ref char decision)
        {
            Console.Write("\nWould you like to continue?[y/Y]: ");
            decision = char.Parse(Console.ReadLine());
            if (char.IsUpper(decision))
            {
                decision = char.ToLower(decision);
            }
        }
        
        static void Main()
        {
            char decision = 'n';
            do
            {
                PrintMenu();
                int operationChoice = GetChoice();

                int firstValue;
                int secondValue;
                GetValue(out firstValue, out secondValue);
                InvokeOperation(operationChoice, firstValue, secondValue);

                ChangeDecision(ref decision);

            } while (decision == 'y');

            Console.WriteLine("press any key to end...");
            Console.ReadLine();
        }

    }
}
