using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_String
{
    //Write a program that reads a string from the console, reverses it and prints the result back at the console.
    class ReverseString
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();

            var reversedText = new String(text.Reverse().ToArray());

            Console.WriteLine(reversedText);
        }
    }
}
