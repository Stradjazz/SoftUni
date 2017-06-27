using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    /*Write a program, which receives a string array (space-separated), containing bytes in hexadecimal format with the digits reversed.
    Your task is to remove any elements whose length is different than 2, then reverse the digits in every number, and finally reverse the whole collection and convert every element from hexadecimal numbers 
    to characters from the ASCII table. Print the resulting string of ASCII characters on the console. */
    class ByteFlip
    {
        static void Main(string[] args)
        {
            var codedMessage = Console.ReadLine()
                .Split(' ')
                .Where(e => e.Length == 2)
                .Select(x => new string(x.Reverse().ToArray()))
                .Select(n => Convert.ToChar(Convert.ToInt32(n, 16)))
                .Reverse()
                .ToList();

            Console.WriteLine(string.Join(null, codedMessage));
        }
    }
}
