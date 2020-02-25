using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vs_FirstApp
{
    class Program
    {
        //static void Main(string[] args)
        //static int Main()
        //static int Main(string[] args)
        static void Main()
        {
            int result = Add(12, 13);
            Console.WriteLine(result);
        }
        static int Add(int firstValue, int secondValue)
        {
            return (firstValue + secondValue);
        }
    }
}
