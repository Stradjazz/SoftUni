using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_A_Word
{
    /*Write a program, which combines n characters and prints on a single line the combinations of these characters. On the first line, 
     you will receive n – the number of lines, which will follow. On the next n lines – you will receive lower and uppercase characters 
     from the English alphabet. Print the word in the format: The word is: {word}*/
    class MakeAWord
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                word += ch;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
