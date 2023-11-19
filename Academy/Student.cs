using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{

	class Student : Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }  //посещаемость

		public Student
			(
			string last_name, string first_name, int age,
			string speciality, string group, double rating, double attendance
			) : base(last_name, first_name, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine("SConstructor:\t" + GetHashCode());
		}
		//Перегрузка конструктора через объект human
		public Student
			( Human human,
			string speciality, string group, double rating, double attendance
			) : base(human)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine("SConstructor:\t" + GetHashCode());
		}
		//Конструктор копирования !!!!!!!!!!!!!!!!!!!!!
		public Student(Student right):base(right)
		{
			this.Speciality = right.Speciality;
			this.Group = right.Group;
			this.Rating = right.Rating;
			this.Attendance = right.Attendance;
		}
		~Student()
		{
			Console.WriteLine("SDestructor:\t"+GetHashCode());
		}



		public void  printInfo()
		{
			base.printInfo();
			Console.WriteLine($"Группа: {Group} Рейтинг: {Rating} Посещаемость: {Attendance}");
		}
		public override string ToString()
		{
			return base.ToString() + $"Группа: {Group} Рейтинг: {Rating} Посещаемость: {Attendance}";
		}
	}
}
