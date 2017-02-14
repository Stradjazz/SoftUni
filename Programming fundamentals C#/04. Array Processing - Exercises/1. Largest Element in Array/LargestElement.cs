using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Largest_Element_in_Array
{
    //Read an integer N and on the next N lines read an array of integers. Then, find its largest element.
    class LargestElement
    {
        static void Main(string[] args)
        {
            int limitOfNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[limitOfNumbers];
            int maxNumber = int.MinValue;

            for (int i = 0; i < limitOfNumbers; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
