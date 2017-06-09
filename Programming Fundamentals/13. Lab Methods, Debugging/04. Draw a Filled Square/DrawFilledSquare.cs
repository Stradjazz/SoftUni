using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Draw_A_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintTopAndBottom(input);
            for (int i = 1; i <= input - 2; i++)
            {
                PrintBody(input);
            }
            PrintTopAndBottom(input);
        }
        static void PrintTopAndBottom(int input)
        {
            Console.WriteLine(new string('-', 2 * input));
        }
        static void PrintBody(int input)
        {
            Console.Write('-');
            for (int i = 1; i < input; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine('-');
        }
    }
}