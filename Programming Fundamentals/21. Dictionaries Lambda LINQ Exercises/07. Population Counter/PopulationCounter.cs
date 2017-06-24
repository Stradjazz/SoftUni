using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    /*On each input line, you’ll be given data in format: "city|country|population". There will be no redundant whitespaces anywhere in the input. Aggregate the data by country and by city and 
    print it on the console. 
    For each country, print its total population and on separate lines, the data for each of its cities. Countries should be ordered by their total population in descending order and within each country, 
    the cities should be ordered by the same criterion.
    If two countries/cities have the same population, keep them in the order in which they were entered. Check out the examples; follow the output format strictly! */
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var countriesCitiesPopulation = new Dictionary<string, Dictionary<string, long>>();
            var commandLine = Console.ReadLine();
            
            var countriesPopulation = new Dictionary<string, long>();

            while (commandLine != "report")
            {
                var tokens = commandLine.Split('|');
                var city = tokens[0];
                var country = tokens[1];
                var population = long.Parse(tokens[2]);

                if (!countriesCitiesPopulation.ContainsKey(country))
                {
                    countriesCitiesPopulation[country] = new Dictionary<string, long>();
                }

                if (!countriesCitiesPopulation[country].ContainsKey(city))
                {
                    countriesCitiesPopulation[country][city] = 0;
                }
                countriesCitiesPopulation[country][city] += population;// reading population of each city

                commandLine = Console.ReadLine();
            }
            
            countriesCitiesPopulation = countriesCitiesPopulation.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);

            foreach (var countryCityPopulation in countriesCitiesPopulation)
            {
                var currentCountry = countryCityPopulation.Key;
                var citiesPopulation = countryCityPopulation.Value;
                var totalPopulation = citiesPopulation.Values.Sum();

                Console.WriteLine($"{currentCountry} (total population: {totalPopulation})");

                citiesPopulation = citiesPopulation.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (var cityPopulation in citiesPopulation)
                {
                    var city = cityPopulation.Key;
                    var population = cityPopulation.Value;

                    Console.WriteLine($"=>{city}: {population}");
                }
            }
        }
    }
}
