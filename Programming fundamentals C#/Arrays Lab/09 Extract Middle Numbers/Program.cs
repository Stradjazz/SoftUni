using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Extract_Middle_Elements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = numbers.Length;
            int[] result;

            if (n == 1)
            {
                result = new int[1];
                result[0] = numbers[0];
            }

            else if (n % 2 == 0)
            {
                result = new int[2];
                result[0] = numbers[n / 2 - 1];
                result[1] = numbers[n / 2];
            }

            else
            {
                result = new int[3];
                result[0] = numbers[n / 2 - 1];
                result[1] = numbers[n / 2];
                result[2] = numbers[n / 2 + 1];
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
