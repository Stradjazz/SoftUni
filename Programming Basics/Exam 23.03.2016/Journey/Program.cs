using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string accomodation = "Camp";
            string area = "Bulgaria";
            decimal camp = -1.0m;
            decimal hotel = -1.0m;

            if (budget <= 100)
            {
                camp = budget * 0.30m;
                hotel = budget * 0.70m;

                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in {area}");
                    Console.WriteLine("{0} - {1:F2}", accomodation, camp);
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    Console.WriteLine($"Somewhere in {area}");
                    Console.WriteLine("{0} - {1:F2}", accomodation, hotel);
                }
            }

            else if (budget <= 1000)
            {
                area = "Balkans";
                camp = budget * 0.40m;
                hotel = budget * 0.80m;

                if (season == "summer")
                {
                    Console.WriteLine($"Somewhere in {area}");
                    Console.WriteLine("{0} - {1:F2}", accomodation, camp);
                }
                else if (season == "winter")
                {
                    accomodation = "Hotel";
                    Console.WriteLine($"Somewhere in {area}");
                    Console.WriteLine("{0} - {1:F2}", accomodation, hotel);
                }
            }
            else if (budget > 1000)
            {
                area = "Europe";
                accomodation = "Hotel";
                hotel = budget * 0.90m;
                Console.WriteLine($"Somewhere in {area}");
                Console.WriteLine("{0} - {1:F2}", accomodation, hotel);
            }
        }
    }
}
