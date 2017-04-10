using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _04.Merge_Files
{
    //Write a program that reads the contents of two text files and merges them together into a third one.
    class MergeFiles
    {
        static void Main(string[] args)
        {
            string[] firstInput = File.ReadAllText("../../input1.txt")
                .Split(new[] { '\n', '\r', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondInput = File.ReadAllText("../../input2.txt")
                .Split(new[] { '\n', '\r', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < firstInput.Length; i++)
            {
                File.AppendAllText("../../output.txt", firstInput[i] + Environment.NewLine + secondInput[i] + Environment.NewLine);
            }
        }
    }
}
