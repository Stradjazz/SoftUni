using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "\b([A-Z a-z]){5,}@[a-z]{3,}[.](bg|org|com)\b";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            var eMails = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                string wannaBeEmail = Console.ReadLine();

                if (regex.IsMatch(wannaBeEmail))
                {
                    Match match = regex.Match(wannaBeEmail);
                    string username = match.Groups[1].Value;
                    string domain = match.Groups[2].Value;

                    if (!eMails.ContainsKey(domain))
                    {
                        eMails[domain] = new HashSet<string>();
                    }
                    if (!eMails[domain].Contains(username))
                    {
                        eMails[domain].Add(username);
                    }
                    eMails[domain].Add(username);
                }
            }


        }
    }
}
