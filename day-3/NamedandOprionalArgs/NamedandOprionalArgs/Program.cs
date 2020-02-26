using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedandOprionalArgs
{
    class Program
    {
        //optional argument with default value
        static void CalculateArea(int dim1, int dim2 = 0, int dim3 = 0, int dim4 = 0, int dim5 = 0, int dim6 = 0, int dim7 = 0, int dim8 = 0)
        {

        }
        static void Swap(int x, int y, int z)
        {
            x = 11;
            y = 22;
            z = 33;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;
            //named argument
            // method-name(arg-name:param-name,....);
            Swap(a, b, c);
            Swap(x: b, y: c, z: a);
            Swap(x: a, z: c, y: b);
            CalculateArea(dim1: 12, dim3: 13);
        }
    }
}
