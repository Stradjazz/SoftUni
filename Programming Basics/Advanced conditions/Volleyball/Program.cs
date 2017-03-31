using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            var sofiaWeekends = 48 - h;
            var sofiaGames = sofiaWeekends * (3.0 / 4);
            var homeGames = h;
            var pGames = p * (2.0 / 3);
            var allGames = sofiaGames + homeGames + pGames;

            if (year == "leap")
            {
                allGames += allGames * 0.15;
            }

            Console.WriteLine(Math.Truncate(allGames));

        }
    }
}
