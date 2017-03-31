using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = -100000000;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }
            sum = sum - max;
            if (Math.Abs(sum - max) == 0)
            {
                Console.WriteLine("Yes, sum = {0}", max);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum - max));
            }
        }
    }
}
