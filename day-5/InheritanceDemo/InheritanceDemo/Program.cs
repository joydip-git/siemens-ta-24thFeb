using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using EntityExtension;

namespace InheritanceDemo
{
    class Program
    {
        static void Main()
        {
            string[] subjectsTeach = new string[] { "C#", "Java" };
            Person trainerJoy = new Trainer("JOydip", subjectsTeach);
            //Trainee t = (Trainee) new Person();


            Trainer trainer = (Trainer) trainerJoy;
            Trainee trainee = new Trainee("murali", "C#");

            PrintInfo(trainee);
            PrintInfo(trainerJoy);
        }
        public static void PrintInfo(Person person)
        {

            Console.WriteLine(person.Print());
            //trainer.PrintTrainerInfo();
        }

        //public static void PrintInfo(Trainer person)
        //{

        //}
        //public static void PrintInfo(Trainee person)
        //{

        //}

    }
}
