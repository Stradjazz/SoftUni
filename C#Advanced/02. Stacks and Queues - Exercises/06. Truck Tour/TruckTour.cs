using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Truck_Tour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var gasPumps = new Queue<int[]>();

            for (int counter = 0; counter < n; counter++)
            {
                var pump = Console.ReadLine().Split().Select(int.Parse).ToArray();
                gasPumps.Enqueue(pump);
            }

            for (int currentStart = 0; currentStart < gasPumps.Count - 1; currentStart++)
            {
                bool successfulTour = true;
                var fuel = 0;
                for (int pumpsPassed = 0; pumpsPassed < gasPumps.Count; pumpsPassed++)
                {
                    var currentPump = gasPumps.Dequeue();
                    var pumpFuel = currentPump[0];
                    var distanceToNextPump = currentPump[1];

                    gasPumps.Enqueue(currentPump);

                    fuel += pumpFuel - distanceToNextPump;

                    if (fuel < 0)
                    {
                        currentStart += pumpsPassed;
                        successfulTour = false;
                        break;
                    }
                }

                if (successfulTour)
                {
                    Console.WriteLine(currentStart);
                    Environment.Exit(0);
                }
            }
        }
    }
}
