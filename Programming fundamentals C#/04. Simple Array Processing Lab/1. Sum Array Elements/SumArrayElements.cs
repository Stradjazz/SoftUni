using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Array_Elements
{
    //Write a program which reads an array of integers, calculates its sum and prints it.
    //The input consists of a number n(the number of elements) + n integers, each as a separate line.

    class SumArrayElements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            
            Console.WriteLine(sum);
        }
    }
}
