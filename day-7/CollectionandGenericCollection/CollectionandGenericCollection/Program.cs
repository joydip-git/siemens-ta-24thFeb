using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionandGenericCollection
{
    class Program
    {
        static void ArrayListDemo()
        {
            ArrayList arrayList = new ArrayList();
            //int a = 12;
            //Object objA = a;
            //arrayList.Add(objA);
            arrayList.Add(12);
            arrayList.Add('a');
            arrayList.Add("siemens");
            arrayList.Add(12.34);
            arrayList.Add(true);
            //index position of the new value should be 1 greater than the last index no or less
            arrayList.Insert(1, 34);

            Console.WriteLine($"Capacity:{arrayList.Capacity}");
            Console.WriteLine($"Actual No of Elements:{arrayList.Count}");
            Console.WriteLine("\nvalues");
            foreach (object item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Remove('a');
            //find out index position of a given value
            int index = arrayList.IndexOf(12);
            //remove that value from the found index position using RemoveAt method
            arrayList.RemoveAt(index);

            Console.WriteLine($"\n\nCapacity:{arrayList.Capacity}");
            Console.WriteLine($"Actual No of Elements:{arrayList.Count}");
            Console.WriteLine("\nvalues after removal\n");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }

            //iteration --> no modification in collection during this time
            IEnumerator ie = arrayList.GetEnumerator();
            while (ie.MoveNext())
            {
                // arrayList[0] = 56;
                Console.WriteLine(ie.Current);
            }
        }
        static void Main()
        {            
            List<int> list = new List<int>();
            //int a = 12;
            //Object objA = a;
            //arrayList.Add(objA);
            list.Add(12);
            list.Add('a');
            list.Add(21);
            list.Add(5);
            //list.Add("siemens");
            //list.Add(12.34);
            //list.Add(true);
            //index position of the new value should be 1 greater than the last index no or less
            list.Insert(1, 34);

            list.Sort();
            Console.WriteLine($"Capacity:{list.Capacity}");
            Console.WriteLine($"Actual No of Elements:{list.Count}");
            Console.WriteLine("\nvalues");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            list.Remove('a');
            //find out index position of a given value
            int index = list.IndexOf(12);
            //remove that value from the found index position using RemoveAt method
            list.RemoveAt(index);

            Console.WriteLine($"\n\nCapacity:{list.Capacity}");
            Console.WriteLine($"Actual No of Elements:{list.Count}");
            Console.WriteLine("\nvalues after removal\n");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            //iteration --> no modification in collection during this time
            IEnumerator<int> ie = list.GetEnumerator();
            while (ie.MoveNext())
            {
                // arrayList[0] = 56;
                Console.WriteLine(ie.Current);
            }
        }
    }
}
