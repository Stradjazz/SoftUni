using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_Element
{
    class MaxElement
    {
        static void Main(string[] args)
        {
            int maxQueries = int.Parse(Console.ReadLine());
            var numbersStack = new Stack<int>();
            var maxElement = new Stack<int>();
            
            for (int counter = 0; counter < maxQueries; counter++)
            {
                var queries = Console.ReadLine().Split().Select(int.Parse).ToArray();
                var number = 0;
                
                switch (queries[0])
                {
                    case 2:
                        numbersStack.Pop();
                        maxElement.Pop();
                        break;
                    case 3:
                        Console.WriteLine(maxElement.Peek());
                        break;
                    default:
                        number = queries[1];
                        numbersStack.Push(number);
                        if (maxElement.Count == 0)
                        {
                            maxElement.Push(number);
                        }
                        else
                        {
                            if (maxElement.Peek() < number)
                            {
                                maxElement.Push(number);
                            }
                            else
                            {
                                maxElement.Push(maxElement.Peek());
                            }
                        }
                              
                        break;
                }
            }
        }
    }
}
