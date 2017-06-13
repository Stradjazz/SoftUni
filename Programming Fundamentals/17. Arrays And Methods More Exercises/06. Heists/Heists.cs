using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    /*You are the main accountant for a group of bandits, whose main line of work is robbing banks and stores. Your job is to calculate the score from the heist, calculating 
    the price of the loot and taking the expenses into account.
    On the first line, you will receive an array with two elements. The first element represents the price of the jewels and the second – the price of the gold.
    On each of the next lines, you will receive input in the format “{loot} {heist expenses}” until you receive the command “Jail Time”. The loot will be a string containing 
    random characters. The jewels will be represented with the character “%” and the gold – with the character “$”. If you find either from the symbols it means you have found 
    one of the goodies.
    Upon receiving “Jail Time” you have to calculate the total earnings and the total expenses from the heists. If the total earnings are more or equal to the total expenses 
    print: “Heists will continue. Total earnings: {money earned}.”. Otherwise print: “Have to find another job. Lost: {money lost}.”. */
    class Heists
    {
        static void Main(string[] args)
        {
            long[] lootPrices = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long jewelPrice = lootPrices[0];
            long goldPrice = lootPrices[1];
            string command = Console.ReadLine();

            long earnings = 0;
            long expenses = 0;

            while (command != "Jail Time")
            {
                string[] commandParts = command.Split();
                string loot = commandParts[0];
                expenses += long.Parse(commandParts[1]);

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot[i] == '%')
                    {
                        earnings += jewelPrice;
                    }
                    else if (loot[i] == '$')
                    {
                        earnings += goldPrice;
                    }
                }
                
                command = Console.ReadLine();
            }

            if (earnings >= expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {earnings - expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(earnings - expenses)}.");
            }
        }
    }
}
