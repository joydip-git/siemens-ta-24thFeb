using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectTypeDemo
{
    class Person //:Object
    {
        string name;
        string location;

        public Person()
        {

        }
        public Person(string name, string location)
        {
            this.name = name;
            this.location = location;
        }
        public string Name { get => name; set => name = value; }
        public string Loation { get => location; set => location = value; }

        public override bool Equals(object obj)
        {
            if (obj != null)
            {
                if (obj is Person)
                {
                    Person other = obj as Person;
                    if (other == this)
                        return true;

                    if (!this.name.Equals(other.name))
                        return false;

                    if (!this.location.Equals(other.location))
                        return false;

                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator ==(Person first, Person second)
        {
            if (!first.name.Equals(second.name))
                return false;

            if (!first.location.Equals(second.location))
                return false;

            return true;
        }

        public static bool operator !=(Person first, Person second)
        {
            if (first.name.Equals(second.name))
                return false;

            if (first.location.Equals(second.location))
                return false;

            return true;
        }
        public override string ToString()
        {
            //return this.GetType().Name;
            return $"Name:{name} and Location:{location} of type:{base.ToString()}";
        }
        public override int GetHashCode()
        {
            //return this.GetHashCode();
            const int seedValue = 23;
            int hash = 0;
            hash = this.name != null && this.name != string.Empty ? this.name.GetHashCode() * seedValue : seedValue;
            hash = this.location != null && this.location != string.Empty ? hash * this.location.GetHashCode() : hash;
            return hash;
        }
    }
    class Student : Person
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Type GetType(),
            //int GetHashCode(), 
            //bool Equals(object obj), 
            //string ToString()

            //VT-->VT
            //implicit 
            int i = 123;
            long l = i;
            //explicit
            long l1 = 1234567890123;
            int ix = (int)l1; //1. casting
            Console.WriteLine(ix);
            //int ix1 = Convert.ToInt32(l1); //2. Convert

            //RT-->RT
            //implicit (upcasting)
            Person p = new Student();
            //explicit
            //Student s = new Person(); //this downcasting is not possible
            Student s = (Student)p; //1. casting
            Student s1 = p as Student; //2. 'as' operator

            //VT<-->RT
            //VT-->RT (implicit)--Boxing
            int x = 12;
            object xObj = x;
            Console.WriteLine(xObj);
            //RT-->VT (explicit)--Unboxing
            int y = (int)xObj;//casting
            Console.WriteLine(y);
            */
            Person p1 = new Person("anil", "bangalore");
            //Console.WriteLine(p1);
            Person p2 = new Person("anil", "bangalore");
            int p1Hash = p1.GetHashCode();
            int p2Hash = p2.GetHashCode();
            if (p1Hash == p2Hash)
            {
                if (p1.Equals(p2))
                    Console.WriteLine("same");
            }
            else
                Console.WriteLine("not same");
            /*
            //if(p1==p2)
            //if(p1.Equals(null)
            if (p1.Equals(12))
            {
                //if(p1.Equals(p1))
                //if(p1.Equals(p2)) where Person p2= p1;
                //if (p1.Equals(p2))
                Console.WriteLine("same");
            }
            else
                Console.WriteLine("not same");

            int a = 12;
            int b = 12;
            
            if (p1 == p2)
            {
                Console.WriteLine("same");
            }
            else
                Console.WriteLine("not same");
            
            if (a == b)
            {

            }
            if (a.Equals(b))
                Console.WriteLine("same");
                */
                
        }
    }
}
