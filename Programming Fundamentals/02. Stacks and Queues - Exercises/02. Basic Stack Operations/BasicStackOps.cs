using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Stack_Operations
{
    class BasicStackOps
    {
        static void Main(string[] args)
        {
            var operators = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var N = operators[0];
            var S = operators[1];
            var X = operators[2];
            var numbersStack = new Stack<int>();

            for (int counter = 0; counter < N; counter++)
            {
                numbersStack.Push(numbers[counter]);
            }

            for (int counter = 0; counter < S; counter++)
            {
                numbersStack.Pop();
            }

            if (numbersStack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbersStack.Count > 0)
                {
                    Console.WriteLine(numbersStack.Min()); 
                }
                else
                {
                    Console.WriteLine(numbersStack.Count);
                }
            }

            
        }
    }
}
