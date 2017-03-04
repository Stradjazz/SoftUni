using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length / 2; i++)
            {
                var leftIndex = i;
                var rightIndex = input.Length - 1 - i;

                var tempNum = input[leftIndex];
                input[leftIndex] = input[rightIndex];
                input[rightIndex] = tempNum;
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
