using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var count = 0;
            var prevNum = 0;
            var max = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (i == 0 || num > prevNum)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                prevNum = num;
                if (count > max)
                {
                    max = count;
                }
            }
            Console.WriteLine(max);
        }
    }
}
