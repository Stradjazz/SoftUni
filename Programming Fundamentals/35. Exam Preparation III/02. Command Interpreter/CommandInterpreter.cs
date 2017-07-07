using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> stringsArray = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            var commandLine = Console.ReadLine();

            while (commandLine != "end")
            {
                var tokens = commandLine.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                var command = tokens[0];

                switch (command)
                {
                    case "reverse":
                        var index = int.Parse(tokens[2]);
                        var count = int.Parse(tokens[4]);
                        if (InvalidParameters(stringsArray, index, count))
                        {
                            Console.WriteLine($"Invalid input parameters.");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            Reverse(stringsArray, index, count);
                        }
                        break;

                    case "sort":
                        index = int.Parse(tokens[2]);
                        count = int.Parse(tokens[4]);
                        if (InvalidParameters(stringsArray, index, count))
                        {
                            Console.WriteLine($"Invalid input parameters.");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            SortingArray(stringsArray, index, count);
                        }
                        break;

                    case "rollLeft":
                        count = int.Parse(tokens[1]);
                        
                        if (InvalidCount(stringsArray, count))
                        {
                            Console.WriteLine($"Invalid input parameters.");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            RollingLeft(stringsArray, count);

                        }
                        break;

                    case "rollRight":
                        count = int.Parse(tokens[1]);
                        if (InvalidCount(stringsArray, count))
                        {
                            Console.WriteLine($"Invalid input parameters.");
                            commandLine = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            RollingRight(stringsArray, count);
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", stringsArray)}]");
        }
        private static bool InvalidParameters(List<string> stringsArray, int index, int count)
        {
            return ((index < 0 || index >= stringsArray.Count) || (count < 0 || count + index > stringsArray.Count));    
        }
        private static bool InvalidCount(List<string> stringsArray, int count)
        {
            return (count < 0);
        }

        private static void RollingRight(List<string> stringsArray, int count)
        {
            
            for (int i = 0; i < count % stringsArray.Count; i++)
            {
                var lastElement = stringsArray[stringsArray.Count - 1];
                stringsArray.Insert(0, lastElement);
                stringsArray.RemoveAt(stringsArray.Count - 1);
            }
            
        }

        private static void RollingLeft(List<string> stringsArray, int count)
        {
            
            for (int i = 0; i < count % stringsArray.Count; i++)
            {
                var firstElement = stringsArray[0];
                stringsArray.Add(firstElement);
                stringsArray.RemoveAt(0);
            }
        }

        private static void SortingArray(List<string> stringsArray, int index, int count)
        {
            stringsArray.Sort(index, count, null);
        }

        private static void Reverse(List<string> stringsArray, int index, int count)
        {
           stringsArray.Reverse(index, count);
        }  
    }
}
