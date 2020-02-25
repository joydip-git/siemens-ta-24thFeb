using System;
using CalculationLogic;

namespace CalculatorUI
{
	class Calculator
	{
		static void Main()
		{
			int x = 10;
			int y = 20;
 			int addRes = Calculation.Add(x, y);
			int subRes = Calculation.Subtract(x, y);
			Console.WriteLine(addRes);
			Console.WriteLine(subRes);
		}	
	}
}