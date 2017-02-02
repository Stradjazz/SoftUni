using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Last_K_Numbers_Sums
{
    class LastKNumbersSum
    {
        /*Enter two integers n and k. Generate and print the following sequence of n elements:
        The first element is: 1
        All other elements = sum of the previous k elements (if less than k are available, sum all of them)
        Example: n = 9, k = 5 -> 120 = 4 + 8 + 16 + 31 + 61 */

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var sequence = new long[n];
            sequence[0] = 1;

            for (int currentNum = 1; currentNum < sequence.Length; currentNum++)
            {
                int initial = Math.Max(0, currentNum - k);
                int end = currentNum - 1;
                long sum = 0;

                for (int sumNum = initial; sumNum <= end; sumNum++)
                {
                    sum += sequence[sumNum];
                }
                sequence[currentNum] = sum;
            }

            for (int i = 0; i < sequence.Length; i++)
            {
                Console.WriteLine(sequence[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
