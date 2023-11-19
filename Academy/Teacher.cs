using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher : Human
	{

		public string Speciality { get; set; }
		public int Experience { get; set; }	
		public Teacher(string lastName, string firstName, int age, string speciality, int exp):base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = exp;
            Console.WriteLine("TConstructor:\t"+GetHashCode());
        }
		~Teacher()
		{
			Console.WriteLine("TDestructor:\t" + GetHashCode());
		}

		public void printInfo()
		{
			base.printInfo();
			Console.WriteLine($"Специализация: {Speciality} Стаж: {Experience} лет");

		}
		public override string ToString()
		{
			return base.ToString() + $"Специализация: {Speciality} Стаж: {Experience} лет";
		}

	}
}
