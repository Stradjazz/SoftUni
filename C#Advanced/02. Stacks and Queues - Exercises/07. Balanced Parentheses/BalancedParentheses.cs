﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Balanced_Parentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }

            char[] opening = new[] { '(', '[', '{' };
            char[] closing = new[] { ')', ']', '}' };

            var stack = new Stack<char>();
            foreach (var element in input)
            {
                if (opening.Contains(element))
                {
                    stack.Push(element);
                }

                else if (closing.Contains(element))
                {
                    var lastElement = stack.Pop();
                    int openingIndex = Array.IndexOf(opening, lastElement);
                    int closingIdex = Array.IndexOf(closing, element);
                    if (openingIndex != closingIdex)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
