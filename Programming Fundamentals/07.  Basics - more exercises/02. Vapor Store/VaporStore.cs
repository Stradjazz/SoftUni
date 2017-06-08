using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    /*After the previous problem, you feel like taking a break, so you go on the Vapor Store to buy some video games. Write a program, 
    which helps you buy the games. The valid games are the following games in this table:
    On the first line, you will receive your current balance – a floating-point number in the range [0.00…5000.00].
    Until you receive the command “Game Time”, you have to keep buying games. When a game is bought, the user’s balance decreases by 
    the price of the game. Additionally, the program should obey the following conditions:
    •	If a game the user is trying to buy is not present in the table above, print “Not Found” and read the next line.
    •	If at any point, the user has $0 left, print “Out of money!” and end the program.
    •	Alternatively, if the user is trying to buy a game which they can’t afford, print “Too Expensive” and read the next line.
    When you receive “Game Time”, print the user’s remaining money and total spent on games, rounded to the 2nd decimal place. */
    class VaporStore
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            double currentPrice = 0.0;
            double totalSpent = 0.0;
            bool found = false;
            
            while (input != "Game Time")
            {
                if (currentBalance > 0)
                {
                    if (input == "OutFall 4")
                    {
                        currentPrice = 39.99;
                        found = true;
                    }
                    else if (input == "CS: OG")
                    {
                        currentPrice = 15.99;
                        found = true;
                    }
                    else if (input == "Zplinter Zell")
                    {
                        currentPrice = 19.99;
                        found = true;
                    }
                    else if (input == "Honored 2")
                    {
                        currentPrice = 59.99;
                        found = true;
                    }
                    else if (input == "RoverWatch")
                    {
                        currentPrice = 29.99;
                        found = true;
                    }
                    else if (input == "RoverWatch Origins Edition")
                    {
                        currentPrice = 39.99;
                        found = true;
                    }
                    else
                    {
                        Console.WriteLine("Not Found");
                        found = false;
                        currentPrice = 0.0;
                    }
                    
                    if (currentBalance >= currentPrice)
                    {
                        if (found)
                        {
                            currentBalance -= currentPrice;
                            totalSpent += currentPrice;
                            Console.WriteLine($"Bought {input}");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
            }
            else
            {
                Console.WriteLine("Out of money!");
            }
        }
    }
}
