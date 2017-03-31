using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddPairSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var pairSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum += num;
                }
                else if (i % 2 != 0)
                {
                    pairSum += num;
                }
            }

            var sum = Math.Abs(pairSum - oddSum);
            if (sum == 0)
            {
                Console.WriteLine("Yes, sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", sum);
            }

        }
    }
}
