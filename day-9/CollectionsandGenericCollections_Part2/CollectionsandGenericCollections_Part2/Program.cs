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
        static void Main()
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
    }
}
