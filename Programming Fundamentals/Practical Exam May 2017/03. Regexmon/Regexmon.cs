using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {
            var bojomonPattern = @"[A-Za-z]+-[A-Za-z]+";
            var didimonPattern = @"([^A-Za-z-]+)";

            var regexBojo = new Regex(bojomonPattern);
            var regexDidi = new Regex(didimonPattern);

            var inputLine = Console.ReadLine();
            
            while (inputLine.Length > 0)
            {
                var didiMatch = Regex.Match(inputLine, didimonPattern);
                
                if (didiMatch.Success)
                {
                    var index = inputLine.IndexOf(didiMatch.Value);
                    var length = didiMatch.Value.Length;
                    Console.WriteLine(didiMatch.Value);
                    
                    inputLine = inputLine.Remove(0, index + length);
                }

                var bojoMatch = Regex.Match(inputLine, bojomonPattern);

                if (bojoMatch.Success)
                {
                    var index = inputLine.IndexOf(bojoMatch.Value);
                    var length = bojoMatch.Value.Length;
                    Console.WriteLine(bojoMatch.Value);

                    inputLine = inputLine.Remove(0, index + length);
                }
                if (!didiMatch.Success && !bojoMatch.Success)
                {
                    break;
                }
                
            }
            
        }
    }
}
