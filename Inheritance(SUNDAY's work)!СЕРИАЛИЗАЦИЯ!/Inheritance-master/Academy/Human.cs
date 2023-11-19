using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    [Serializable]
    internal class Human
    {
        public string _FirstName { get; set; }
        public string _LastName  { get; set; }
        public int Age { get; set; }

        public Human()
        {
            _FirstName = "No Name";
            _LastName = "No Name";
            Age = 0;

        }
        public Human(string firstName, string lastName, int age)
        {
            _FirstName = firstName;
            _LastName = lastName;
            Age = age;
            Console.WriteLine($"HumanConstructor: \t " + GetHashCode());
        }

       ~Human()
        {
            Console.WriteLine($"HumanDestructor : \t" + GetHashCode());

        }

        public virtual void Print()
        {
            Console.WriteLine(this.GetType());
             Console.WriteLine("First name:\t" + _FirstName);
            Console.WriteLine("Last  name:\t" + _LastName);
            Console.WriteLine("Age:\t\t" + Age);
        }
        public override string ToString()
        {
            return $"{_FirstName} {_LastName} {Age} years old";
        }
    }
}
