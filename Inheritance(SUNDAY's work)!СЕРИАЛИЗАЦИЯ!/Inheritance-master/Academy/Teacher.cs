using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
    [Serializable]
    class Teacher : Human
    {
        public string Speciality { get; set; }
        public int YearOfExperince { get; set; }

        public Teacher() :base()
        {
            this.Speciality = "No Speciality";
            this.YearOfExperince = 0;
            Console.WriteLine($"defaultConstructor: \t" + GetHashCode());
        }
        public Teacher(string firstName, string lastName, int age,
            string speciality, int yearOfExperince):base(firstName, lastName, age)
        {
            this.Speciality = speciality;
            this.YearOfExperince = yearOfExperince;
            Console.WriteLine($"TeachConstructor: \t" + GetHashCode());
        }

        ~Teacher ()
        {
            Console.WriteLine($"TeachDestructor : \t" + GetHashCode());
        }
        public override string ToString()
        {
            return base.ToString() +", " + $"{Speciality}, {YearOfExperince}";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Teacher's speciality:\t" + Speciality);
            Console.WriteLine($"Teachers's Years of experience:\t {YearOfExperince} years");
        }

    }
}
