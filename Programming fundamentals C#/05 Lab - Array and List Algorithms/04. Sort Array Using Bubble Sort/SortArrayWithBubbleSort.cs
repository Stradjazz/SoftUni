using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sort_Array_Using_Bubble_Sort
{
    //Read a list of integers on the first line of the console. After that, sort the array, using the Bubble Sort algorithm.

    class SortArrayWithBubbleSort
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    var currentNum = input[i];
                    var nextNum = input[i + 1];

                    if (currentNum > nextNum)
                    {
                        input[i + 1] = currentNum;
                        input[i] = nextNum;
                        swapped = true;
                    }
                }
            } while (swapped);
            Console.WriteLine(string.Join(" ", input));
          
        }
        
    }
}
