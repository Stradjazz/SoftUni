using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Reverse_Array_Of_Strings
{
    class ReverseArrayOfStrings
    {
        //Write a program to read an array of strings, reverse it and print its elements. 
        //The input consists of a sequence of space separated strings. Print the output on a single line (space separated)
        static void Main(string[] args)
        {
            string[] textArray = Console.ReadLine().Split(' ');
            for (int i = 0; i < textArray.Length / 2; i++)
            {
                var temp = textArray[i];
                var reverseIndex = textArray.Length - 1 - i;
                textArray[i] = textArray[reverseIndex];
                textArray[reverseIndex] = temp;
            }
            Console.WriteLine(string.Join(" ", textArray));
        }
    }
}
