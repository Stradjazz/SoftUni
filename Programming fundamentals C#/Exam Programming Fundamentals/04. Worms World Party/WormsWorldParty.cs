using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    class WormsWorldParty
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var worms = new Dictionary<string, int>();
            var teams = new Dictionary<string, List<Team>>();
            

            while (input != "quit")
            {
                var tokens = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var wormName = tokens[0];
                var wormTeam = tokens[1];
                var wormScore = int.Parse(tokens[2]);
                
                if (!worms.ContainsKey(wormName))
                {
                    worms.Add(wormName, wormScore);
                }
                var currentTeam = new Team
                {
                    Name = wormTeam,
                    Worms = worms,
                    TotalScore = 0,
                    AverageScore = 0
                };

                if (!teams.ContainsKey(wormTeam))
                {
                    teams[wormTeam] = new List<Team>();
                }
                teams[wormTeam].Add(currentTeam);

                input = Console.ReadLine();
            }

            foreach (var team in teams)
            {
                var currentTeams = team.Value;
                foreach (var currentteam in currentTeams)
                {
                    foreach (var item in currentteam.Worms)
                    {
                        currentteam.TotalScore += item.Value;
                    }
                    currentteam.AverageScore = currentteam.TotalScore / currentteam.Worms.Count;
                }
                currentTeams = currentTeams.OrderByDescending(x => x.TotalScore).ThenByDescending(x => x.AverageScore).ToList();
                var count = 1;
                Console.WriteLine($"{count}. Team : {team.Key}");
            }
            
            
            
        }
    }
}
