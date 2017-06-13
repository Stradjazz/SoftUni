using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Index_of_Letters
{
    /*Write a program that creates an array containing all letters from the alphabet (a-z). Read a lowercase word from the console and 
     print the index of each of its letters in the letters array.*/
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] word = Console.ReadLine().ToLower().ToCharArray();

            foreach (var letter in word)
            {
                int charIndex = alphabet.IndexOf(letter);
                Console.WriteLine($"{letter} -> {charIndex}");
            }
        }
    }
}
