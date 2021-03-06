﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_English_Name_Of_Last_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            long lastDigit = Math.Abs(input) % 10;
            string printNameOfDigit = GetLastDigit(lastDigit);
            Console.WriteLine(printNameOfDigit);
        }
        static string GetLastDigit(long lastDigit)
        {
            
            string nameOfDigit = string.Empty;
            switch (lastDigit)
            {
                case 0: nameOfDigit = "zero"; break;
                case 1: nameOfDigit = "one"; break;
                case 2: nameOfDigit = "two"; break;
                case 3: nameOfDigit = "three"; break;
                case 4: nameOfDigit = "four"; break;
                case 5: nameOfDigit = "five"; break;
                case 6: nameOfDigit = "six"; break;
                case 7: nameOfDigit = "seven"; break;
                case 8: nameOfDigit = "eight"; break;
                case 9: nameOfDigit = "nine"; break;
            }
            return nameOfDigit;
        }
    
    }
}
