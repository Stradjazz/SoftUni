using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long pictures = long.Parse(Console.ReadLine());
            long timePerPic = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            double goodPics = Math.Ceiling(pictures * filterFactor / 100.0);

            long seconds = (pictures * timePerPic) + (long)(goodPics * uploadTime);
            TimeSpan totalTime = TimeSpan.FromSeconds(seconds);
            string print = totalTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(print);
        }
    }
}
