using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Track_Downloader
{
    //You will receive a list of blacklisted words (on the same line, separated by one space). 
    //On the next lines, you will start receiving a list of filenames (as strings) until you receive the string “end”. 
    //Your task is to add the filenames to a list and sort them. Ignore the tracks which contain the text in the blacklist.
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blacklist = Console.ReadLine()
                .Split(' ')
                .ToList();
            var files = Console.ReadLine();
            var downloads = new List<string>();
            
            while (files != "end")
            {
                bool isBlacklisted = false;
                foreach (var keyword in blacklist)
                {
                    if (files.Contains(keyword))
                    {
                        isBlacklisted = true;
                        break;
                    }
                    
                }
                if (!isBlacklisted)
                {
                    downloads.Add(files);
                }
                files = Console.ReadLine();
            }
            downloads.Sort();
            foreach (var track in downloads)
            {
                Console.WriteLine(track);
            }
           
        }
    }
}
