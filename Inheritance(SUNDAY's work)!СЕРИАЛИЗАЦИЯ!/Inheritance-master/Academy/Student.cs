using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    [Serializable]
    class Student :Human
    {
        
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; }
        public double Attendance { get; set; }

        public Student(): base()
        {
            Console.WriteLine($"DefaultCtor: \t"+GetHashCode());
        }
        public Student(string firstName, string lastName, int age, string speciality, 
            string group, double rating, double attendance
              ) :base(firstName, lastName, age)
        { 
            this.Speciality = speciality;
            this.Group = group;
            this.Rating = rating;
            this.Attendance = attendance;
            
           
            Console.WriteLine($"StdConstructor :\t" + GetHashCode());
        }

        ~ Student()
        {
            Console.WriteLine($"StdDestructor : \t" + GetHashCode());
        }
        public override string ToString()
        {
            return base.ToString() + ", " + $"{Speciality}, {Group}, {Rating}, {Attendance}";
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Speciality:\t" + Speciality);
            Console.WriteLine("Group:\t\t" + Group);
            Console.WriteLine($"Rating:\t\t{ Rating} %");
            Console.WriteLine($"Attendance:\t{Attendance} %");

        }



    }
}
