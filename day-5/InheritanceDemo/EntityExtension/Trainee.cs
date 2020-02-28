using Entities;

namespace EntityExtension
{
    public class Trainee : Person
    {
        string subjectToLearn;

        public Trainee()
        {

        }
        public Trainee(string name, string subject) : base(name)
        {
            this.subjectToLearn = subject;
        }

        public string SubjectToLearn { get => subjectToLearn; set => subjectToLearn = value; }

        //public new string Print()
        public override string Print()
        {
            return $"{base.Print()} and subject: {subjectToLearn}";
        }
    }
}
