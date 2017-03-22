using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Largest_3_Numbers
{
    //Read a list of real numbers and print largest 3 of them. If less than 3 numbers exit, print all of them.
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var largestNums = numbers.OrderByDescending(n => n).Take(3).ToList();
            Console.WriteLine(string.Join(" ", largestNums));
        }
    }
}
