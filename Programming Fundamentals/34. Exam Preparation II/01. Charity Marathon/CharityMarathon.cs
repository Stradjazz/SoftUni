using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            var marathonDays = int.Parse(Console.ReadLine());
            var listedRunners = long.Parse(Console.ReadLine());
            var lapsPerRunner = int.Parse(Console.ReadLine());
            var trackLengthMeters = long.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            capacity = capacity * marathonDays;
            if (capacity < listedRunners)
            {
                listedRunners = capacity;
            }

            var kilometers = listedRunners * lapsPerRunner * trackLengthMeters / 1000;
            var totalMoney = kilometers * moneyPerKm;

            Console.WriteLine($"Money raised: {totalMoney:F2}");
        }
    }
}
