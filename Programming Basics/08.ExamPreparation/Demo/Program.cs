using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rhombusStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());//input

            for (var row = 0; row < size; row++)//for cycle upper half
            {
                Console.Write(new string(' ', size - row));
                Console.Write("*");

                for (var col = 1; col <= row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int row = 1; row < size; row++)//for cycle lower part
            {
                Console.Write(new string(' ', row));
                Console.Write(" *");

                for (var col = 1; col < size - row; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

        }
    }
}
