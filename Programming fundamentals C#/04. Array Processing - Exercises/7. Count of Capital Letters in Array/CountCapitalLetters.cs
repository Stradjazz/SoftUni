using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_of_Capital_Letters_in_Array
{
    //Read an array of strings and find out how many of them are capital English letters (such as A, B, C etc.). Print the count on the console.
    class CountCapitalLetters

    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            int counter = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];
                    if (character >= 'A' && character <= 'Z')
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
