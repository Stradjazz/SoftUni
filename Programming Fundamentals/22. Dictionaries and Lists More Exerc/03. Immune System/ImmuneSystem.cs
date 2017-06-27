using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    /*An organism can encounter different types of viruses. It stores them in its immune system. If it has already encountered the virus, it fights it faster than if it hasn’t encountered it yet. The immune 
    system can calculate the virus’ strength before it fights it. It is the sum of all the virus name’s letters’ ASCII codes, divided by 3. The immune system can also calculate the time it takes to defeat a 
    virus in seconds. It is equal to the virus strength, multiplied by the length of the virus’ name. When you calculate the time to defeat the virus, convert it to minutes and seconds (500 -> 8m 20s). Do not 
    use any leading zeroes for the minutes and seconds.
    The virus is fought according to these conditions:
    •	If the immune system defeats the virus, print: “{virusName} defeated in {virusDefeatMinutes}m {virusDefeatSeconds}s.”
    •	If the virus’ strength is more than the immune system’s strength, print “Immune System Defeated.” and exit the program.
    After a virus is defeated, the immune system regains 20% of its strength. If the 20 percent exceeds the initial health of the immune system, set it to the initial health instead.
    Example: The virus “flu1”:
    •	Virus Strength: 102 (f) + 108 (l) + 117 (u) + 49 (1) = 376 / 3 = 125.33 = 125.
    •	Time to defeat: 125 * 4 (virus name length) = 500 seconds -> 8m 20s.
    Example 2: Encountering “flu1” a second time:
    •	Time to defeat: (125 * 4) / 3 = 166.66 -> 166 seconds
    If you encounter a virus any subsequent times, do not decrease its time to defeat further. When you receive the line “end”, print the status of the immune system in the format “Final Health: {finalHealth}”.*/
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            var immuneSystemRegister = new List<string>();
            var knownViruses = new List<string>();

            var maxHealth = int.Parse(Console.ReadLine());
            var currentHealth = maxHealth;

            var inputLine = Console.ReadLine();

            while (inputLine != "end" && currentHealth > 0)
            {
                var virusName = inputLine;
                var virusStrenght = inputLine.Sum(x => x);
                virusStrenght /= 3;

                var defeatTimeInSeconds = virusStrenght * virusName.Length;
                defeatTimeInSeconds = knownViruses.Contains(virusName) ? defeatTimeInSeconds / 3 : defeatTimeInSeconds;
                currentHealth -= defeatTimeInSeconds;

                if (currentHealth <= 0)
                {
                    immuneSystemRegister.Add($"Virus {virusName}: {virusStrenght} => {defeatTimeInSeconds} seconds");
                    continue;
                }

                var defeatTimeInMinAndSec = CalculateDefeatTimeMinSec(defeatTimeInSeconds);

                knownViruses.Add(virusName);

                var virusStats = $"Virus {virusName}: {virusStrenght} => {defeatTimeInSeconds} seconds\n";
                virusStats += $"{virusName} defeated in {defeatTimeInMinAndSec}.\n";
                virusStats += $"Remaining health: {currentHealth}";

                immuneSystemRegister.Add(virusStats);
                currentHealth = (int)(currentHealth * 1.2) > maxHealth ? maxHealth : (int)(currentHealth * 1.2);

                inputLine = Console.ReadLine();
            }

            foreach (var entry in immuneSystemRegister)
            {
                Console.WriteLine(entry);
            }

            Console.WriteLine(currentHealth < 0 ? "Immune System Defeated." : $"Final Health: {currentHealth}");
        }

        private static string CalculateDefeatTimeMinSec(int defeatTimeInSeconds)
        {
            var result = (defeatTimeInSeconds / 60) + "m ";
            result += (defeatTimeInSeconds % 60) + "s";
            return result;
        }
    }
}
