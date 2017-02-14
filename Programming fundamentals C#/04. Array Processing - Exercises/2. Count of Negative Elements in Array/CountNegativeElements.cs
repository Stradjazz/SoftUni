using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_of_Negative_Elements_in_Array
{
    //Read an integer N and on the next N lines read an array of integers. Then, find the count of negative elements in the array.
    class CountNegativeElements
    {
        static void Main(string[] args)
        {
            int limitOfNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[limitOfNumbers];
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] < 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
