using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Resizable_Array
{
    class ResizableArray
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            var command = Console.ReadLine().Split().ToArray();

            while (command[0] != "end")
            {
                if (command[0] == "push")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "pop")
                {
                    list.RemoveAt(list.Count - 1);
                }
                else if (command[0] == "removeAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "clear")
                {
                    list.Clear();
                }
                command = Console.ReadLine().Split().ToArray();
            }

            if (list.Count > 0)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.WriteLine("empty array");
            }
        }
    }
}
