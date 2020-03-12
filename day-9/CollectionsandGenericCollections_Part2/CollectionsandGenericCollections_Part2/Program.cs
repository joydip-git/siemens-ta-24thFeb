using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsandGenericCollections_Part2
{
    class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return $"{Id} and {Name}";
        }
        public override int GetHashCode()
        {
            int hash = this.Id.GetHashCode() * this.Name.GetHashCode();
            return hash;
        }
        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Person)
                {
                    Person other = obj as Person;

                    if (this == other)
                        return true;

                    if (!this.Id.Equals(other.Id))
                        return false;

                    if (!this.Name.Equals(other.Name))
                        return false;

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
    class Program
    {
        static void HashDemo()
        {
            HashSet<int> intSet = new HashSet<int>();

            intSet.Add(1);
            intSet.Add(1);
            intSet.Add(2);

            foreach (int item in intSet)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Person p1 = new Person { Id = 1, Name = "joy" };
            //Person p2 = p1;
            //Person p2 = new Person { Id = 1, Name = "joy" };
            Person p2 = new Person { Id = 2, Name = "joy" };

            HashSet<Person> people = new HashSet<Person>();
            people.Add(p1);
            people.Add(p2);

            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }
        }
        static void StackandStackofTDemo()
        {
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(12.34);
            //stack.Push('a');
            //stack.Push("siemens");
            //foreach (object item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("after removal");
            //stack.Pop();
            //foreach (object item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(12);
            stack.Push('a');
            stack.Push(5);
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            object lastElement = stack.Peek();
            Console.WriteLine($"last element added: {lastElement}");

            Console.WriteLine("after removal");
            stack.Pop();
            foreach (int item in stack)
            {
                Console.WriteLine(item);
            }
            IEnumerator<int> enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        static void QueueDemo()
        {
            /*
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(12.34);
            queue.Enqueue('a');
            queue.Enqueue("siemens");
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after removal");
            queue.Dequeue();
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            */
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(34);
            queue.Enqueue('a');
            queue.Enqueue(5);
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("after removal");
            queue.Dequeue();
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
        }
        static void HashTableandDictionaryDemo()
        {
            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "siemens");
            //hashtable.Add('a', 12.34);
            //hashtable.Add("s", 'f');
            ////hashtable.Add(1, 34);
            //hashtable['d'] = 34;
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            //}
            //hashtable.Remove('d');
            //Console.WriteLine("after removal");
            //foreach (DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            //}
            Dictionary<int, char> keyValuePairs = new Dictionary<int, char>();
            keyValuePairs.Add(1, 'a');
            keyValuePairs.Add(0, 'd');
            keyValuePairs.Add(3, 'b');
            //hashtable.Add(1, 34);
            keyValuePairs['d'] = 'c';
            foreach (KeyValuePair<int, char> item in keyValuePairs)
            {
                Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            }
            keyValuePairs.Remove('d');
            Console.WriteLine("after removal");
            foreach (KeyValuePair<int, char> item in keyValuePairs)
            {
                Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            }
        }
        static void SortedListDemo()
        {
            /*
            SortedList sortedList = new SortedList();
            sortedList.Add(2, 'f');
            sortedList.Add(1, "siemens");
            sortedList.Add(4, 12.34);
            //hashtable.Add(1, 34);
            sortedList[3] = 34;
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            }
            sortedList.Remove(3);
            Console.WriteLine("after removal");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            }*/
            SortedList<int,object> sortedList = new SortedList<int,object>();
            sortedList.Add(2, 'f');
            sortedList.Add(1, "siemens");
            sortedList.Add(4, 12.34);
            //hashtable.Add(1, 34);
            sortedList[3] = 34;
            foreach (KeyValuePair<int,object> item in sortedList)
            {
                Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            }
            sortedList.Remove(3);
            Console.WriteLine("after removal");
            foreach (KeyValuePair<int,object> item in sortedList)
            {
                Console.WriteLine($"key:{item.Key}, value:{item.Value}");
            }
        }
        static void Main()
        {
            SortedListDemo();
            //HashTableandDictionaryDemo();
            //StackandStackofTDemo();
            //QueueDemo();
        }
    }
}
