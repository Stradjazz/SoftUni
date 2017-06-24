using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    /*Heroes III is the best game ever. Everyone loves it and everyone plays it all the time. Stamat is no exclusion to this rule. His favorite units in the game are all types of dragons – black, red, 
    gold, azure etc… He likes them so much that he gives them names and keeps logs of their stats: damage, health and armor. The process of aggregating all the data is quite tedious, so he would 
    like to have a program doing it. Since he is no programmer, it’s your task to help him.
    You need to categorize dragons by their type. For each dragon, identified by name, keep information about his stats. Type is preserved as in the order of input, but dragons are sorted alphabetically 
    by name. For each type, you should also print the average damage, health and armor of the dragons. For each dragon, print his own stats. 
    There may be missing stats in the input, though. If a stat is missing you should assign it default values. Default values are as follows: health 250, damage 45, and armor 10. Missing stat will be 
    marked by null. The input is in the following format {type} {name} {damage} {health} {armor}. Any of the integers may be assigned null value. See the examples below for better understanding of your 
    task. If the same dragon is added a second time, the new stats should overwrite the previous ones. Two dragons are considered equal if they match by both name and type.*/
    class DragonArmy
    {
        static void Main(string[] args)
        {
            var dragTypeNameData = new Dictionary<string, SortedDictionary<string, List<int>>>();

            int inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                var dragonData = Console.ReadLine().Split();

                var dragonType = dragonData[0];
                var dragonName = dragonData[1];

                int damage = int.TryParse(dragonData[2], out damage) ? damage : 45;
                int health = int.TryParse(dragonData[3], out health) ? health : 250;
                int armor = int.TryParse(dragonData[4], out armor) ? armor : 10;

                if (!dragTypeNameData.ContainsKey(dragonType))
                {
                    dragTypeNameData[dragonType] = new SortedDictionary<string, List<int>>();
                }
                if (!dragTypeNameData[dragonType].ContainsKey(dragonName))
                {
                    dragTypeNameData[dragonType][dragonName] = new List<int>();
                }
                else
                {
                    dragTypeNameData[dragonType][dragonName].Clear();
                }
                dragTypeNameData[dragonType][dragonName].Add(damage);
                dragTypeNameData[dragonType][dragonName].Add(health);
                dragTypeNameData[dragonType][dragonName].Add(armor);
            }

            foreach (var dragonType in dragTypeNameData)
            {
                var type = dragonType.Key;
                var namesStats = dragonType.Value;

                Console.WriteLine($"{type}::({CalculateDragonAverageStats(namesStats)})");

                Console.WriteLine(string.Join(Environment.NewLine, namesStats.Select(a => $"-{a.Key} -> damage: {a.Value[0]}, health: {a.Value[1]}, armor: {a.Value[2]}")));
            }
        }
        static string CalculateDragonAverageStats(SortedDictionary<string, List<int>> nameStats)
        {
            var damageList = new List<int>();
            var healthList = new List<int>();
            var armorList = new List<int>();
            foreach (var entry in nameStats)
            {
                damageList.Add(entry.Value[0]);
                healthList.Add(entry.Value[1]);
                armorList.Add(entry.Value[2]);
            }

            return $"{damageList.Average():f2}/{healthList.Average():f2}/{armorList.Average():f2}";
        }
    }
}
