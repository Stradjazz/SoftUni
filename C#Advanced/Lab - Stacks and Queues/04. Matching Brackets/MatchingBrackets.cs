using System;
using System.Collections.Generic;

namespace _04._Matching_Brackets
{
    class MatchingBrackets
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stackOpenBracketIndexes = new Stack<int>();

            for (int counter = 0; counter < input.Length; counter++)
            {
                if (input[counter] == '(')
                {
                    stackOpenBracketIndexes.Push(counter);
                }
                if (input[counter] == ')')
                {
                    var currentOpenBracketIndex = stackOpenBracketIndexes.Pop();
                    var length = (counter - currentOpenBracketIndex) + 1;
                    Console.WriteLine(input.Substring(currentOpenBracketIndex, length));
                }
            }
        }
    }
}
