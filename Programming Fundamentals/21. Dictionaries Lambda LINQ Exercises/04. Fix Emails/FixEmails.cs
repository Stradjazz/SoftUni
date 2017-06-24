using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    /*You are given a sequence of strings, each on a new line, until you receive the “stop” command. The first string is the name of a person. On the second line, you will receive their email. 
    Your task is to collect their names and emails, and remove emails whose domain ends with "us" or "uk" (case insensitive). Print: {name} – > {email} */
    class FixEmails
    {
        static void Main(string[] args)
        {
            var register = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                var email = Console.ReadLine();
                register[name] = email;
            }
            var fixedEmails = register
                .Where(kvp => !(kvp.Value.EndsWith("us") || kvp.Value.EndsWith("uk")))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var entry in fixedEmails)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
