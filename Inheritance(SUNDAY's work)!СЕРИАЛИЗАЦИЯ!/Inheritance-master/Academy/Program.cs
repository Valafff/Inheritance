//#define PRINTOUT_INHERITANCE

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Academy
{
    class Program
    {
        public static readonly string delimiter = "\n________________________________________\n";
        static void Main(string[] args)
        {
#if PRINTOUT_INHERITANCE
            Human human = new Human("James", "Taylor", 20);
            // Console.WriteLine(human);
            human.Print();
            Console.WriteLine(delimiter);

            Student student = new Student()
            {
                _FirstName = "Vlad",
                _LastName = "Volchik",
                Age = 35,
                Speciality = "SoftWare Developer",
                Group = "BV321",
                Rating = 95,
                Attendance = 100
            };
            //Console.WriteLine(student);
            student.Print();
            Console.WriteLine(delimiter);

            Teacher techer = new Teacher()
            {
                _FirstName = "Gomez",
                _LastName = "Jordan",
                Age = 35,
                Speciality = "Javascript",
                YearOfExperince = 15
            };
            //Console.WriteLine(student);
            techer.Print();
            Console.WriteLine(delimiter);


            Graduate graduate = new Graduate("Jones", "Parker", 55, "Gymnastics",
                "BH876", 98, 100, "History of Gymnatics");
            graduate.Print();
            Console.WriteLine(delimiter);

#endif


            Group myGroup = new Group();
            // Добавление преподавателей, студентов и дипломников в группу
            myGroup.Teachers.Add(new Teacher
            {
                _FirstName = "John",
                _LastName = "Daniel",
                Age = 35,
                Speciality = "Javascript",
                YearOfExperince = 15
            });
            myGroup.Students.Add(new Student
            {
                _FirstName = "Vlad",
                _LastName = "Volchik",
                Age = 35,
                Speciality = "SoftWare Developer",
                Group = "BV321",
                Rating = 95,
                Attendance = 100
            });
            myGroup.Graduates.Add(new Graduate
            {
                _FirstName = "Jones",
                _LastName = "Parker",
                Age = 55,
                Speciality = "Gymnastics",
                Group = "BH876",
                Rating = 98,
                Attendance = 100,
                ThesisTitle = "History of Gymnatics"
            });

            // Вывод группы на экран
            Console.WriteLine("Group Members:");
            DisplayGroup(myGroup);

            //string textfilepath = @"C:\SunFile\Sunny\C#DATADIRECTOR\testfile1.txt";
            ////writing Array to that file
            //File.WriteAllLines(textfilepath, myGroup);

            ////read stream from the file

            //foreach (string cust in File.ReadAllLines(textfilepath))
            //{
            //    Console.WriteLine($"Group : {myGroup}");
            // }

            // Сохранение группы в файл
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Group.txt");
            SaveGroupToFile(myGroup, filePath);

            //// Загрузка группы из файла
            Group loadedGroup = LoadGroupFromFile(filePath);

            //// Вывод загруженной группы на экран
            Console.WriteLine("\nLoaded Group Members:");
            DisplayGroup(loadedGroup);

        }

        static void DisplayGroup(Group group)
        {
            foreach (var teacher in group.Teachers)
            {

                teacher.Print();

            }

            foreach (var student in group.Students)
            {
                student.Print();

            }

            foreach (var graduate in group.Graduates)
            {
                graduate.Print();

            }
        }

        //Group save to file using FilePath 
        static void SaveGroupToFile(Group group, string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, group);
                }

                Console.WriteLine($"Group saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Saving group to file fail: {ex.Message}");
            }
        }

        static Group LoadGroupFromFile(string filePath)
        {
            try
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    return (Group)formatter.Deserialize(fileStream);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loading group from file encounter error: {ex.Message}");
                return null;
            }
        }

       
    }
}
