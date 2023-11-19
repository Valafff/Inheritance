using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Graduate : Student
	{
		public string graduationWorkName { get; set; }
		public int graduationWorkNamePercent { get; set; }
		public Graduate(string lastname, string firstname, int age, string speciality, string group, double rating, double attendance, string gradname, int gradWorkPerc) : base(lastname, firstname, age, speciality, group, rating, attendance)
		{
			graduationWorkName = gradname;
			graduationWorkNamePercent = gradWorkPerc;
			Console.WriteLine("GConstructor:\t" + GetHashCode());
		}
		//Перегрузка конструктора через объект human
		public Graduate(Student stud, string gradname, int gradWorkPerc) : base(stud)
		{
			graduationWorkName = gradname;
			graduationWorkNamePercent = gradWorkPerc;
			Console.WriteLine("GConstructor:\t" + GetHashCode());
		}
		~Graduate()
		{
			Console.WriteLine("GDestructor:\t" + GetHashCode());
		}
		new public void printInfo()
		{
			base.printInfo();
			Console.WriteLine($"Название итоговой работы: {graduationWorkName} Готовность итоговой работы: {graduationWorkNamePercent}%");
		}
		public override string ToString()
		{
			return base.ToString() + $" {graduationWorkName}, готовность: {graduationWorkNamePercent}%";
		}
	}

}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Academy
//{
//	class Graduate : Student
//	{
//		public string Subject { get; set; }
//		public int graduationWorkNamePercent { get; set; }

//		public Graduate
//			(
//			string lastName, string firstName, int age,
//			string speciality, string group, double rating, double attendance,
//			string subject, int perc
//			) : base(lastName, firstName, age, speciality, group, rating, attendance)
//		{
//			Subject = subject;
//			graduationWorkNamePercent = perc;
//			Console.WriteLine("GConstructor:\t" + GetHashCode());
//		}
//		public Graduate(Student student, string subject) : base(student)
//		{
//			Subject = subject;
//			Console.WriteLine("GConstructor:" + GetHashCode());
//		}
//		~Graduate()
//		{
//			Console.WriteLine("GDestructor:\t" + GetHashCode());
//		}
//		public void Info()
//		{
//			base.printInfo();
//			Console.WriteLine(Subject);
//		}
//		public override string ToString()
//		{
//			return base.ToString() + $" {Subject}";
//		}
//	}
//}
