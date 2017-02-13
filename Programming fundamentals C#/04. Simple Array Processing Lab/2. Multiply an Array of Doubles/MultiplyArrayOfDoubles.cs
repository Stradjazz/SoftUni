using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiply_an_Array_of_Doubles
{
    //Write a program to read an array of doubles, a double p, multiply each element by p and print the resulting array.

    class MultiplyArrayOfDoubles
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double multiplier = double.Parse(Console.ReadLine());
            double[] results = new double[numbers.Length];

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = numbers[i] * multiplier;
            }
            Console.WriteLine(string.Join(" ", results));
        }
    }
}
