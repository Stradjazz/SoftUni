using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Cottage_Scraper
{
    /*  You’re a carpenter at the local woodworking shop. Your client wants you to build a wooden skyscraper/cottage. A CottageScraper, he calls it. But in order to accomplish this task, he needs the trees to be taller than a certain height. The problem is that he doesn’t know what type of tree he’ll use yet, and doesn’t know how tall he wants to make the CottageScraper yet. You’ve obviously got nothing better to do, so you go to work chopping down logs until he calls you with the details.
    Write a program which receives tree types and their lengths in the format “{type} -> {height}”. When you receive the command “chop chop”, 
    it’s time to get paid.
    On the next line, you will receive the type of tree that needs to be used to build the CottageScraper. On the final input line, 
    you will receive the minimum length per tree, needed to accomplish the task. Filter the trees based on type and minimum length, making sure, 
    that you’ll only use the trees of the specified type and minimum length.
    After which, calculate the total price of the CottageScraper, which includes the price of all the trees you collected up to that point. 
    The price is calculated as being the average meters of all logs you collected, per meter of log, rounded to the second decimal place.
    You’re going to charge the client 100% of the price per log for logs you’ll use in the skyscraper, and 25% of the price per log for logs,
    you won’t use for the CottageScraper. Both of the fees are rounded to the second decimal place.
    After you make the calculations, print them on the console. On the first line of the console, print “Price per meter: ${pricePerMeter:F2}”. 
    On the second, print “Used logs price: ${usedLogsPrice:F2}”. On the third line, print “Unused logs price: ${unusedLogsPrice:F2}”. 
    On the final line of the output, print “CottageScraper subtotal: ${subTotal:F2}”.  */
    class CottageScraper
    {
        static void Main(string[] args)
        {
            var treeTypes = new Dictionary<string, List<int>>();
            var input = Console.ReadLine();

            while (input != "chop chop")
            {
                var inputData = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var tree = inputData[0];
                var length = int.Parse(inputData[1]);

                if (!treeTypes.ContainsKey(tree))
                {
                    treeTypes[tree] = new List<int>();
                }

                treeTypes[tree].Add(length);

                input = Console.ReadLine();
            }

            var typesTreeToUse = Console.ReadLine();
            var minLength = int.Parse(Console.ReadLine());

            var totalMeter = 0;
            var count = 0;
            foreach (var type in treeTypes.Values)
            {
                totalMeter += type.Sum();
                count += type.Count();
            }
            var pricePerMeter = Math.Round((totalMeter / (double)count), 2);

            var goodLength = new List<int>();
            foreach (var type in treeTypes)
            {
                if (type.Key == typesTreeToUse)
                {
                    goodLength = type.Value
                        .Where(x => x >= minLength)
                        .ToList();
                }
            }
            var usedLogsPrice = Math.Round(goodLength.Sum() * pricePerMeter, 2);

            var unUsedLogs = new List<int>();
            foreach (var type in treeTypes)
            {
                if (type.Key != typesTreeToUse)
                {
                    foreach (var item in type.Value)
                    {
                        unUsedLogs.Add(item);
                    }
                }
                else
                {
                    foreach (var item in type.Value)
                    {
                        if (item < minLength)
                        {
                            unUsedLogs.Add(item);
                        }
                    }
                }
            }
            var unUsedLogsPrice = Math.Round(unUsedLogs.Sum() * pricePerMeter * 0.25, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:F2}");
            Console.WriteLine($"Used logs price: ${usedLogsPrice:F2}");
            Console.WriteLine($"Unused logs price: ${unUsedLogsPrice:F2}");
            Console.WriteLine($"CottageScraper subtotal: ${(usedLogsPrice + unUsedLogsPrice):F2}");
        }
    }
}
