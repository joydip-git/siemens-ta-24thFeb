using System;
using System.Collections.Generic;
using System.Linq;

namespace DelegateDemo
{
    //delegate bool LogicInvoker(int num);

    //public delegate bool Predicate<in T>(T obj);
    //delegate bool LogicInvoker<in T>(T item);

    //public delegate TResult Func<in T, out TResult>(T arg);
    delegate TResult LogicInvoker<in T, out TResult>(T num) where T : struct;

    //public delegate TResult Func<in T1, int T2, out TResult>(T1 arg1, T2 arg1);
    delegate TResult LogicInvoker<in T1, in T2, out TResult>(T1 num1, T2 num2) where T1 : struct where T2 : struct;


    //sealed class LogicInvoker:MultiCastDelegate:Delegate:Object
    //{
    //    private MethodInfo _method;
    //    private object _target;
    //    private Delegate[] invocationList;
    //    public bool Invoke(int num) { return false; }
    //}

    class Logic
    {
        public bool IsEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }
        public bool IsOdd(int number)
        {
            if (number % 2 != 0)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        //public class Inner
        //{
        //    public static bool Ano(int num)
        //    {
        //        return num > 3 ? true : false;
        //    }
        //}
        static List<int> Filter(List<int> input, LogicInvoker<int, bool> del)
        {
            List<int> result = new List<int>();

            foreach (int item in input)
            {
                bool value = del(item);
                if (value)
                {
                    result.Add(item);
                }
            }
            return result;
        }
        static void Main()
        {
            Func<int, bool> isEven = (n) => n % 2 == 0;
            Func<int, int, int> addFn = (a, b) => a + b;
            Action print = () => Console.WriteLine("hello");
            //Predicate<int> 
            

            List<int> source = new List<int> { 1, 4, 2, 5, 3, 7, 8, 6, 0, 9 };

            Logic logicHolder = new Logic();
            //LogicInvoker<int, bool> evenDelegate = new LogicInvoker<int, bool>(logicHolder.IsOdd);
            LogicInvoker<int, bool> evenDelegate = logicHolder.IsOdd;

            //bool res = evenDelegate.Invoke(12);
            //or
            //bool res = evenDelegate(12);
            //Console.WriteLine(res);

            //C# (2.0)
            //LogicInvoker greaterThanDel = delegate (int num)
            //{
            //    return num > 3 ? true : false;
            //};

            //Lambda Expression (C# 3.0 - 2007)
            //LogicInvoker greaterThanDel = (num) =>
            //{
            //    return num > 3 ? true : false;
            //};
            //LogicInvoker greaterThanDel = (num) => num % 2 != 0;

            //Console.WriteLine(greaterThanDel(4));           

            var resultList = Filter(source, evenDelegate);
            //var resultList = Filter(source, greaterThanDel);
            //var resultList = Filter(source, num => num % 2 == 0);
            foreach (int item in resultList)
            {
                Console.WriteLine(item);
            }



            //evenDelegate += logicHolder.IsOdd;
            //bool res = evenDelegate.Invoke(12);
            //Console.WriteLine(res);

            LogicInvoker<int, int> l1 = (a) => a * a;
            LogicInvoker<int, int, int> add = (a, b) => a + b;
        }
    }
}
