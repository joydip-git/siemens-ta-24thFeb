using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class MyClass
    {
        int x;
        int y;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
    class Program
    {
        static void OneDimArray()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"enter value at arr[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"value at arr[{i}]={arr[i]}");
            }
        }
        static void TwoDimArray()
        {
            int[,] arr = new int[3, 2];

            for (int rowIndex = 0; rowIndex < arr.GetLength(0); rowIndex++)
            {
                for (int elementIndex = 0; elementIndex < arr.GetLength(1); elementIndex++)
                {
                    Console.Write($"enter value at arr[{rowIndex},{elementIndex}]: ");
                    arr[rowIndex, elementIndex] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int rowIndex = 0; rowIndex < arr.GetLength(0); rowIndex++)
            {
                for (int elementIndex = 0; elementIndex < arr.GetLength(1); elementIndex++)
                {
                    Console.WriteLine($"value at arr[{rowIndex},{elementIndex}]: {arr[rowIndex, elementIndex]}");
                }
                Console.WriteLine();
            }
        }
        static void ArrayOfString()
        {
            Console.Write("name count? ");
            int count = int.Parse(Console.ReadLine());
            string[] people = new string[count];

            //string nameFirst = people[0];
            for (int i = 0; i < people.Length; i++)
            {
                Console.Write("name#{i}: ");
                people[i] = Console.ReadLine();
            }
            foreach (string item in people)
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            //Array arr = new Array(int,5);
            //OneDimArray();
            //TwoDimArray();
            string sentence = "I work for siemens";
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(sentence[i]);
            }

            //int[] arr = new int[] { 10, 20, 30 };
            //int[] arr = { 10, 20, 30 };

            //int[,] arr = new int[,] { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            //int[,] arr = { { 10, 20 }, { 30, 40 }, { 50, 60 } };

            MyClass[] arr = new MyClass[2];
            for (int i = 0; i < 2; i++)
            {
                MyClass mc = new MyClass();
                arr[i] = mc;
            }
            foreach (MyClass item in arr)
            {
                Console.WriteLine(item.X);
            }

            var query = from obj in arr
                        where obj.X == 10
                        select obj;
        }
    }
}
