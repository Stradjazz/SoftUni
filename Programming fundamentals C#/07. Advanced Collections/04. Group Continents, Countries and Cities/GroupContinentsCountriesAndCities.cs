using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_Continents_Countries_and_Cities
{
    //Write a program, which receives continents, countries and city names and prints them, grouped by continent,
    //country and city, all in alphabetical order. No duplicates are allowed.
    class GroupContinentsCountriesAndCities
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var continents = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            //reading
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var continent = input[0];
                var country = input[1];
                var city = input[2];
                if (!continents.ContainsKey(continent))
                {
                    continents[continent] = new SortedDictionary<string, SortedSet<string>>();
                }
                if (!continents[continent].ContainsKey(country))
                {
                    continents[continent][country] = new SortedSet<string>();
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
