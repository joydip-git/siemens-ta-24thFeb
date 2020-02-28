using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingPersonApp.Entities
{
    public class Student : Person
    {
        int marks;
        public Student()
        {

        }
        public Student(string name, int marks) : base(name)
        {
            this.marks = marks;
        }

        public int Marks { get => marks; set => marks = value; }

        public override bool IsOutstanding()
        {
            if (this.marks >= 80)
                return true;
            else
                return false;
        }
        public string Show()
        {
            return $"{this.Name} has scored {this.marks} marks";
        }
    }
}
