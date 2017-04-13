using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You are in a battery manufacturing plant. Your task is to stress test the latest batch of batteries for longevity.
You will receive an array of doubles on the console (first line, space-separated), indicating the capacities of the different batteries in the batch (in mAh). 
On the next line, you will receive the usage per hour for each battery as an array of doubles (second line, space-separated).
Next, you will receive the amount of hours you have to stress test each battery for (as an integer). Each of the batteries drains by its capacity until either 
the testing hours are over, or the battery dies (reaches 0 capacity).
Print the status of all the batteries at the end of the testing session (in percentage). If any batteries die, along with the percentage, print how many 
hours it took. The capacity and percentage are rounded to the 2nd decimal point.*/
namespace _06.Batteries
{
    class Batteries
    {
        static void Main(string[] args)
        {
            double[] batteries = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] usage = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int testHours = int.Parse(Console.ReadLine());
            int[] hoursNeeded = new int[batteries.Length];

            for (int i = 0; i < batteries.Length; i++)//rotating the bateries with their corresponding usage
            {
                var currentBattery = batteries[i];
                var currentUsage = usage[i];
                var hoursCount = 0;
                var initialValue = currentBattery;
                var usedHours = testHours;

                while (currentBattery > 0 && usedHours > 0)//draining the current battery
                {
                    usedHours--;
                    currentBattery -= currentUsage;
                    hoursCount++;
                }

                hoursNeeded[i] = hoursCount;
                
                if (currentBattery > 0)
                {
                    var percentage = (currentBattery * 100) / initialValue;
                    Console.WriteLine($"Battery {i + 1}: {currentBattery:F2} mAh ({percentage:F2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursCount} hours)");
                }
            }
        }
    }
}
