using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You will receive an array of strings as input. Your task is to find the average character within every string in the array. As in, take every character’s ASCII code,
  sum it and divide the result by the sum of the count of all the letters in the array.
    Example:
a b ab abc abc -> a, b, a, b a, b, c, a, b, c -> sum: 978 -> Divide it by 10: 97.8 -> 97
After you find the average sum, convert it to its ASCII character representation, convert it to uppercase and print the original array, delimited by that character. */

namespace _02.Average_Character_Delimiter
{
    class AverageCharacterDelimiter
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            var charCounter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                var inputAsChar = input[i].ToCharArray();
                foreach (var element in inputAsChar)
                {
                    sum += element;
                    charCounter++;
                }
                
            }
            char average = Convert.ToChar(sum / charCounter);
            var delimiter = average.ToString().ToUpper();
            
            Console.WriteLine(string.Join($"{delimiter}", input));
        }
    }
}
