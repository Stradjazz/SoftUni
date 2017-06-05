using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Number_Checker
{
    /*Write a program, which checks if a number is an integer or a floating-point number and prints either “floating-point” or “integer”, 
     *depending on the case. You will only receive numbers.*/
    class NumChecker
    {
        static void Main(string[] args)
        {
            var input = decimal.Parse(Console.ReadLine());

            if (input == Math.Truncate(input))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
