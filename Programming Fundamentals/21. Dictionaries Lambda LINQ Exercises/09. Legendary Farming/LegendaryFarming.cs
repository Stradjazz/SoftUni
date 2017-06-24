using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Legendary_Farming
{
    /*You’ve beaten all the content and the last thing left to accomplish is own a legendary item. However, it’s a tedious process and requires quite a bit of farming. Anyway, you are not too pretentious – 
    any legendary will do. The possible items are:
    •	Shadowmourne – requires 250 Shards;
    •	Valanyr – requires 250 Fragments;
    •	Dragonwrath – requires 250 Motes;
    Shards, Fragments and Motes are the key materials, all else is junk. You will be given lines of input, such as 2 motes 3 ores 15 stones. Keep track of the key materials - the first that reaches 
    the 250 mark wins the race. At that point, print the corresponding legendary obtained. Then, print the remaining shards, fragments, motes, ordered by quantity in descending order, then by name 
    in ascending order, each on a new line. Finally, print the collected junk items, in alphabetical order. */
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var resources = new Dictionary<string, int>
            {
                { "shards", 0 },
                { "fragments", 0 },
                { "motes", 0 }
            } ; 
            var junk = new Dictionary<string, int>();
            bool keepFarming = true;

            var winnerResource = string.Empty;
            var winnerItem = string.Empty;

            while (keepFarming)
            {
                var tokens = inputLine.Split();
                var quantity = 0;
                var currentResource = string.Empty;

                for (int i = 0; i < tokens.Length - 1; i += 2)
                {
                    quantity = int.Parse(tokens[i]);
                    currentResource = tokens[i + 1].ToLower();

                    if (currentResource == "shards" || currentResource == "fragments" || currentResource == "motes")
                    {
                        resources[currentResource] += quantity;

                        if (resources[currentResource] >= 250)
                        {
                            keepFarming = false;
                            winnerResource = currentResource;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(currentResource))
                        {
                            junk[currentResource] = 0;
                        }

                        junk[currentResource] += quantity;
                    }
                }

                inputLine = Console.ReadLine();
            }

            winnerItem = FindingOutTheWinnerItem(winnerResource, winnerItem);

            Console.WriteLine($"{winnerItem} obtained!");
            resources[winnerResource] -= 250;

            foreach (var resource in resources.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{resource.Key}: {resource.Value}");
            }

            foreach (var junkResource in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junkResource.Key}: {junkResource.Value}");
            }
        }

        private static string FindingOutTheWinnerItem(string winnerResource, string winnerItem)
        {
            switch (winnerResource)
            {
                case "shards":
                    winnerItem = "Shadowmourne";
                    break;

                case "fragments":
                    winnerItem = "Valanyr";
                    break;

                case "motes":
                    winnerItem = "Dragonwrath";
                    break;
            }

            return winnerItem;
        }
    }
}
