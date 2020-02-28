using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructDemo
{
    //access specifiers for struct: public or internal
    //access specifiers for struct members: public or internal or private
    public struct Point
    {
        int x_ordinate;
        int y_ordinate;

        //public Point(int x)
        //{
        //    x_ordinate = x;
        //    y_ordinate = 0;
        //}


        // you can write only parameterized (suggested only one)
        // you can't write any default ctor
        // every ctor must assign values to all data members
        //public Point(int x, int y)
        //{
        //    x_ordinate = x;
        //    y_ordinate = y;
        //}

        public int X_Ordinate
        {
            set { x_ordinate = value; }
            get { return x_ordinate; }
        }
        public int Y_Ordinate
        {
            set { y_ordinate = value; }
            get { return y_ordinate; }
        }

        public string GetLocation()
        {
            return $"X_ordinate: {x_ordinate} and Y_ordinate:{y_ordinate}";
        }
    }
}
