using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_Of_Chars
{
    /*Write a program, which sums the ASCII codes of n characters and prints the sum on the console. 
     On the first line, you will receive n – the number of lines, which will follow. On the next n lines – you 
     will receive letters from the Latin alphabet.
     Print the total sum in the following format: The sum equals: {totalSum}*/
    class SumOfChars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalSum = 0;

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                totalSum += ch;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
