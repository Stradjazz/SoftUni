using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Average_Student_Grades
{
    //Write a program, which reads the name of a student and their grades and adds them to the student record, then prints 
    //grades along with their average grade.
    class AverageStudentGrades
    {
        static void Main(string[] args)
        {
            var numberOfGrades = int.Parse(Console.ReadLine());
            var gradebook = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfGrades; i++)
            {
                var nameAndGrade = Console.ReadLine().Split(' ');
                var name = nameAndGrade[0];
                var grade = decimal.Parse(nameAndGrade[1]);

                if (!gradebook.ContainsKey(name))
                {
                    gradebook[name] = new List<decimal>();
                }
                gradebook[name].Add(grade);
            }
            foreach (var kvp in gradebook)
            {
                var name = kvp.Key;
                var grades = kvp.Value;
                var average = grades.Average();
                Console.Write($"{name} -> ");
                foreach (var grade in grades)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {average:F2})");
            }
        }
    }
}
