using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Basic_Queue_Operations
{
    class BasicQueueOps
    {
        static void Main(string[] args)
        {
            var operators = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var N = operators[0];
            var S = operators[1];
            var X = operators[2];
            var numbersQueue = new Queue<int>();

            for (int counter = 0; counter < N; counter++)
            {
                numbersQueue.Enqueue(numbers[counter]);
            }

            for (int counter = 0; counter < S; counter++)
            {
                numbersQueue.Dequeue();
            }

            if (numbersQueue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (numbersQueue.Count > 0)
                {
                    Console.WriteLine(numbersQueue.Min());
                }
                else
                {
                    Console.WriteLine(numbersQueue.Count);
                }
            }
        }
    }
}
