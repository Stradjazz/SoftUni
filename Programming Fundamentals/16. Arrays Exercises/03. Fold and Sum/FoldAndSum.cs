using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    /*Read an array of 4*k integers, fold it like shown below, and print the sum of the upper and lower 
    two rows (each holding 2 * k integers):*/
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] leftFold = new int[numbers.Length / 4];
            int[] rightFold = new int[numbers.Length / 4];
            int[] sumArray = new int[numbers.Length / 2];

            //folding
            for (int i = 0; i < numbers.Length / 4; i++) 
            {
                leftFold[i] = numbers[(numbers.Length / 4) - 1 - i];
                rightFold[i] = numbers[numbers.Length - 1 - i];
            }
            //calculating the sum
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                sumArray[i] = leftFold[i] + numbers[(numbers.Length / 4) + i];
                sumArray[(numbers.Length / 4) + i] = rightFold[i] + numbers[(numbers.Length / 2) + i];
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
