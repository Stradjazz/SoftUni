using System;
using System.Collections.Generic;

namespace _03._Decimal_to_Binary_Converter
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            var inputDecimal = int.Parse(Console.ReadLine());
            var binaryStack = new Stack<int>();
            if (inputDecimal > 0)
            {
                while (inputDecimal > 0)
                {
                    binaryStack.Push(inputDecimal % 2);
                    inputDecimal /= 2;
                }

                while (binaryStack.Count > 0)
                {
                    Console.Write(binaryStack.Pop());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
