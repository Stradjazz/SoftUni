using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*Lottery is exciting. What is not, is checking a million tickets for winnings only by hand. So, you are given the task to create 
a program which automatically checks if a ticket is a winner. You are given a collection of tickets separated by commas and spaces. 
You need to check every one of them if it has a winning combination of symbols.
A valid ticket should have exactly 20 characters. The winning symbols are '@', '#', '$' and '^'. But in order for a ticket to be a winner
the symbol should uninterruptedly repeat for at least 6 times in both the tickets left half and the tickets right half. 
For example, a valid winning ticket should be something like this: 
"Cash$$$$$$Ca$$$$$$sh" 
The left half "Cash$$$$$$" contains "$$$$$$", which is also contained in the tickets right half "Ca$$$$$$sh". A winning ticket should 
contain symbols repeating up to 10 times in both halves, which is considered a Jackpot (for example: "$$$$$$$$$$$$$$$$$$$$").  */

namespace _04.Winning_Ticket
{
    class WinningTicket
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var pattern = @"([$#^@])\1{5,9}";
            //([$#^@]) the symbols to match in group brackets, \1 repeats the match of the group 1, {5,9} count min, max
            var regex = new Regex(pattern);

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine($"invalid ticket");
                    continue;
                }
                var firstHalf = ticket.Substring(0, ticket.Length / 2);
                var secondHalf = ticket.Substring(ticket.Length / 2);

                var matchFirst = regex.Match(firstHalf);
                var matchSecond = regex.Match(secondHalf);

                if (matchFirst.Success && matchSecond.Success)
                {
                    var counter = Math.Min(matchFirst.Length, matchSecond.Length);
                    var winningSymbol = matchFirst.Value[0];
                    if (counter == 10)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {counter}{winningSymbol} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {counter}{winningSymbol}");
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
