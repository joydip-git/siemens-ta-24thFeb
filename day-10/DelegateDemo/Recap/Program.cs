using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap
{
    //delegate bool FilterDelegate(int num);
    //delegate bool FilterDelegate<in T>(T num);
    delegate TResult FilterDelegate<in T, out TResult>(T num);

    class Logic
    {
        public bool IsEven(int num)
        {
            return num % 2 == 0 ? true : false;
        }
        public static bool IsOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Logic logicRef = new Logic();
            //FilterDelegate evenDelegate
            //    = new FilterDelegate(logicRef.IsEven);  
            //group-method conversion
            //FilterDelegate evenDelegate = logicRef.IsEven;
            //FilterDelegate<int> evenDelegate = logicRef.IsEven;
            FilterDelegate<int, bool> evenDelegate = logicRef.IsEven;
            bool isEven = evenDelegate(12);
            Console.WriteLine(isEven);

            //FilterDelegate oddDelegate = new FilterDelegate(Logic.IsOdd);
            //FilterDelegate<int> oddDelegate = new FilterDelegate<int>(Logic.IsOdd);
            FilterDelegate<int, bool> oddDelegate = new FilterDelegate<int, bool>(Logic.IsOdd);
            bool isOdd = oddDelegate(13);
            Console.WriteLine(isOdd);

            //anonymous method and delegate
            //FilterDelegate greaterThanDelegate = delegate (int num)
            //FilterDelegate<int> greaterThanDelegate = delegate (int num)
            FilterDelegate<int, bool> greaterThanDelegate = delegate (int num)
             {
                 return num > 3 ? true : false;
             };
            //anonymous method and delegate with outer parameter (value)
            int value = 5;
            //FilterDelegate greaterThanDelegate1 = delegate (int num)
            //FilterDelegate<int> greaterThanDelegate1 = delegate (int num)
            FilterDelegate<int, bool> greaterThanDelegate1 = delegate (int num)
             {
                 return num > value ? true : false;
             };

            //lambda expression: new technique to write anonymous method
            //(arg1, arg2, ....) => (expression);
            //(arg1,arg2,..)=>{}

            //FilterDelegate lambdaDel = (arg) => (arg % 2 == 0);
            //FilterDelegate<int> lambdaDel = (arg) => (arg % 2 == 0);
            FilterDelegate<int, bool> lambdaDel = (arg) => (arg % 2 == 0);

            //built-in
            Action print = () => Console.WriteLine("hello");
            Action<int> printNum = (num) => Console.WriteLine(num);

            Predicate<int> isEvenDelegate = (num) => num % 2 == 0;
            Func<int, bool> isOddDelegate = (num) => num % 2 != 0;
            Func<int, int, int> addDelegate = (a, b) => a + b;

            List<int> list = new List<int> { 0, 1, 2, 4, 3, 6, 5, 7, 8, 9 };

            //LINQ: method syntax
            IEnumerable<int> filteredList = list.Where(isOddDelegate);
            foreach (int item in filteredList)
            {
                Console.WriteLine(item);
            }
            //LINQ: query syntax
            var result = from x in list
                         where x % 2 == 0
                         select x;
            foreach (int item in filteredList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
