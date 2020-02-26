using CalculationLibrary;
using System;
using vs_FirstApp.Models;

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

        static int GetUserChoice()
        {
            Console.Write("\nEnter a choice[1/2/3/4]: ");
            string value = Console.ReadLine();
            int choice = int.Parse(value);
            return choice;
        }

        static OperationType ConvertUserChoice(int userChoice)
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

        static void InvokeOperation(OperationType operationChoice, int firstValue, int secondValue)
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
                int userChoice = GetUserChoice();
                OperationType operationChoice = ConvertUserChoice(userChoice);

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
