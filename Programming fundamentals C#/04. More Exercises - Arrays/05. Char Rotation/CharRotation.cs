using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    /*  You are given two lines of input: a string and an int array. Modify the elements in the first array by the second array, 
        following these conditions:
        If the element at the position is even, subtract its value to the ASCII code of the character on the same position.
        If the element at the position is odd, add its value to the ASCII code of the character on the same position.
        After that, print the resulting string. */
    class CharRotation
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().ToCharArray();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write((char)(array[i] - (char)numbers[i]));
                }
                else
                {
                    Console.Write((char)(array[i] + (char)numbers[i]));
                }
            }

            Console.WriteLine();
        }
    }
}
