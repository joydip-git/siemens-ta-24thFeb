using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        protected string name;

        public Person()
        {
            //this.name = "no name";
        }
        public Person(string name)
        {
            this.name = name;
        }
        public string Name { get => name; set => name = value; }

        public virtual string Print()
        {
            return $"name: {name}";
        }
    }
}
