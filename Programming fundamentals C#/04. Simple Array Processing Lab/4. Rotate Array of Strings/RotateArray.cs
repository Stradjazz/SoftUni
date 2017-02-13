using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rotate_Array_of_Strings
{
    //Write a program to read an array of strings, rotate it to the right and print its rotated elements.
    class RotateArray
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            string[] rotatedArray = new string[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                rotatedArray[i + 1] = array[i];
            }

            var lastElement = array[rotatedArray.Length - 1];
            rotatedArray[0] = lastElement;

            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}
