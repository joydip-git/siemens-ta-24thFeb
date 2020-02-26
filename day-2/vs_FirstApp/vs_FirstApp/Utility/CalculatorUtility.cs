using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using vs_FirstApp.Models;
using CalculationLibrary;

namespace vs_FirstApp.Utility
{
    static class CalculatorUtility
    {
        public static void PrintMenu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
        }

        public static int GetUserChoice()
        {
            Console.Write("\nEnter a choice[1/2/3/4]: ");
            string value = Console.ReadLine();
            int choice = int.Parse(value);
            return choice;
        }

        public static OperationType ConvertUserChoice(int userChoice)
        {
            OperationType operationType;
            switch (userChoice)
            {
                case 1:
                    operationType = OperationType.Add;
                    break;

                case 2:
                    operationType = OperationType.Subtract;
                    break;

                case 3:
                    operationType = OperationType.Multiply;
                    break;

                case 4:
                    operationType = OperationType.Divide;
                    break;

                default:
                    operationType = OperationType.Add;
                    break;
            }
            return operationType;
        }

        public static void Assign(out int value)
        {
            Console.Write("\nEnter Value: ");
            string val = Console.ReadLine();
            value = int.Parse(val);
        }

        public static void GetValue(out int first, out int second)
        {
            Assign(out first);
            Assign(out second);
        }

        public static void InvokeOperation(OperationType operationChoice, int firstValue, int secondValue)
        {
            switch (operationChoice)
            {
                case OperationType.Add:
                    int addResult = Calculation.Add(firstValue, secondValue);
                    Console.WriteLine($"\naddition of {firstValue} and {secondValue} is {addResult}");
                    break;

                case OperationType.Subtract:
                    int subtractionResult = Calculation.Subtract(firstValue, secondValue);
                    Console.WriteLine($"\nsubtraction of {firstValue} and {secondValue} is {subtractionResult}");
                    break;

                case OperationType.Multiply:
                    int multiplicationResult = Calculation.Multiply(firstValue, secondValue);
                    Console.WriteLine($"\nmultiplication of {firstValue} and {secondValue} is {multiplicationResult}");
                    break;

                case OperationType.Divide:
                    int divisionResult = Calculation.Divide(firstValue, secondValue);
                    Console.WriteLine($"\ndivision of {firstValue} and {secondValue} is {divisionResult}");
                    break;

                default:
                    Console.WriteLine($"\nmake a proper choice");
                    break;
            }
        }

        public static void ChangeDecision(ref char decision)
        {
            Console.Write("\nWould you like to continue?[y/Y]: ");
            decision = char.Parse(Console.ReadLine());
            if (char.IsUpper(decision))
            {
                decision = char.ToLower(decision);
            }
        }
    }
}
