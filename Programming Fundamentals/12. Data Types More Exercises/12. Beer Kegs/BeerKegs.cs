using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    /*Write a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines. Each three lines will hold 
    information for a single keg. First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the 
    keg. Calculate the volume using the following formula: π * r^2 * h.
    At the end, print the model of the biggest keg.*/
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestVolume = 0.0;
            double currentVolume = 0.0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                long height = long.Parse(Console.ReadLine());

                currentVolume = Math.PI * Math.Pow(radius, 2) * height;
                if (currentVolume > biggestVolume)
                {
                    biggestVolume = currentVolume;
                    biggestKeg = kegModel;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
