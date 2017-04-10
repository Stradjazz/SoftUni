using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _02.Line_Numbers
{
    //Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another 
    //text file.
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("LabText.txt");
            List<string> numberedLines = new List<string>();
            var index = 1;
            foreach (var line in file)
            {
                numberedLines.Add($"{index}. " + line);
                index++;
            }
            File.WriteAllLines("output.txt", numberedLines);
            Console.WriteLine(string.Join("\r\n", numberedLines));
        }
    }
}
