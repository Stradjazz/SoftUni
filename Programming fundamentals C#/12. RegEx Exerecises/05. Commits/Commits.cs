using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Commits
{
    class Commits
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var users = new SortedDictionary<string, SortedDictionary<string,List<Commit>>>();

            var pattern = @"https:\/\/github.com\/([A-z\d\-]+)\/([A-z\-_]+)\/commit\/((?:\d|[a-f]){40}),(.+?),(\d+),(\d+)";
            var regex = new Regex(pattern);

            while (input != "git push")
            {
                var matches = regex.Matches(input);
                var username = string.Empty;
                var repository = string.Empty;
                var hashNum = string.Empty;
                var message = string.Empty;
                var additions = 0;
                var deletions = 0;

                bool isMatch = regex.IsMatch(input);

                if (isMatch)
                {
                    foreach (Match match in matches)
                    {
                        username = match.Groups[1].Value;
                        repository = match.Groups[2].Value;
                        hashNum = match.Groups[3].Value;
                        message = match.Groups[4].Value;
                        additions = int.Parse(match.Groups[5].Value);
                        deletions = int.Parse(match.Groups[6].Value);
                    }

                    if (!users.ContainsKey(username))
                    {
                        users[username] = new SortedDictionary<string, List<Commit>>();
                    }
                    if (!users[username].ContainsKey(repository))
                    {
                        users[username][repository] = new List<Commit>();

                        var currentCommit = new Commit
                        {
                            HashNum = hashNum,
                            Message = message,
                            Additions = additions,
                            Deletions = deletions
                        };
                        users[username][repository].Add(currentCommit);
                    }
                    else
                    {
                        var currentCommit = new Commit
                        {
                            HashNum = hashNum,
                            Message = message,
                            Additions = additions,
                            Deletions = deletions
                        };
                        users[username][repository].Add(currentCommit);
                    }
                    
                }

                input = Console.ReadLine();
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                var repos = user.Value;

                foreach (var repo in repos)
                {
                    Console.WriteLine($"  {repo.Key}:");
                    var commits = repos.Values;
                    var addsTotal = 0;
                    var delsTotal = 0;

                    foreach (var commit in commits)
                    {
                        foreach (var item in commit)
                        {
                            addsTotal += item.Additions;
                            delsTotal += item.Deletions;

                            Console.WriteLine($"   commit {item.HashNum}: {item.Message} ({item.Additions} additions, {item.Deletions} deletions)");
                        }
                    }
                    Console.WriteLine($"   Total: {addsTotal} additions, {delsTotal} deletions");
                }
                
            }
        }
    }
}
