using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OutstandingPersonApp.Entities;

namespace OutstandingPersonApp.UserInterface
{
    class Program
    {
        static void Main()
        {
            Person[] people = new Person[]
            {
                new Professor("anil",6),
                new Student("sunil", 78),
                new Professor("mahesh",4),
                new Student("suresh", 82)
            };

            foreach (Person person in people)
            {
                if (person.IsOutstanding())
                {
                    if (person is Student)
                    {
                        Student student = person as Student;
                        Console.WriteLine(student.Show());
                    }
                    else if (person is Professor)
                    {
                        Professor professor = person as Professor;
                        Console.WriteLine(professor.Print());
                    }
                }
            }
        }
    }
}
