using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Files
    {
        static void Main(string[] args)
        {
            var rootFileSize = new Dictionary<string, Dictionary<string, long>>();
            var pattern = @"(?<filename>.*?\.\w+);(?<filesize>\d+)\b";
            var regex = new Regex(pattern);

            int inputCount = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < inputCount; i++)
            {
                var directories = Console.ReadLine().Split(@"\".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
                //root\folder\filename.extension;filesize
                var root = directories[0];
                string filename = string.Empty;
                long filesize = 0;

                foreach (var item in directories)
                {
                    var match = regex.Match(item);
                    if (regex.IsMatch(item))
                    {
                        filename = match.Groups["filename"].Value;
                        filesize = long.Parse(match.Groups["filesize"].Value);
                    }
                    
                }
                
                if (!rootFileSize.ContainsKey(root))
                {
                    rootFileSize[root] = new Dictionary<string, long>();
                }
                if (!rootFileSize[root].ContainsKey(filename))
                {
                    rootFileSize[root][filename] = filesize;
                }
                rootFileSize[root][filename] = filesize;
            }

            //write query “{extension} in {root}”. 
            var query = Console.ReadLine().Split();
            var extension = query[0];
            var queryRoot = query[2];

            var result = new Dictionary<string, long>();

            foreach (var filePath in rootFileSize)
            {
                var currentRoot = filePath.Key;
                var fileSizes = filePath.Value;

                foreach (var file in fileSizes)
                {
                    var fileExt = file.Key.Substring(file.Key.LastIndexOf('.') + 1);
                    if (currentRoot == queryRoot && fileExt == extension)
                    {
                        result.Add(file.Key, file.Value);
                    }
                }

            }
            if (result.Count > 0)
            {
                result = result.OrderByDescending(file => file.Value).ThenBy(file => file.Key).ToDictionary(file => file.Key, file => file.Value);
                foreach (var file in result)
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
