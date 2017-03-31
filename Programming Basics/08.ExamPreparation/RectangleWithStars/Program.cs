using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('%', n * 2));
            Console.WriteLine();

            if (n % 2 == 0)
            {
                for (var row = 1; row < n; row++)
                {
                    for (var col = 0; col < 2 * n; col++)
                    {
                        if ((col == n - 1 && row == n / 2) || (col == n && row == n / 2))
                        {
                            Console.Write("*");
                        }
                        else if (col == 0 || col == (2 * n) - 1)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }//end for col
                    Console.WriteLine();
                }//end for row
            }//end if
            else
            {
                for (var row = 1; row <= n; row++)
                {
                    for (var col = 0; col < 2 * n; col++)
                    {
                        if ((col == n - 1 && row == (n + 1) / 2) || (col == n && row == (n + 1) / 2))
                        {
                            Console.Write("*");
                        }
                        else if (col == 0 || col == (2 * n) - 1)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }//end for col
                    Console.WriteLine();
                }
            }//emd else
            Console.Write(new string('%', n * 2));
            Console.WriteLine();
        }
    }
}
