using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Count_Occurrences_of_Larger_Nums
{
    //Read an array of real numbers and a number p. Find how many elements are bigger than p in the array and print the count.
    class CountOccurences
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double givenElement = double.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > givenElement)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
