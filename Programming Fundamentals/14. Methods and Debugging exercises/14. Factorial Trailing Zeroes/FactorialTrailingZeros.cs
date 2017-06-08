using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Factorial_Trailing_Zeroes
{
    //Create a program that counts the trailing zeroes of the factorial of a given number.
    class FactorialTrailingZeros
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FactTrailingZeros(number));
        }
        static public int FactTrailingZeros(int number)
        {
            int count = 0;
            for (int i = 5; number / i >= 1; i *= 5)
            {
                count += number / i;
            }
            return count;
        }
    }
}
