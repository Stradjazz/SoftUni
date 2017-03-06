using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Japanese_Roulette
{
    /*Russian roulette is a game of chance where a single player places a single bullet in a revolver, spins the cylinder, 
     points the muzzle against their head and pulls the trigger. Japanese people however are not that brave (crazy) so they play with toy guns.
    Every player can spin the cylinder with different strength. The numeric representation of the strength is with how many places they can move 
    the bullet while spinning. Note that the cylinder has only 6 places but the strength could be much more than 6 due to several 
    rotations of the cylinder.  
    You are given an array of integers which represent the cylinder of the revolver where 0 means empty and 1 represents the bullet. 
    There is exactly one bullet in the cylinder.
    You will receive another array, this time of strings where every index is a different player and every value is the strength of the player and 
    the direction to which the player rotates the cylinder.
    The elements in the array will be separated by spaces. The power and the direction will be separated by a comma (”,”) e.g.: “111,Left”. 
    The muzzle IS at index 2 of the cylinder. If the element at that position is 1, the current player loses the game.
 
    Note! After a player pulls the trigger the cylinder spins with one position to the right. 
    The next player starts spinning with the new state of the cylinder.
    Assume that the order of the players is according to their places in the array. The player with index 0 shots first, index 1-second and so on…
    Your task is to go through all players, and see if anyone will shoot himself with the toy gun. */
    class JapaneseRoulette
    {
        static void Main(string[] args)
        {
            var cylinder = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var players = Console.ReadLine()
                .Split()
                .ToList();

            var deadMan = false;
            var deadPlayer = 0;

            foreach (var player in players)
            {
                var spinInfo = player
                    .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => a.Trim())
                    .ToArray();

                var spinStrength = int.Parse(spinInfo[0]) % cylinder.Count;
                var spinDirection = spinInfo[1];

                if (spinDirection == "Left")
                {
                    cylinder = SpinLeft(cylinder, spinStrength);

                }
                else if (spinDirection == "Right")
                {
                    cylinder = SpinRight(cylinder, spinStrength);
                }

                if (cylinder[2] == 1)
                {
                    deadMan = true;
                    deadPlayer = players.IndexOf(player);
                    break;
                }
                cylinder = SpinRight(cylinder, 1); //Trigger
            }

            if (deadMan)
            {
                Console.WriteLine($"Game over! Player {deadPlayer} is dead.");
            }
            else
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }

        private static List<int> SpinLeft(List<int> cylinder, int spinStrength)
        {
            for (int i = 0; i < spinStrength; i++)
            {
                cylinder = cylinder
                    .Skip(1)
                    .Concat(cylinder.Take(1))
                    .ToList();
            }
            return cylinder;
        }

        private static List<int> SpinRight(List<int> cylinder, int spinStrength)
        {
            for (int i = 0; i < spinStrength; i++)
            {
                cylinder = cylinder
                    .Skip(cylinder.Count - 1)
                    .Concat(cylinder.Take(cylinder.Count - 1))
                    .ToList();
            }
            return cylinder;
        }

    }
}
