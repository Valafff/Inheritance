using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    [Serializable]
    class Graduate :Student
    {
        public string ThesisTitle { get; set; }

        public Graduate():base()
        {
            ThesisTitle = "None for now, Ask later";
            Console.WriteLine($"GradDefConstructor: \t" + GetHashCode());
        }
        public Graduate(string firstName, string lastName, int age, string speciality,
            string group, double rating, double attendance, 
            string thesisTitle) :base(firstName, lastName, age, speciality, group, rating,
                attendance)
        {
            ThesisTitle = thesisTitle;
            Console.WriteLine($"GradConstructor: \t"+GetHashCode());
        }

        ~Graduate ()
        {
            Console.WriteLine($"GradDestructor : \t" + GetHashCode());
        }
        public override string ToString()
        {
            return base.ToString() + " " + $"{ThesisTitle}";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Diploma Topic :\t" + ThesisTitle);
        }


    }
}
