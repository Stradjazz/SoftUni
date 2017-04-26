using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You have been tasked to create a database of students, and store them in a JSON format.
First, create a class Student, which will represent our data model – it will hold our data. The Student should have Name (string), 
Age (integer), and Grades (Collection of integer numbers).
This will be enough to store our data. We’ll need a collection of Students, since we will store a lot of students. And now let’s see the 
input and output formats. The input will consist of several input lines in the following format:
{name} : {age} -> {grade1}, {grade2}, {grade3}. . .
Store every student with its name, age and given grades. The name will be a string which can contain any ASCII characters except space 
(“ “), “:”, “-”, “>”, “,”. The age will be an integer. The grades will be integer numbers.
When you receive the command “stringify”, the input sequence ends.
You should print the collection of students in the following format: [{student1},{student2}. . .]
Each student must be printed in the following format: 
{name:”{name}”,age:{age},grades:[{grade1}, {grade2}. . .]} */

namespace _2.JSON_stringify
{
    class JSONStringify
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var input = Console.ReadLine();
            while (input != "stringify")
            {
                Student currentStudent = ReadStudentInfo(input);
                students.Add(currentStudent);
                
                input = Console.ReadLine();
            }
            List<string> register = new List<string>();

            foreach (var student in students)
            {
                var registerEntry = $"{{name:\"{student.Name}\",age:{student.Age},grades:[{string.Join(", ", student.Grades)}]}}";
                register.Add(registerEntry);
            }

            Console.WriteLine($"[{string.Join(",", register)}]");
        }

        private static Student ReadStudentInfo(string input)
        {
            var tokens = input.Split(new[] { ':', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            var grades = tokens[2].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            return new Student
            {
                Name = tokens[0].Trim(),
                Age = int.Parse(tokens[1]),
                Grades = grades
            };
        }
    }
}
