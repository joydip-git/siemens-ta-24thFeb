using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingPersonApp.Entities
{
    public abstract class Person
    {
        string name;
        public Person()
        {

        }
        public Person(string name)
        {
            this.name = name;
        }

        public string Name { get => name; set => name = value; }
        public abstract bool IsOutstanding();
    }
}
