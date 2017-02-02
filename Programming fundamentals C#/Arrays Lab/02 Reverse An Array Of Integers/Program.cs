using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Reverse_An_Array_Of_Integers
{
    class ReverseArrayOfIntegers
    {
        //Write a program to read an array of integers, reverse it and print its elements. 
        //The input consists of a number n (the number of elements) + n integers, each as a separate line. 
        //Print the output on a single line (space separated).
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
            }

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
