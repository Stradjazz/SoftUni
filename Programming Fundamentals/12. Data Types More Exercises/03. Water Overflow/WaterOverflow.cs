using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    /*You have a water tank with capacity of 255 liters. On the next n lines, you will receive liters of water, which you have to pour 
     in your tank. If the capacity is not enough, print “Insufficient capacity!” and continue reading the next line. On the last line, 
     print the liters in the tank.*/
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int waterInTank = 0;
            int capacity = 255;

            for (int i = 0; i < n; i++)
            {
                int newWater = int.Parse(Console.ReadLine());
                capacity = 255 - waterInTank;

                if (newWater > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterInTank += newWater;
                }
            }
            Console.WriteLine(waterInTank);
        }
    }
}
