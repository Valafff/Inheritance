using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Запись в файл
using System.IO;

//is-a

namespace Academy
{
	class Program
	{
		static void Main(string[] args)
		{
			//Human human = new Human("Иванов", "Иван", 20);
			//Student stud = new Student("Фриман", "Гордон", 25, "Квантовая физика", "КФ-005", 2, 10);
			//Teacher teacher = new Teacher("Фрасворт", "Хьюберт", 70, "Квантовая физика", 40);
			//Graduate grad = new Graduate("Симсон", "Гомер", 25, "Квантовая физика", "КФ-005", 99, 2, "Ядерные реакции при употреблении пива", 25);

			////Создание студента через передачу объекта humam
			//Student IvanStud = new Student(human, "Кулинария", "ККЩ-1", 1, 100);
			//IvanStud.printInfo();
			//Graduate IvanGrad = new Graduate(IvanStud, "Рецепт кислых щей", 99);
			//IvanGrad.printInfo();

			//Console.WriteLine(human);
			//Console.WriteLine(stud);
			//Console.WriteLine(teacher);
			//         Console.WriteLine(grad);
			//human.printInfo();
			//stud.printInfo();
			//teacher.printInfo();
			//grad.printInfo();

			Human[] group = new Human[]
			{
				new Student ("Сумкин", "Фёдор", 30, "Финансы", "ГР-01", 50, 50),
				new Student ("Сидоров", "Пётр", 24, "Финансы", "ГР-01", 35, 75),
				new Student ("Фантазия", "Закончилась", 27, "Финансы", "ГР-01", 20, 99),
				new Graduate("Гэри", "1", 20, "Клонирование", "Биология", 99, 99, "Издевательство над разнообразием", 85),
				new Teacher("Грэй", "Боб", 43, "Математика", 12)
			};
			foreach (Human groupItem in group)
			{
				Console.WriteLine(groupItem);
			}

			//Запись в файл
			//Console.WriteLine(Directory.GetCurrentDirectory());
			string directory = Directory.GetCurrentDirectory();
			string filename = "Group.txt";

			StreamWriter streamWriter = new StreamWriter(filename);
			foreach (Human groupItem in group)
			{
				streamWriter.WriteLine(groupItem);
			}
			streamWriter.Close();

			//Добавление текста
			Student stud = new Student("Фриман", "Гордон", 25, "Квантовая физика", "КФ-005", 2, 10);
			StreamWriter appendToFile = File.AppendText(filename);
			appendToFile.WriteLine(stud);
			appendToFile.Close();


			//Открытие файла после выполнения!
			string cmd = directory + "\\" + filename;
			//Передача процессу коммандную строку
			System.Diagnostics.Process.Start("notepad", cmd);

			//Чтение из файла (Вывод строки)
			Console.WriteLine($"\nПрочитано из файла {filename}:");

			StreamReader sr = new StreamReader(filename);
			string temp;
			while (!sr.EndOfStream)
			{
				temp = sr.ReadLine();
				//temp_firstName += sr.Read();
				Console.WriteLine(temp);
			}

			string temp2;
			List<Human> Grouplist = new List<Human>();	

			string temp_firstName;
			string temp_lastName;
			int temp_age;
			string temp_Specialization;
			string temp_Group;
			double temp_rating;
			double temp_attendance;
			int temp_exp;
			string temp_subj;
			int temp_progress;



			StreamReader sr2 = new StreamReader(filename);
			while (!sr2.EndOfStream)
			{

				temp_firstName ="";
				temp_lastName = "";
				temp_age = 0;
				temp_Specialization = "";
				temp_Group = "";
				temp_rating = 0;
				temp_attendance = 0;
				temp_exp = 0;
				temp_subj = "";
				temp_progress = 0;

				temp2 = sr2.ReadLine();
				string[] temp_array = temp2.Split(' ');
				for (int i = 0; i < temp_array.Length; i++)
				{
					//Console.WriteLine(temp_array[i]);
					if (temp_array[i] == "Имя")
					{
						temp_firstName = temp_array[i + 1];
					}
					if (temp_array[i] == "Фамилия")
					{
						temp_lastName = temp_array[i + 1];
					}
					if (temp_array[i] == "Возраст")
					{
						temp_age = Convert.ToInt32 (temp_array[i + 1]);
					}
					if (temp_array[i] == "Специализация:")
					{
						temp_Specialization = temp_array[i + 1];
					}
					if (temp_array[i] == "Группа:")
					{
						temp_Group = temp_array[i + 1];
					}
					if (temp_array[i] == "Рейтинг:")
					{
						temp_rating = Convert.ToDouble(temp_array[i + 1]);
					}
					if (temp_array[i] == "Посещаемость:")
					{
						temp_attendance = Convert.ToDouble(temp_array[i + 1]);
					}
					if (temp_array[i] == "Стаж:")
					{
						temp_exp = Convert.ToInt32( temp_array[i + 1]);
					}
					if (temp_array[i] == "Готовность:")
					{
						temp_progress = Convert.ToInt32((temp_array[i + 1]));
					}
				}
				if (temp_exp != 0)
				{
					Human temphuman = new Teacher(temp_lastName, temp_firstName, temp_age, temp_Specialization, temp_exp);
					Grouplist.Add(temphuman);
				}
				if (temp_Group != "" && temp_subj == "")
				{
					Human temphuman = new Student(temp_lastName, temp_firstName, temp_age, temp_Specialization, temp_Group, temp_rating, temp_attendance);
					Grouplist.Add(temphuman);
				}
				if (temp_Group != "" && temp_subj != "")
				{
					Human temphuman = new Graduate(temp_lastName, temp_firstName, temp_age, temp_Specialization, temp_Group, temp_rating, temp_attendance, temp_subj, temp_progress);
					Grouplist.Add(temphuman);
				}
				//Console.WriteLine(temp2);
			}
            sr.Close();
            Console.WriteLine("ПРОЧИТАННЫЕ ОБЪЕКТЫ");
			for (int i = 0; i < Grouplist.Count; i++)
			{
				Console.WriteLine(Grouplist[i]);
            }
        }
	}
}
