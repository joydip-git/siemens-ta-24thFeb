using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonApp
{
    class Person : IComparable<Person>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //internalization of comparison
        public int CompareTo(Person other)
        {
            if (this.Id.CompareTo(other.Id) == 0)
                return this.Name.CompareTo(other.Name);
            else
                return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
        //public static bool operator >(Person x, Person y)
        //{
        //    if (x.Id > y.Id)
        //        return x.Name > y.Name;
        //}
        //public static bool operator <(Person x, Person y)
        //{
        //    return false;
        //}
    }
    
    //externalization of comparison
    class PersonComparsion : IComparer<Person>
    {
        private int sortChoice;
        public PersonComparsion()
        {

        }
        public PersonComparsion(int choice)
        {
            this.sortChoice = choice;
        }
        public int Compare(Person x, Person y)
        {
            int compResult;
            switch (sortChoice)
            {
                case 1:
                    compResult = x.Name.CompareTo(y.Name);
                    break;

                case 2:
                    compResult = x.Id.CompareTo(y.Id);
                    break;

                default:
                    compResult = x.Id.CompareTo(y.Id);
                    break;
            }
            return compResult;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person{ Id=2, Name="anil"},
                new Person{ Id=1, Name = "sunil"},
                new Person{ Id=3, Name="joy"}
            };

            Console.WriteLine("1. sort by name");
            Console.WriteLine("2. sort by id");
            Console.Write("enter choice[1/2]: ");
            int choice = int.Parse(Console.ReadLine());

            PersonComparsion comp = new PersonComparsion(choice);
            people.Sort(comp);
            //for (int i = 0; i < people.Count; i++)
            //{
            //    for (int j = i + 1; j < people.Count; j++)
            //    {
            //        if (comp.Compare(people[i], people[j]) > 0)
            //        {
            //            Person temp = people[i];
            //            people[i] = people[j];
            //            people[j] = temp;
            //        }
            //    }
            //}
            foreach (Person item in people)
            {
                Console.WriteLine(item);
            }

            /*
            List<int> list = new List<int> { 1, 3, 2, 4 };
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    // if (list[i] > list[j])
                    if (list[i].CompareTo(list[j]) > 0)
                    {

                    }
                }
            }
            */
        }
    }
}
