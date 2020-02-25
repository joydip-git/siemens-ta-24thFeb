using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingParameters
{
    class Program
    {
        static void Swap(int x, ref int y, out int z)
        {
            z = 33;
            Console.WriteLine($"in swap method: value of x, y and z are {x}, {y} and {z}");
            x = 11;
            y = 22;
            
            Console.WriteLine($"in swap method: value of x, y and z are {x}, {y} and {z}");
        }
        static void Main()
        {
            int a = 10;
            int b = 20;
            int c;
            Swap(a, ref b, out c);
            Console.WriteLine($"in Main method: value of a, b and c are {a}, {b} and {c}");
        }
    }
}
