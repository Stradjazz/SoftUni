using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    /*Create a method GetMax(int a, int b), that returns the largest of two numbers. Write a program that reads three numbers from 
    the console and prints the biggest of them. Use the GetMax(…) method you just created.*/
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int inputA = int.Parse(Console.ReadLine());
            int inputB = int.Parse(Console.ReadLine());
            int inputC = int.Parse(Console.ReadLine());

            int tempMax = GetMax(inputA, inputB);
            int max = GetMax(tempMax, inputC);

            Console.WriteLine(max);
        }

        public static int GetMax(int inputA, int inputB)
        {
            return Math.Max(inputA, inputB);
        }
    }
}
