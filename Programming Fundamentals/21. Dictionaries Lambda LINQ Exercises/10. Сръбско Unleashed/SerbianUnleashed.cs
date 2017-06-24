using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    /* Admit it – the СРЪБСКО is your favorite sort of music. You never miss a concert and you have become quite the geek concerning everything involved with СРЪБСКО. You can’t decide between all the 
    singers you know who your favorite one is. One way to find out is to keep statistics of how much money their concerts make. Write a program that does all the boring calculations for you.
    On each input line you’ll be given data in format: "singer @venue ticketsPrice ticketsCount". There will be no redundant whitespaces anywhere in the input. Aggregate the data by venue and by singer. 
    For each venue, print the singer and the total amount of money his/her concerts have made on a separate line. Venues should be kept in the same order they were entered; the singers should be sorted 
    by how much money they have made in descending order. If two singers have made the same amount of money, keep them in the order in which they were entered. 
    Keep in mind that if a line is in incorrect format, it should be skipped and its data should not be added to the output. Each of the four tokens must be separated by a space, everything else is invalid. 
    The venue should be denoted with @ in front of it, such as @Sunny Beach. SKIP THOSE: Ceca@Belgrade125 12378, Ceca @Belgrade12312 123
    The singer and town name may consist of one to three words. */
    class SerbianUnleashed
    {
        static void Main(string[] args)
        {
            var venueSingerIncome = new Dictionary<string, Dictionary<string, long>>();

            GettingVenueSingerAndIncome(venueSingerIncome);

            foreach (var entry in venueSingerIncome)
            {
                var venue = entry.Key;
                var singerIncome = entry.Value;
                Console.WriteLine($"{venue}");

                foreach (var singer in singerIncome)
                {
                    var currentSinger = singer.Key;
                    var income = singer.Value;

                    Console.WriteLine($"#  {currentSinger} -> {income}");
                }
            }
        }

        private static void GettingVenueSingerAndIncome(Dictionary<string, Dictionary<string, long>> venueSingerIncome)
        {
            var inputLine = Console.ReadLine();
            while (inputLine != "End")
            {
                var singer = inputLine.Split('@').First();

                if (!singer.EndsWith(" ") || singer.Length < 2)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }
                singer = singer.Trim();

                var concertInfo = inputLine.Substring(inputLine.IndexOf('@') + 1);
                var concertDetailsList = concertInfo.Split(' ').ToList();

                if (!int.TryParse(concertDetailsList[concertDetailsList.Count - 1], out int ticketCount)
                    || !int.TryParse(concertDetailsList[concertDetailsList.Count - 2], out int ticketPrice)
                    || concertDetailsList.Count < 3)
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                var venue = string.Join(" ", concertDetailsList.Take(concertDetailsList.Count - 2));

                if (!venueSingerIncome.ContainsKey(venue))
                {
                    venueSingerIncome[venue] = new Dictionary<string, long>();
                }
                if (!venueSingerIncome[venue].ContainsKey(singer))
                {
                    venueSingerIncome[venue][singer] = 0;
                }

                venueSingerIncome[venue][singer] += ticketCount * ticketPrice;
                venueSingerIncome[venue] = venueSingerIncome[venue].OrderByDescending(income => income.Value).ToDictionary(a => a.Key, a => a.Value);

                inputLine = Console.ReadLine();
            }
        }
    }
}
