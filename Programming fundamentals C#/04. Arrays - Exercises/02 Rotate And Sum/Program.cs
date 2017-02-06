using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rotate_And_Sum
{
    //Write a program to read an array of n integers (space separated on a single line) and an integer k, 
    //rotate the array right k times and sum the obtained arrays after each rotation as shown below.
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());
            int[] sum = new int[inputArray.Length];
            

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = inputArray[inputArray.Length - 1];
                for (int j = inputArray.Length - 1; j > 0; j--)
                {
                    inputArray[j] = inputArray[j - 1];
                }
                inputArray[0] = lastElement;
                for (int k = 0; k < inputArray.Length; k++)
                {
                    sum[k] += inputArray[k];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
        
    }
}
