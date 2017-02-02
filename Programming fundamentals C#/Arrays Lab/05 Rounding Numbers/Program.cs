using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Rounding_Numbers
{
    class RoundingNumbers
    {
        /*Write a program to read an array of real numbers (space separated values), 
          round them to the nearest integer in “away from 0” style and print the output as in the examples below.*/
        static void Main(string[] args)
        {
            double[] numsArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var number in numsArray)
            {
                int roundedNum = (int)Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {roundedNum}");
            }
        }
    }
}
