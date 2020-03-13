using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptionHandling
{
    class Applicant
    {
        private string name;
        private int age;
        public Applicant()
        {

        }
        public Applicant(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 15)
                {
                    age = value;
                }
                else
                {
                    AgeBelowEligibiltyLevelException ex = new AgeBelowEligibiltyLevelException("age should be at least 15 to apply");
                    throw ex;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
