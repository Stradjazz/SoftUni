using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    /*Write a program which receives array of integers (space-separated) and prints the minimum and maximum number, the sum of the elements and the average 
     value.*/
    class ArrayStatistics
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
