using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    /*You are given an input in the format:
    •	IP=(IP.Address) message=(A&sample&message) user=(username)
    Your task is to parse the IP and the username from the input and for every user, you have to display every IP from which the corresponding user has sent a message and the count of the messages sent 
    with the corresponding IP. In the output, the usernames must be sorted alphabetically while their IP addresses should be displayed in the order of their first appearance. The output should be in 
    the following format: 
    username: 
    IP => count, IP => count. */
    class UserLogs
    {
        static void Main(string[] args)
        {
            var usersIPsMessages = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var tokens = input.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var ip = tokens[0].Substring(3);
                var user = tokens[2].Substring(5);

                if (!usersIPsMessages.ContainsKey(user))
                {
                    usersIPsMessages[user] = new Dictionary<string, int>();
                }
                if (!usersIPsMessages[user].ContainsKey(ip))
                {
                    usersIPsMessages[user][ip] = 0;
                }
                usersIPsMessages[user][ip]++;
                input = Console.ReadLine();
            }

            foreach (var userIpsMessages in usersIPsMessages)
            {
                var user = userIpsMessages.Key;
                var ipsMessages = userIpsMessages.Value;
                Console.WriteLine($"{user}: ");

                foreach (var ipMessage in ipsMessages)
                {
                    string ipSplit = ipMessage.Equals(userIpsMessages.Value.Last()) ? "." + Environment.NewLine : ", ";
                    Console.Write($"{ipMessage.Key} => {ipMessage.Value}{ipSplit}");
                }
                
            }
            
        }
    }
}
