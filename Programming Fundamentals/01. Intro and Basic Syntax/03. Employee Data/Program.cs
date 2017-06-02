using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Employee_Data
{
    /* Write a program to read data about an employee and print it on the console with the appropriate formatting. 
       The order the input comes in is as such:
       Name – no formatting
       Age – no formatting
       Employee ID – 8-digit padding (employee id 356 is 00000356)
       Monthly Salary – formatted to 2 decimal places (2345.56789 becomes 2345.56) */
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employeeID = int.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeID.ToString("D8")}");
            Console.WriteLine($"Salary: {salary:F2}");

        }
    }
}
