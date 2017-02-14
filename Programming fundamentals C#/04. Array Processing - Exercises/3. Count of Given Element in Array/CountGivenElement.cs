using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Count_of_Given_Element_in_Array
{
    //Read an array of integers and print how many times a given element exists in it.
    class CountGivenElement
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == element)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
