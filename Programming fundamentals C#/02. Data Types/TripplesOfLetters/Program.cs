using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 0; a < n; a++)
            {
                for (int b = 0; b < n; b++)
                {
                    for (int c = 0; c < n; c++)
                    {
                        char left = (char)('a' + a);
                        char middle = (char)('a' + b);
                        char right = (char)('a' + c);
                        Console.WriteLine("{0}{1}{2}", left, middle, right);
                    }
                }

            }

            Console.WriteLine();
        }
    }
}
