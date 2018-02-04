using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _10._Simple_Text_Editor
{
    class SimpleTextEditor
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            var oldVersions = new Stack<string>();
            var text = new StringBuilder();

            for (int counter = 0; counter < commandsCount; counter++)
            {
                string[] commandInput = Console.ReadLine().Split();
                int currentCommand = int.Parse(commandInput[0]);

                switch (currentCommand)
                {
                    case 1:
                        oldVersions.Push(text.ToString());
                        string someString = commandInput[1];
                        text.Append(someString);
                        break;
                    case 2:
                        oldVersions.Push(text.ToString());
                        int length = int.Parse(commandInput[1]);
                        int startIndex = text.Length - length;
                        text.Remove(startIndex, length);
                        break;
                    case 3:
                        int index = int.Parse(commandInput[1]);
                        Console.WriteLine(text[index - 1]);
                        break;
                    case 4:
                        text.Clear();
                        text.Append(oldVersions.Pop());
                        break;
                }
            }
        }
    }
}
