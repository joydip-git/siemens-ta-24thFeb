using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesDemo
{
    //generic interface
    interface IMyCollection<T, V>
    {
        void Add(T item);
        T Remove(T item);
    }
    //generic class implementing generic interface
    class MyCollection<T, V> : IMyCollection<T, V> where T : struct where V : struct
    {
        int index = 0;
        T[] collection;

        public MyCollection()
        {
            collection = new T[4];
        }
        public void Add(T item)
        {
            collection[index] = item;
        }
        public T Remove(T item)
        {
            return default(T);
        }
        public int Count
        {
            get => collection.Length;
        }
    }
    class Calculation
    {
        //generic method with constraint
        public static void Add<T>(T x, T y) where T : struct
        {

        }
        public static void Add<T1, T2>(T1 x, T2 y) where T1 : class where T2 : T1
        {

        }
    }
    class Program
    {
        static void Main()
        {
            Calculation.Add<int>(12, 13);
            //Calculation.Add<int, int>(10, 20);
            Calculation.Add<string, string>("str1", "str2");
            MyCollection<int, int> collection = new MyCollection<int, int>();
            collection.Add(12);
        }
    }
}
