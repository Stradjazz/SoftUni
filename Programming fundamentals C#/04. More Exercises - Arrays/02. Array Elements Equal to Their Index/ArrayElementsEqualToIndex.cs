using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Elements_Equal_to_Their_Index
{
    //Read an array of integers and extract the elements which have the same value as their index.
    class ArrayElementsEqualToIndex
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == i)
                {
                    Console.Write($"{numbers[i]} "); 
                }
            }
            Console.WriteLine();
        }
    }
}
