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
            int days = int.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine()); 
            int lapsPerRunner = int.Parse(Console.ReadLine()); 

            long trackLength = long.Parse(Console.ReadLine()); 
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            trackCapacity = days * trackCapacity;
            runners = Math.Min(trackCapacity, runners);
            long totalMeters = runners * trackLength * lapsPerRunner;
            long totalKm = totalMeters / 1000;
            var raisedMoney = totalKm * moneyPerKm;

            Console.WriteLine($"Money raised: {raisedMoney:F2}");

        }
    }
}
