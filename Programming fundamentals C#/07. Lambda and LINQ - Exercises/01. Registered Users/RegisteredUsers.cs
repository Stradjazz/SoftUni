﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Registered_Users
{
    /*  You will be given several usernames and dates of registry, in the following format: {username} -> {date}
        The username will be a string and the date will be a valid date in format “dd/MM/yyyy”.
        You must read input lines until you receive the command “end”. 
        You need to store every user, with his date of registry. Then you must print the LAST 5 registered names, or in other words the OLDEST registered users, in order of registry – from the latest registered, to the oldest registered.
        If there are LESS than 5 people, print them in the order, specified above.
        if any entries have the SAME date, print the LAST entered one, FIRST, and then the other (in input). */
    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            Dictionary<string, DateTime> registeredUsernames = new Dictionary<string, DateTime>();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                string userName = inputParams[0];
                DateTime registryDate = DateTime.ParseExact(inputParams[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                registeredUsernames[userName] = registryDate;

                inputLine = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUsernames = registeredUsernames
                .Reverse()
                .OrderBy(x => x.Value)
                .Take(5)
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var entry in orderedUsernames)
            {
                Console.WriteLine($"{entry.Key}");
            }
        }
    }
}
