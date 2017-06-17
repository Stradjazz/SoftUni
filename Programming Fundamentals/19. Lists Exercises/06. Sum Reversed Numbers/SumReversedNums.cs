using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    //Write a program that reads sequence of numbers, reverses their digits, and prints their sum.
    class SumReversedNums
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            long sum = 0;
            int reversedNum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];
                reversedNum = ReverseInt(currentNum);
                sum += reversedNum;
            }

            Console.WriteLine(sum);
        }
        public static int ReverseInt(int currentNum)
        {
            int result = 0;
            while (currentNum > 0)
            {
                result = result * 10 + currentNum % 10;
                currentNum /= 10;
            }
            return result;
        }
    }
}
