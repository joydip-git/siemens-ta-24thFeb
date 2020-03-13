using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLibrary
{
    public class Calculation
    {
        //[Obsolete("use the other method...this is deprecated")]
        //public int Add(int x, int y)
        //{
        //    return (x + y);
        //}
        public T Add<T>(T x, T y) where T:struct
        {
            return default(T);
        }
        public int Subtract(int a, int b)
        {
            if (a > b)
                return (a - b);
            else
                return b - a;
        }
        public int Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {
                throw ex;
            }

        }
    }

    //class Check
    //{
    //    public void foo()
    //    {
    //        Calculation calculation = new Calculation();
    //        calculation.Add(12, 13);
    //    }
    //}
}
