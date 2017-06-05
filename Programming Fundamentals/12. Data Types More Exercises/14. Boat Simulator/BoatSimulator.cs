using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    /*You have the task to write a simulator of a boat race. You will receive two characters, which will represent the two boats. 
    After that you will receive n random strings. Each string on an odd line represents the speed of the first boat and on an even line – 
    the speed of the second boat. The boat moves with the count of the tiles, equal to the length of the given string. The first boat, 
    which reaches 50 tiles is the winner. Our boats can be upgradable, which means when we receive the string “UPGRADE” we add 3 to 
    the ASCII codes of both of the boats characters and after that, we use those characters to represent the boats. If you receive
    “UPGRADE”, you should not move the boats.
    If one of the boats reaches 50 moves – print the character of the winner and stop taking any input. If neither of the
    boats reach 50 moves – print the boat, which reached the most moves.*/
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int firstBoatCount = 0;
            int secondBoatCount = 0;

            for (int i = 1; i <= n; i++)
            {
                if (firstBoatCount < 50 && secondBoatCount < 50)
                {
                    string input = Console.ReadLine();

                    if (input == "UPGRADE")
                    {
                        firstBoat = (char)(firstBoat + 3);
                        secondBoat = (char)(secondBoat + 3);
                    }
                    else
                    {
                        if (i % 2 != 0)
                        {
                            firstBoatCount += input.Length;
                        }
                        else
                        {
                            secondBoatCount += input.Length;
                        }
                    }
                }   
            }
            int winner = Math.Max(firstBoatCount, secondBoatCount);
            if (winner == firstBoatCount || firstBoatCount >= 50)
            {
                Console.WriteLine(firstBoat);
            }
            else
            {
                Console.WriteLine(secondBoat);
            }
        }
    }
}
