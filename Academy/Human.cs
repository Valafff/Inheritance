using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Human
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
		public Human(string last_name, string first_name, int age)
		{
			LastName = last_name;
			FirstName = first_name;
			Age = age;
			Console.WriteLine("HConstructor:\t" + GetHashCode());
		}
		~Human()
		{
			Console.WriteLine("HDestructor:\t" + GetHashCode());
		}
		//Конструктор копирования класса human
		public Human(Human right)
		{
			this.LastName = right.LastName;
			this.FirstName = right.FirstName;
			this.Age = right.Age;
            Console.WriteLine("HCopyConstructor:"+GetHashCode());
        }
	


		public override string ToString()
		{
			return $"Фамилия {LastName} Имя {FirstName} Возраст {Age} лет.";
		}
		public void printInfo()
		{
            Console.WriteLine($"Фамилия: {LastName} Имя: {FirstName} Возраст: {Age} лет");
        }
	}
}