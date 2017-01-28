using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Greater_Of_Two_Values
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if (type == "int")
            {
                int firstInt = int.Parse(Console.ReadLine());
                int secondInt = int.Parse(Console.ReadLine());
                int maxInt = GetMaxInt(firstInt, secondInt);
                Console.WriteLine(maxInt);
            }
            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());
                char maxChar = GetMaxChar(firstChar, secondChar);
                Console.WriteLine(maxChar); 
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();
                string maxString = GetMaxString(firstString, secondString);
                Console.WriteLine(maxString);
            }
        }
        static int GetMaxInt(int firstInt, int secondInt)
        {
            return Math.Max(firstInt, secondInt);
        }
        static char GetMaxChar(char firstChar, char secondChar)
        {
            if ((int)firstChar >= (int)secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        static string GetMaxString(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
