using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

/*You will receive a folder called input, with various files with custom extensions. You may add or remove the files as you wish, 
but they are the only way to test your code. 
Write a program which accepts a single input line from the Console, holding an extension … like: “txt”, “bmp”, “rar” etc.
Print the NAMES AND EXTENSIONS of all files, which have the given extension.*/
namespace _01.Filter_Extensions
{
    class FilterExtensions
    {
        static void Main(string[] args)
        {
            var fileExtention = Console.ReadLine();
            var files = Directory.GetFiles("../../input");
            

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                if (fileInfo.Name.Contains(fileExtention))
                {
                    Console.WriteLine(fileInfo.Name);
                    File.AppendAllText("../../output.txt", fileInfo.Name + Environment.NewLine);
                }
            }
        }
    }
}
