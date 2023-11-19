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
				new Teacher("Уайт", "Воултер", 50, "Химия", 20)
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

			//Чтение из файла
			Console.WriteLine($"\nПрочитано из файла {filename}:");

			StreamReader sr = new StreamReader(filename);
			string temp;
			while (!sr.EndOfStream)
			{
				temp = sr.ReadLine();
				Console.WriteLine(temp);
			}
			sr.Close();
		}
	}
}
