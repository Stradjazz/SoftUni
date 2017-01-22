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
            int pictures = int.Parse(Console.ReadLine());
            int timePerPic = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());
            double goodPics = Math.Ceiling(pictures * filterFactor / 100.0);

            long seconds = (pictures * timePerPic) + (long)(goodPics * uploadTime);
            TimeSpan totalTime = TimeSpan.FromSeconds(seconds);
            string print = totalTime.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(print);
        }
    }
}
