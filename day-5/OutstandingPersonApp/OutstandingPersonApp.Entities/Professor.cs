using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutstandingPersonApp.Entities
{
    public class Professor : Person
    {
        int booksPublished;
        public Professor()
        {

        }
        public Professor(string name, int books) : base(name)
        {
            this.booksPublished = books;
        }
        public int BooksPublished { get => booksPublished; set => booksPublished = value; }

        public override bool IsOutstanding()
        {
            return this.booksPublished >= 5 ? true : false;
        }

        public string Print()
        {
            return $"{this.Name} has published {this.booksPublished} books";
        }
    }
}
