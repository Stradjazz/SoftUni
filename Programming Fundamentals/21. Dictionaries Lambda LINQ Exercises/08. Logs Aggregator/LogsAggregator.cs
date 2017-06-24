using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    /*You are given a sequence of access logs in format <IP> <user> <duration>. For example:
    •	192.168.0.11 peter 33
    •	10.10.17.33 alex 12 
    Write a program to aggregate the logs data and print for each user the total duration of his sessions and a list of unique IP addresses in format "<user>: <duration> [<IP1>, <IP2>, …]". 
    Order the users alphabetically. Order the IPs alphabetically. In our example, the output should be the following:
    •	alex: 62 [10.10.17.33, 212.50.118.81]
    •	peter: 303 [10.10.17.34, 10.10.17.35, 192.168.0.11] */
    class LogsAggregator
    {
        static void Main(string[] args)
        {
            var namesIPsDuration = new SortedDictionary<string, SortedDictionary<string, int>>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                var line = Console.ReadLine();
                var tokens = line.Split();
                var name = tokens[1];
                var ip = tokens[0];
                var duration = int.Parse(tokens[2]);

                if (!namesIPsDuration.ContainsKey(name))
                {
                    namesIPsDuration[name] = new SortedDictionary<string, int>();
                }

                if (!namesIPsDuration[name].ContainsKey(ip))
                {
                    namesIPsDuration[name][ip] = 0;
                }

                namesIPsDuration[name][ip] += duration;
            }

            foreach (var nameIPDuration in namesIPsDuration)
            {
                var name = nameIPDuration.Key;
                var ipsDurations = nameIPDuration.Value;

                var totalDuration = ipsDurations.Sum(a => a.Value);
                var ips = ipsDurations.Select(a => a.Key).ToArray();

                Console.WriteLine($"{name}: {totalDuration} [{string.Join(", ", ips)}]");
            }
            
        }
    }
}
