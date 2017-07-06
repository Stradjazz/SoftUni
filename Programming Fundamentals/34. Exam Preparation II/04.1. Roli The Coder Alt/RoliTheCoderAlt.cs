using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04._1.Roli_The_Coder_Alt
{
    class Event
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
    class RoliTheCoderAlt
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();
            var eventList = new List<Event>();
            while (inputLine != "Time for Code")
            {
                var pattern = @"(?<id>\d+)?\s+#(?<eventName>\w+)\s*(?<participants>.*)";

                var tokens = Regex.Matches(inputLine, pattern).Cast<Match>().ToArray();
                foreach (var token in tokens)
                {
                    var eventId = int.Parse(token.Groups["id"].Value);
                    var eventName = token.Groups["eventName"].Value;
                    var participants = token.Groups["participants"].Value.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                        .Select(a => a.Trim()).ToArray();

                    if (eventList.Any(a => a.ID == eventId && a.Name == eventName))
                    {
                        eventList.First(a => a.ID == eventId).Participants.AddRange(participants);
                        eventList.First(a => a.ID == eventId).Participants.Distinct();
                    }
                    else if (!eventList.Any(a => a.ID == eventId))
                    {
                        var newEvent = new Event();
                        newEvent.ID = eventId;
                        newEvent.Name = eventName;
                        newEvent.Participants = new List<string>();
                        newEvent.Participants.AddRange(participants);

                        eventList.Add(newEvent);

                    }
                }

                inputLine = Console.ReadLine();

            }
            foreach (Event currentEvent in eventList)
            {
                currentEvent.Participants = currentEvent.Participants.Distinct().ToList();
            }
            foreach (var item in eventList.OrderByDescending(a => a.Participants.Distinct().Count()).ThenBy(a => a.Name))
            {
                item.Participants.Distinct();
                Console.WriteLine($"{item.Name} - {item.Participants.Count}");
                foreach (var elem in item.Participants.OrderBy(a => a))
                {
                    Console.WriteLine(elem);
                }
            }
        }
    }
}
