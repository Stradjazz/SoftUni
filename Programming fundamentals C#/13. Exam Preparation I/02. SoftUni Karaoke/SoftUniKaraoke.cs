using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*SoftUni cultivates talent whether it's coding talent or something else and in this case, something else is singing. 
Since you love music you want to take part in the event but as a programmer you simply lack the "something else" so your job is 
to make the software to track participants' awards.
On the first line, you will receive a list with all participants that applied for performance. 
On the second line, you will receive the list with all available songs. 
On the next lines, until the "dawn" command, you will get the names of people, the song that they are performing on stage and 
the award they get from the audience. However, not every time the plan goes according to schedule. In other words, everyone (listed or not) 
can go on stage and perform a song that is not even available and he still gets awards from the audience. However, you should 
record only the awards for listed participants that perform songs available in the list. In case someone is not listed or sings a song 
that is not available you should not record neither the participant, nor his award. When the "dawn" comes, you need to print all 
participants, the count of the unique awards they received and all unique awards. 
Participants should be sorted by number of awards in descending order and then by participant name alphabetically. 
Awards should be sorted in alphabetical order. */

namespace _02.SoftUni_Karaoke
{
    class SoftUniKaraoke
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            var songs = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            var participantAwards = new Dictionary<string, SortedSet<string>>();

            var input = Console.ReadLine();
            
            while (input != "dawn")
            {
                var tokens = input.Split(',').Select(x => x.Trim()).ToArray();
                var participant = tokens[0];
                var song = tokens[1];
                var award = tokens[2];
                
                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!participantAwards.ContainsKey(participant))
                    {
                        participantAwards[participant] = new SortedSet<string>();
                    }
                    participantAwards[participant].Add(award);
                }

                input = Console.ReadLine();
            }

            if (!participantAwards.Any())
            {
                Console.WriteLine("No awards");
            }
            var sortedAwards = participantAwards
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var participant in sortedAwards)
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                var currentAwards = participant.Value;
                foreach (var award in currentAwards)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
