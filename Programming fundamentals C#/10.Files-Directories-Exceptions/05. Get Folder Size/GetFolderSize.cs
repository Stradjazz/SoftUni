using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _05.Get_Folder_Size
{
    //You are given a folder named “TestFolder”. Get the size of all files in the folder, which are NOT directories. The result should be 
    //written to another text file in Megabytes.
    class GetFolderSize
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../TestFolder");
            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("../../output.txt", sum.ToString());
        }
    }
}
