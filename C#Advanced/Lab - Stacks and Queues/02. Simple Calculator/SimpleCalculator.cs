using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Simple_Calculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var elements = input.Split(' ').Reverse().ToArray();
            var stack = new Stack<string>();

            for (int counter = 0; counter < elements.Length; counter++)
            {
                stack.Push(elements[counter]);
            }

            
            while (stack.Count > 1)
            {
                var leftOperand = int.Parse(stack.Pop());
                var operation = stack.Pop();
                var rightOperand = int.Parse(stack.Pop());

                switch (operation)
                {
                    case "+":
                        stack.Push((leftOperand + rightOperand).ToString());
                        break;
                    case "-":
                        stack.Push((leftOperand - rightOperand).ToString());
                        break;
                }
            }
                Console.WriteLine(stack.Pop());
        }
    }
}
