using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfNumbers = int.Parse(Console.ReadLine());
            for (int number = 1; number <= amountOfNumbers; number++)
            {
                int digits = number;
                int sumOfDigits = 0;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool check = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{number} -> {check}");
            }
        }
    }
}
