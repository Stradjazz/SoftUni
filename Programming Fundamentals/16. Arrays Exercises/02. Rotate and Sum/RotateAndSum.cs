using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    /*Write a program to read an array of n integers (space separated on a single line) and an integer k, rotate the array right k times 
    and sum the obtained arrays after each rotation as shown below.*/
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int[] sum = new int[numbers.Length];

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = numbers[numbers.Length - 1];
                for (int currentNum = numbers.Length - 1; currentNum > 0; currentNum--)
                {
                    numbers[currentNum] = numbers[currentNum - 1];
                }
                numbers[0] = lastElement;
                for (int k = 0; k < numbers.Length; k++)
                {
                    sum[k] += numbers[k];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
