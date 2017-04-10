using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace _01.Odd_Lines
{
    //Write a program that reads a text file and writes its every odd line in another file. Line numbers starts from 0.

    class OddLines
    {
        static void Main(string[] args)
        {
            string[] file = File.ReadAllLines("LabText.txt");
            var currentLine = String.Empty;
            var oddLines = new List<string>();
            for (int i = 0; i < file.Length; i++)
            {
                if (i % 2 != 0)
                {
                    currentLine = file[i];
                    oddLines.Add(currentLine);
                }
            }
            File.WriteAllLines("output.txt", oddLines);
            
            Console.WriteLine(String.Join(System.Environment.NewLine, oddLines ));
        }
    }
}
