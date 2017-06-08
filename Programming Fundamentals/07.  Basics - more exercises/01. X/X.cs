using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    /*Write a program, which prints an X figure with height n.
    N will be an odd number in the range [3…99]. */
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //top part
            for (int i = 0; i < n / 2; i++)
            {
                var leftRight = new string(' ', i);
                var middleSpaces = new string(' ', n - 2 - (i * 2));
                Console.Write(leftRight);
                Console.Write("x");
                Console.Write(middleSpaces);
                Console.WriteLine("x");
                
            }
            //crosspoint
            Console.Write(new string(' ', n / 2));
            Console.WriteLine("x");
            
            //bottom part
            for (int i = 0; i < n / 2; i++)
            {
                var leftRight = new string(' ', n / 2 - i - 1);
                var middleSpaces = new string(' ', (i * 2) + 1);
                Console.Write(leftRight);
                Console.Write("x");
                Console.Write(middleSpaces);
                Console.WriteLine("x");
                
            }
        }
    }
}
