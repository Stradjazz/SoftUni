using System;
using System.Collections.Generic;

namespace _05._Calculate_Sequence_with_Queue
{
    class CalcSequence
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            var sequence = new Queue<long>();
            var sequenceStep = new Queue<long>();

            sequence.Enqueue(num);
            sequenceStep.Enqueue(num);

            while (sequence.Count < 50)
            {
                sequence.Enqueue(sequenceStep.Peek() + 1);
                if (sequence.Count >= 50)
                {
                    break;
                }
                sequence.Enqueue(2 * sequenceStep.Peek() + 1);
                if (sequence.Count >= 50)
                {
                    break;
                }
                sequence.Enqueue(sequenceStep.Peek() + 2);

                sequenceStep.Enqueue(sequenceStep.Peek() + 1);
                sequenceStep.Enqueue(2 * sequenceStep.Peek() + 1);
                sequenceStep.Enqueue(sequenceStep.Peek() + 2);

                sequenceStep.Dequeue();
            }

            foreach (var number in sequence)
            {
                Console.Write($"{number} ");
            }
            
        }
    }
}
