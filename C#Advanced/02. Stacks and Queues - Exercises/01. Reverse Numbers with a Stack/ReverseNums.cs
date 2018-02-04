using System;
using System.Collections.Generic;

namespace _01._Reverse_Numbers_with_a_Stack
{
    class ReverseNums
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numbersStack = new Stack<int>();

            foreach (var number in numbers)
            {
                numbersStack.Push(int.Parse(number));
            }

            while (numbersStack.Count > 0)
            {
                Console.Write($"{numbersStack.Pop()} ");
            }
            Console.WriteLine();
        }
    }
}
