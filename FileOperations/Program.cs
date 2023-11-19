//#define Write_To_file
//#define Read_From_file
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //Потоки ввода выводы

namespace FileOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string currentdir = Directory.GetCurrentDirectory();
			string filename = "File.txt";
			Console.WriteLine(currentdir);

#if Write_To_file

			//StreamWriter sw = new StreamWriter(filename);
			//sw.WriteLine("Hello files");
			//sw.Close();
			string cmd = $"{currentdir}\\{filename}";

			System.Diagnostics.Process.Start("notepad", cmd); 
#endif
#if Read_From_file

			//Добавление текста
			StreamWriter appendToFile = File.AppendText(filename);
			appendToFile.WriteLine("Hello2");
			appendToFile.Close();


#endif
			try
			{
				//throw new Exception("Нет такого файла");
				StreamReader sr = new StreamReader(filename);
				string buffer;

				while (!sr.EndOfStream)
				{
					buffer = sr.ReadLine();
					Console.WriteLine(buffer);
				}
				sr.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				//throw;
			}


		}
	}
}
