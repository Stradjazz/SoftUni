using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            //upper half

            for (var row = 0; row < n; row++)
            {
                Console.Write(new string(' ', (n - 1) - row));
                Console.Write("*");

                for (var col = 1; col <= row; col++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }//end for loop upper part

            //lower part

            for (var row = 1; row < n; row++)
            {
                Console.Write(new string(' ', row));
                Console.Write("*");

                for (var col = 1; col < n - row; col++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }//end for loop lower part
        }
    }
}
