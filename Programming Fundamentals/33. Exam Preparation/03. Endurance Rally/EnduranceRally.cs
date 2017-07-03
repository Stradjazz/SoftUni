using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    /*The goal of the Endurance Rally is, simply, to finish the race.
    You are given the names of the participants, the track layout and the checkpoint indexes. The starting fuel of each participant is equal to the ASCII code of the first character of his name.
    Track layout consists of zones represented by numbers, given on a single line separated by a single space. Every number represents the fuel given or the fuel taken by the current zone of the track: 
    •	If the current zone is a checkpoint, the value of the zone is added to the driver's fuel. 
    •	If the current zone is not a checkpoint, the value of the zone is subtracted from the driver's fuel.
    Zones are indexed. Indexes are sequential and always start from zero (like an array). The checkpoints are numbers, representing indexes that show if a zone of the track is a checkpoint. For example, 
    you are given checkpoints 0, 3 and 5, that means that zones at index 0, 3 and 5 of the track are checkpoints and therefore provide fuel for the driver.
    Given this information, you need to check if a driver can finish and print the fuel that he is left with. If a driver can't finish you need to print the zone he managed to reach. */
    class EnduranceRally
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var fuelZones = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var checkIndexes = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var driver in drivers)
            {
                double fuel = driver[0];

                for (int zoneIndex = 0; zoneIndex <= fuelZones.Length; zoneIndex++)
                {
                    bool noFuel = fuel <= 0;
                    bool endOfTrack = zoneIndex == fuelZones.Length;
                    bool raceEnd = noFuel || endOfTrack;

                    if (raceEnd)
                    {
                        if (noFuel)
                        {
                            Console.WriteLine($"{driver} - reached {zoneIndex - 1}");
                        }
                        else
                        {
                            Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                        }
                        break;
                    }

                    var fuelAtCheckpoint = fuelZones[zoneIndex];
                    bool isCheckpoint = checkIndexes.Contains(zoneIndex);

                    if (isCheckpoint)
                    {
                        fuel += fuelAtCheckpoint;
                    }
                    else
                    {
                        fuel -= fuelAtCheckpoint;
                    }
                }
            }
        }
    }
}
