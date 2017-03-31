using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int tens = num / 10;
            int units = num % 10;

            var unitsWord = new Dictionary<int, string>
            {
                {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"},
                {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}, {10, "ten"},
                {0, "zero"}
            };
            var teensWord = new Dictionary<int, string>
            {
                {11, "eleven"}, {12, "twelve"}, {13, "thirteen"}, {14, "fourteen"},
                {15, "fifteen"}, {16, "sixteen"}, {17, "seventeen"}, {18, "eightteen"},
                {19, "nineteen"}
            };
            var tensWord = new Dictionary<int, string>
            {
                {2, "twenty"}, {3, "thirty"}, {4, "fourty"}, {5, "fifty"},
                {6, "sixty"}, {7, "seventy"}, {8, "eighty"}, {9, "ninety"},
                
            };

            if (num >= 0 && num <= 10)
            {
                Console.WriteLine(unitsWord[num]);
            }
            else if (num > 10 && num <= 19)
            {
                Console.WriteLine(teensWord[num]);
            }
            else if (num >= 20 && num <= 99)
            {
                if (units == 0)
                {
                    Console.WriteLine(tensWord[tens]);
                }
                else
                {
                    Console.WriteLine("{0} {1}", tensWord[tens], unitsWord[units]);
                }
            }
            
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
