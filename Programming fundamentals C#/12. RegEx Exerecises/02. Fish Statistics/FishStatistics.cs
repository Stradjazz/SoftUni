using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*You are a marine biologist tasked with researching various types of fish. You will receive a single line on the console as input. 
From this line, you must extract all the fish you find and print statistics about each one. Fish are categorized by three criteria: 
tail length, body length and status. A standard fish looks like this: ><(((('>
This fish has a tail length of 1, a body length of 4 and has the status “Awake”, since its eye is open. One ASCII character represents 
2 centimeters in real life. By those standards, this fish has a tail length of 2 cm and a body length of 8 cm. 
There are various types of tails, bodies and statuses, which are described below:
•	Tail types:
    Tail longer than 5 “<” characters -> Long
    Tail longer than 1 “<” characters -> Medium
    Tail, which is 1 “<” character long -> Short
    Nonexistent tail -> None
•	Body types:
    Body longer than 10 “(” characters -> Long
    Body longer than 5 “(” characters -> Medium
    Any other length -> Short
•	Statuses:
    ' -> Awake
    - -> Asleep
    x -> Dead
The input will contain a variable amount of fish, separated by any sequence of ASCII characters. 
There’s a possibility you might receive input, which has no fish – in this case, just print “No fish found.”, and end the program. */
namespace _02.Fish_Statistics
{
    class FishStatistics
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(>+)?<(\(+)('|-|x)>";
            var regex = new Regex(pattern);
            var fishes = regex.Matches(input);

            if (fishes.Count == 0)
            {
                Console.WriteLine("No fish found.");
            }
            else
            {
                for (int i = 0; i < fishes.Count; i++)
                {
                    Console.WriteLine($"Fish {i + 1}: {fishes[i]}");

                    var tailLength = fishes[i].Groups[1].Length;
                    var tailType = Tail(tailLength);
                    if (tailLength > 0)
                    {
                        Console.WriteLine($"Tail type: {tailType} ({tailLength * 2} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"Tail type: {tailType}");
                    }

                    var bodyLength = fishes[i].Groups[2].Length;
                    var bodyType = Body(bodyLength);
                    Console.WriteLine($"Body type: {bodyType} ({bodyLength * 2} cm)");

                    var eye = fishes[i].Groups[3].Value;
                    var status = Status(eye);
                    Console.WriteLine($"Status: {status}");
                }
            }
        }

        private static string Status(string eye)
        {
            string status = string.Empty;
            if (eye == "'")
            {
                status = "Awake";
            }
            else if (eye == "-")
            {
                status = "Asleep";
            }
            else if (eye == "x")
            {
                status = "Dead";
            }

            return status;
        }

        private static string Body(int bodyLength)
        {
            string bodyType = string.Empty;
            if (bodyLength > 10)
            {
                bodyType = "Long";
            }
            else if (bodyLength <= 10 && bodyLength > 5)
            {
                bodyType = "Medium";
            }
            else if (bodyLength <= 5)
            {
                bodyType = "Short";
            }

            return bodyType;
        }

        private static string Tail(int tailLength)
        {
            string tailType;
            if (tailLength > 5)
            {
                tailType = "Long";
            }
            else if (tailLength <= 5 && tailLength > 1)
            {
                tailType = "Medium";
            }
            else if (tailLength == 1)
            {
                tailType = "Short";
            }
            else
            {
                tailType = "None";
            }
            
            return tailType;
        }
    }
}
