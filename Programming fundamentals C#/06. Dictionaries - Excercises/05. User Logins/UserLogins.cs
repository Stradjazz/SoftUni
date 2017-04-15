using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that receives a list of username-password pairs in the format “{username} -> {password}”. If there’s already a user with that username, 
replace their password. After you receive the command “login”, login requests start coming in, using the same format. Your task is to print the status of user 
login, using different messages as per the conditions below:
•	If the password matches with the user’s password, print “{username}: logged in successfully”.
•	If the user doesn’t exist, or the password doesn’t match the user, print “{username}: login failed”. 
When you receive the command “end”, print the count of unsuccessful login attempts, using the format “unsuccessful login attempts: {count}”. */

namespace _05.User_Logins
{
    class UserLogins
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Dictionary<string, string> logins = new Dictionary<string, string>();

            while (input != "login")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string username = tokens[0];
                string password = tokens[1];

                if (!logins.ContainsKey(username))
                {
                    logins[username] = string.Empty;
                }

                logins[username] = password;

                input = Console.ReadLine();
            }
            //foreach (var item in logins)
            //{
            //    Console.WriteLine(item.Key + " -> " + item.Value);
            //}

            input = Console.ReadLine();
            int count = 0;

            while (input != "end")
            {
                var tokens = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string username = tokens[0];
                string password = tokens[1];

                if (!logins.ContainsKey(username))
                {
                    Console.WriteLine($"{username}: login failed");
                    count++;
                }
                else if (logins.ContainsKey(username))
                {
                    if (logins[username] != password)
                    {
                        Console.WriteLine($"{username}: login failed");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
