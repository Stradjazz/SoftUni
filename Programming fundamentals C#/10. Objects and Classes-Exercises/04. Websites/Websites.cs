using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You have been tasked to create an ordered database of websites. For the task you will need to create a class Website, 
 which will have a Host, a Domain and Queries. The Host and the Domain are simple strings.  The Queries, is Collections of strings.
You will be given several input lines in the following format:
{host} | {domain} | {query1,query2. . .}
Note: There will always be a host and a domain, but there might NOT be ANY queries.
The input sequence ends, when you receive the command “end”. Then you must print all websites in the following format:
https://www.{host}.{domain}/query?=[{query1]&[{query2}]&[query3]. . .
In case there are NO queries, just print:
https://www.{host}.{domain}  */
namespace _04.Websites
{
    class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Query { get; set; }
    }
    class Websites
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<Website> websites = new List<Website>();

            while (input != "end")
            {
                var currentWebsite = ReadTheWebInfo(input);
                websites.Add(currentWebsite);

                input = Console.ReadLine();
            }
            foreach (var website in websites)
            {
                if (website.Query.Count > 0)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[", website.Query)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }

        public static Website ReadTheWebInfo (string input)
        {
            var tokens = input.Split(new[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var hostName = tokens[0];
            var domainName = tokens[1];
            List<string> queries = new List<string>();
            if (tokens.Length > 2)
            {
                queries = tokens[2].Split(',').ToList();
            }
            return new Website
            {
                Host = hostName,
                Domain = domainName,
                Query = queries
            };
        }
    }
}
