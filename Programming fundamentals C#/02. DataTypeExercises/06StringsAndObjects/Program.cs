using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object greeting = firstWord + " " + secondWord;
            string completeText = (string)greeting;

            Console.WriteLine(completeText);
        }
    }
}
