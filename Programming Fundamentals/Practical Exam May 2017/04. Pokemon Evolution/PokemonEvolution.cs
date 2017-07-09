using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Evolution
    {
        public string Name { get; set; }
        public int Index { get; set; }
    }
    class PokemonEvolution
    {
        static void Main(string[] args)
        {
            var namesTypesIndexes = new Dictionary<string, List<Evolution>>();

            var inputLine = Console.ReadLine();

            while (inputLine != "wubbalubbadubdub")
            {
                var tokens = inputLine.Split("-> ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();

                var currentName = tokens[0];
                if (tokens.Length > 1)
                {
                    
                    var currentType = tokens[1];
                    var currentIndex = int.Parse(tokens[2]);

                    if (!namesTypesIndexes.ContainsKey(currentName))
                    {
                        namesTypesIndexes[currentName] = new List<Evolution>();
                    }
                    namesTypesIndexes[currentName].Add(new Evolution { Name = currentType, Index = currentIndex });


                }
                else if (tokens.Length == 1)
                {
                    if (namesTypesIndexes.ContainsKey(currentName))
                    {
                        var pokemonStats = namesTypesIndexes[currentName];
                        Console.WriteLine($"# {currentName}");
                        foreach (Evolution evolution in pokemonStats)
                        {
                            var currentEvolution = evolution.Name;
                            var evoIndex = evolution.Index;
                            Console.WriteLine($"{currentEvolution} <-> {evoIndex}");
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }
            foreach (var pokeName in namesTypesIndexes)
            {
                var currentPokemon = pokeName.Key;
                var evolutions = pokeName.Value;

                Console.WriteLine($"# {currentPokemon}");
                foreach (Evolution entry in evolutions.OrderByDescending(x => x.Index))
                {
                    var evoType = entry.Name;
                    var evoIndex = entry.Index;
                    Console.WriteLine($"{evoType} <-> {evoIndex}");
                }
            }
        }
    }
}
