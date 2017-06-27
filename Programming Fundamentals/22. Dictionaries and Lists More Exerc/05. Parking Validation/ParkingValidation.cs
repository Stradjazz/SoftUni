using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    /*    Write a program, which validates parking for an online service. Users can register to park and unregister to leave. The system supports license plate validation. 
     A valid license plate has the following 3 distinct characteristics: 
    •	It is always exactly 8 characters long.
    •	Its first 2 and last 2 characters are always uppercase Latin letters
    •	The 4 characters in the middle are always digits
    If any of the aforementioned conditions fails, the license plate is invalid.
    The program receives 2 commands:
    •	“register {username} {licensePlateNumber}”:
    o	The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
    “ERROR: already registered with plate number {licensePlateNumber}”
    o	If the license plate is invalid, the system should print: “ERROR: invalid license plate {licensePlateNumber}“
    o	If the user tries to register someone else’s license plate, the system should print: “ERROR: license plate {licensePlateNumber} is busy”
    o	If the aforementioned checks pass successfully, the plate can be registered, so the system should print: “{username} registered {licensePlateNumber} successfully”
    •	“unregister {username}”:
    o	If the user is not present in the database, the system should print: “ERROR: user {username} not found”
    o	If the aforementioned check passes successfully, the system should print: “user {username} unregistered successfully”
    After you execute all of the commands, print all the currently registered users and their license plates in the format: “{username} => {licensePlateNumber}” */
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            var usersAndPlates = new Dictionary<string, string>();

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                var commandLine = Console.ReadLine().Split();
                var command = commandLine[0];
                var username = commandLine[1];
                string licensePlate;

                if (command == "register")
                {
                    licensePlate = commandLine[2];

                    if (usersAndPlates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {usersAndPlates[username]}");
                        continue;
                    }
                    else if (PlateIsInvalid(licensePlate))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {licensePlate}");
                        continue;
                    }
                    else if (usersAndPlates.ContainsValue(licensePlate))
                    {
                        Console.WriteLine($"ERROR: license plate {licensePlate} is busy");
                        continue;
                    }
                    else
                    {
                        usersAndPlates[username] = licensePlate;
                        Console.WriteLine($"{username} registered {licensePlate} successfully");
                    }
                }
                else if (command == "unregister")
                {
                    if (!usersAndPlates.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                        continue;
                    }
                    else
                    {
                        usersAndPlates.Remove(username);
                        Console.WriteLine($"user {username} unregistered successfully");
                    }
                }
            }

            foreach (var entry in usersAndPlates)
            {
                var username = entry.Key;
                var plate = entry.Value;
                Console.WriteLine($"{username} => {plate}");
            }
        }

        private static bool PlateIsInvalid(string licensePlate)
        {
            if (licensePlate.Length != 8)
            {
                return true;
            }
            var letters = licensePlate.Substring(0, 2) + licensePlate.Substring(6);
            var numbers = licensePlate.Substring(2, 4);
            
            foreach (var symbol in letters)
            {
                if (symbol < 'A' || symbol > 'Z')
                {
                    return true;
                }
            }
            foreach (var num in numbers)
            {
                if (num < '0' || num > '9')
                {
                    return true;
                }
            }

            return false;
        }
    }
}
