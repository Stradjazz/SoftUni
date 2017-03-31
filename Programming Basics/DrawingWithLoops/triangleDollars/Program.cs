using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write("$");
                for (int c = 1; c < row; c++)
                {
                    Console.Write(" $");
                }

                Console.WriteLine();
            }
            
        }
    }
}
