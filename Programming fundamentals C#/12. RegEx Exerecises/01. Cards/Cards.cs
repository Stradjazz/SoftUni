using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*You will be given sequences of playing cards. Your task is to print the valid ones of them, separated by a comma and a space.
The VALID playing cards have:
•	power – 2, 3, 4… 10, J, Q, K, A.
•	suit – S, H, D, C
A card is formed by its power and its suit in the following format: {power}{suit}. . ., but ONLY those with valid power and valid suit, 
should be considered VALID.
So a valid car would look like this: KS, 10S, 2D, 3D. */
namespace _01.Cards
{
    class Cards
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"([1]?[0-9JQKA])([SHDC])";
            var regex = new Regex(pattern);

            var cards = new List<string>();
            var validCards = regex.Matches(input);

            foreach (Match card in validCards)
            {
                var power = 0;
                if (int.TryParse(card.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                cards.Add(card.Value);
            }
            Console.WriteLine(string.Join(", ", cards));


        }
    }
}
