using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _06.Directories
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<double> Grades { get; set; }
    }
    class Directories
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("Students"))
            {
                Directory.CreateDirectory("Students");
            }
            if (!File.Exists("Students/database.schoolfile"))
            {
                File.Create("Students/database.schoolfile");
            }
            Dictionary<string, Student> studentsByName = new Dictionary<string, Student>();

            string[] storedStudents = File.ReadAllLines("Students/database.schoolfile");

            foreach (var studentInfo in storedStudents)
            {
                string[] studentParams = studentInfo.Split(new[] { '|', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Student newStudent = new Student();

                newStudent.Name = studentParams[0];
                newStudent.Age = int.Parse(studentParams[1]);
                newStudent.Grades = studentParams.Skip(2).Select(double.Parse).ToList();

                studentsByName.Add(newStudent.Name, newStudent);
            }

            string inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputParams.Length >= 3)
                {
                    try
                    {
                        Student newStudent = new Student();

                        newStudent.Name = inputParams[0];
                        newStudent.Age = int.Parse(inputParams[1]);
                        newStudent.Grades = inputParams.Skip(2).Select(double.Parse).ToList();

                        studentsByName.Add(newStudent.Name, newStudent);
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Failed to register student. Student already exists");
                    }
                }
                else
                {
                    try
                    {
                        string studentName = inputParams[0];
                        studentsByName[studentName].Grades.AddRange(inputParams.Skip(1).Select(double.Parse));
                    }
                    catch (KeyNotFoundException)
                    {
                        Console.WriteLine("Failed to access student. Student doesn't exist.");
                    }
                }

                inputLine = Console.ReadLine();
            }
            File.WriteAllLines("Students/database.schoolfile", studentsByName.OrderBy(x => x.Key).Select(x => x.Value)
                .Select(x => string.Format("{0} | {1} | {2}", x.Name, x.Age, string.Join(", ", x.Grades))));
        }
    }
}
