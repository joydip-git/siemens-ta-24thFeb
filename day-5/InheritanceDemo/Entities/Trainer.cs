using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Trainer : Person
    {
        //string name;
        string[] subjectsToTeach;
        public Trainer()
        {

        }
        public Trainer(string name, string[] subjects) : base(name)
        {
            this.subjectsToTeach = subjects;
            //this.name = name;
        }

        public string[] SubjectsToTeach { get => subjectsToTeach; set => subjectsToTeach = value; }

        //public new string Print()
        public override string Print()
        {
            return $"{base.Print()} and Subject currently teaching: {subjectsToTeach[0]}";
        }

    }
}
