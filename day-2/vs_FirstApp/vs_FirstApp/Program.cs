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
        static void Main()
        {
            int result = Calculation.Add(12, 13);
            Console.WriteLine(result);            

            Console.WriteLine("press any key to end...");
            Console.ReadLine();
        }
    }
}
