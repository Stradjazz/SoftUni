using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You will be given a single string, containing random ASCII character. Your task is to print every character, and how many times it has been used in the string. 
namespace _01.Letter_Repetition
{
    class LetterRepetition
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();

            var charCounter = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (!charCounter.ContainsKey(letter))
                {
                    charCounter[letter] = 0;
                }
                charCounter[letter]++;
            }
            foreach (var element in charCounter)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
