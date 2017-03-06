using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Japanese_Roulette_II
{
    class JapaneseRouletteII
    {
        static void Main(string[] args)
        {
            int[] cylinder = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string[] rotation = Console.ReadLine().Split(' ').ToArray();
           
           
            var initialPosition = 0;
            var endPosition = 0;
            bool dead = false;
 
            for (int i = 0; i < cylinder.Length; i++)
            {
                if (cylinder[i] == 1)
                {
                    initialPosition = i;
                }
            }
            for (int i = 0; i < rotation.Length; i++)
            {
                dead = false;
                string[] currentCommand = rotation[i].Split(',');
                var force = int.Parse(currentCommand[0]);
                var direction = currentCommand[1];
 
                switch (direction)
                {
                    case "Right":
                        endPosition = (initialPosition + force) % cylinder.Length;
                        initialPosition = endPosition;
                        break;
                    case "Left":
                        endPosition = (initialPosition - force) % cylinder.Length;
                        if (endPosition < 0)
                        {
                            endPosition += cylinder.Length;
                        }
                        initialPosition = endPosition;
                        break;
                }
 
                if (endPosition == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    dead = true;
                    break;
                }
                initialPosition++;
               
            }
            if (!dead)
            {
                Console.WriteLine($"Everybody got lucky!");
            }
        }
    }
}
