using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
    //Write a program to read continents, countries and their cities, put them in a nested dictionary and print them.

    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new Dictionary<string, Dictionary<string, List <string>>>();
            //reading
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var city = input[2];
                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new Dictionary<string, List<string>>();
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new List<string>();
                }
                continents[continent][country].Add(city);
            }
            //printing
            foreach (var kvp in continents)
            {
                var continent = kvp.Key;
                var country = kvp.Value;
                Console.WriteLine($"{continent}:");
                foreach (var countryCity in country)
                {
                    var countryName = countryCity.Key;
                    var city = countryCity.Value;
                    Console.WriteLine($"    {countryName} -> {string.Join(", ", city)}");
                }
            }
        }
    }
}
