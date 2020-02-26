using System;
using vs_FirstApp.Utility;
using vs_FirstApp.Models;
//static import
using static vs_FirstApp.Utility.CalculatorUtility;
//using vs_FirstApp.Utility;

namespace vs_FirstApp
{
    class Program
    {
        //static void Main(string[] args)
        //static int Main()
        //static int Main(string[] args)
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
