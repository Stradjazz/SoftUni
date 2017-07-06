using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class LadyBugs
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            var ladybugIndexes = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var index in ladybugIndexes)
            {
                if (index < 0 || index >= fieldSize)
                {
                    continue;
                }
                field[index] = 1;
            }

            while (true)//loop for each command line
            {
                var commandLine = Console.ReadLine();
                if (commandLine == "end")
                {
                    break;
                }
                var tokens = commandLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var currentIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var steps = int.Parse(tokens[2]);

                if (currentIndex < 0 || currentIndex >= fieldSize)
                {
                    continue;
                }

                if (field[currentIndex] == 0)
                {
                    continue;
                }

                var position = currentIndex;
                field[currentIndex] = 0;

                while (true)//movement of each ladybug
                {

                    if (direction == "right")
                    {

                        position += steps;
                    }
                    else
                    {
                        position -= steps;

                    }
                    if (position >= fieldSize || position < 0)
                    {
                        break;
                    }

                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }

                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
