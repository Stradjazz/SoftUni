using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03CharactersAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = "Software University";
            char letter1 = 'B';
            char letter2 = 'y';
            char letter3 = 'e';
            string declaration = "I love programming";

            Console.WriteLine(title);
            Console.WriteLine($"{letter1}\n{letter2}\n{letter3}");
            Console.WriteLine(declaration);
        }
    }
}
