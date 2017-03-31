using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            
            int difference = 0;
            int maxDiff = 0;

            for (int i = 1; i <= n; i++)
            {
                sum1 = sum2;
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sum2 = num1 + num2;
                maxDiff = Math.Abs(sum2 - sum1);

                if (i >= 2 && maxDiff > difference)
                {
                    difference = maxDiff;
                }
            }

            if (difference == 0)
            {
                Console.WriteLine("Yes, value = {0}", sum2);
            }
            else
            {
                Console.WriteLine("No, maxdiff = {0}", difference);
            }
        }
    }
}
