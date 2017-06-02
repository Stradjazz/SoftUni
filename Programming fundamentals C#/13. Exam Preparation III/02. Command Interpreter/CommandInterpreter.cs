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
            List<string> array = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputParams = inputLine.Split(' ');
                string command = inputParams[0];
                switch (command)
                {
                    case "reverse":
                        int reverseStart = int.Parse(inputParams[2]);
                        int reverseCount = int.Parse(inputParams[4]);
                        Reverse(array, reverseStart, reverseCount);
                        break;
                    case "sort":
                        int sortStart = int.Parse(inputParams[2]);
                        int sortCount = int.Parse(inputParams[4]);
                        Sort(array, sortStart, sortCount);
                        break;
                    case "rollLeft":
                        int leftStart = int.Parse(inputParams[2]);
                        int leftCount = int.Parse(inputParams[4]);
                        RollLeft(array, leftStart, leftCount);
                        break;
                    case "rollRight":
                        int rightStart = int.Parse(inputParams[2]);
                        int rightCount = int.Parse(inputParams[4]);
                        RollRight(array, rightStart, rightCount);
                        break;
                }

                inputLine = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        private static void RollRight(List<string> array, int rightStart, int rightCount)
        {
            throw new NotImplementedException();
        }

        private static void RollLeft(List<string> array, int leftStart, int leftCount)
        {
            throw new NotImplementedException();
        }

        private static void Sort(List<string> array, int sortStart, int sortCount)
        {
            array.Sort(sortStart, sortCount, null);
        }

        private static void Reverse(List<string> array, int reverseStart, int reverseCount)
        {
            array.Reverse(reverseStart, reverseCount);
        }
    }
}
