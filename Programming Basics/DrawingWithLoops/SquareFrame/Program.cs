using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("+");
            for (var row = 0; row < (n-2); row++)
            {
                Console.Write(" -");
                
            }
            Console.WriteLine(" +");

            for (var midCol = 0; midCol < n-2; midCol++)
            {
                Console.Write("|");
                for (var midRow = 0; midRow < n-2; midRow++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (var row = 0; row < (n - 2); row++)
            {
                Console.Write(" -");

            }
            Console.WriteLine(" +");
        }
    }
}
