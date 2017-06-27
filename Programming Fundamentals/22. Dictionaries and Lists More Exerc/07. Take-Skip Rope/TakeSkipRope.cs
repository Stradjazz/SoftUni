using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Take_Skip_Rope
{
    /* Write a program, which reads a string and skips through it, extracting a hidden message. The algorithm you have to implement is as follows:
    Let’s take the string “skipTest_String044170” as an example.  Take every digit from the string and store it somewhere. After that, remove all the digits from the string. After this operation, you 
    should have two lists of items: the numbers list and the non-numbers list:
    •	Numbers list: [0, 4, 4, 1, 7, 0]
    •	Non-numbers: [s, k, i, p, T, e, s, t, _, S, t, r, i, n, g]
    After that, take every digit in the numbers list and split it up into a take list and a skip list, depending on whether the digit is in an even or an odd index:
    •	Numbers list: [0, 4, 4, 1, 7, 0]
    •	Take list: [0, 4, 7]
    •	Skip list: [4, 1, 0]
    Afterwards, iterate over both of the lists and skip {skipCount} characters from the non-numbers list, then take {takeCount} characters and store it in a result string. Note that the skipped characters 
    are summed up as they go. 
    After that, just print the result string on the console.*/
    class TakeSkipRope
    {
        static void Main(string[] args)
        {
            var codedMessage = Console.ReadLine().ToCharArray().ToList();

            var numList = codedMessage
                .Where(x => IsNumber(x))
                .Select(x => int.Parse(x.ToString()))
                .ToList();

            codedMessage = codedMessage
                .Where(x => !IsNumber(x))
                .ToList();

            var takeList = numList.Where((x, i) => i % 2 == 0).ToList();
            var skipList = numList.Where((x, i) => i % 2 != 0).ToList();

            var decodedMessage = string.Empty;

            for (int i = 0; i < takeList.Count; i++)
            {
                decodedMessage += string.Join(null, codedMessage.Select(x => x).Take(takeList[i]));
                codedMessage = codedMessage.Skip(skipList[i] + takeList[i]).ToList();
            }

            Console.WriteLine(decodedMessage);

        }

        private static bool IsNumber(char symbol)
        {
            return (symbol >= '0' && symbol <= '9');
        }
    }
}
