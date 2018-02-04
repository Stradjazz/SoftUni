using System;
using System.Collections.Generic;

namespace _05._Hot_Potato
{
    class HotPotato
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split();
            var maxToss = int.Parse(Console.ReadLine());

            var childrenQueue = new Queue<string>(children);
            while (childrenQueue.Count > 1)
            {
                for (int tossCounter = 1; tossCounter < maxToss; tossCounter++)
                {
                    childrenQueue.Enqueue(childrenQueue.Dequeue());
                }

                Console.WriteLine($"Removed {childrenQueue.Dequeue()}");
            }
            Console.WriteLine($"Last is {childrenQueue.Dequeue()}");
        }
    }
}
