using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli___The_Coder
{
    class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; } 
    }
    class RoliTheCoder
    {
        static void Main(string[] args)
        {
            List<Event> result = new List<Event>();
            Dictionary<int, Event> eventsById = new Dictionary<int, Event>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Time for Code")
                {
                    break;
                }

                var tokens = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                int eventId = 0;
                if (!int.TryParse(tokens[0], out eventId))
                {
                    continue;
                }

                string eventName = string.Empty;
                if (tokens.Length > 1 && tokens[1].StartsWith("#"))
                {
                    eventName = tokens[1].Trim('#');
                }
                else
                {
                    continue;
                }

                var participants = new List<string>();
                if (tokens.Length > 2)
                {
                    participants = tokens.Skip(2).ToList();
                    if (!participants.All(x => x.StartsWith("@")))
                    {
                        continue;
                    }
                }

                if (eventsById.ContainsKey(eventId))
                {
                    if (eventsById[eventId].Name == eventName)
                    {
                        var existingEvent = eventsById[eventId];

                        foreach (var participant in participants)
                        {
                            if (!existingEvent.Participants.Contains(participant))
                            {
                                existingEvent.Participants.Add(participant);
                            }
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    var newEvent = new Event
                    {
                        Id = eventId,
                        Name = eventName,
                        Participants = participants
                    };

                    result.Add(newEvent);
                    eventsById.Add(eventId, newEvent);
                }
            }

            var sortedEvents = result
                    .OrderByDescending(x => x.Participants.Count)
                    .ThenBy(x => x.Name);

            foreach (var entry in sortedEvents)
            {
                var distinctParticipants = entry.Participants.Distinct().ToList();
                Console.WriteLine($"{entry.Name} - {entry.Participants.Count}");
                foreach (var participant in distinctParticipants.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
