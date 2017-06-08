using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    /*Write a program, which, given an image resolution (width and height), calculates its megapixels. Megapixels (short for millions 
    of pixels) are calculated by counting all the image pixels, then dividing the result by 1000000. 
    The megapixels must always be rounded to the first digit after the decimal point (i.e. 0.786 MP => 0.8MP).
    Input
    •	First Line – the width of the image – integer in range [1…20000]
    •	Second Line – the height of the image – integer in range [1…20000] */
    class Megapixels
    {
        static void Main(string[] args)
        {
            long width = int.Parse(Console.ReadLine());
            long height = int.Parse(Console.ReadLine());
            double resolution = (width * height) / 1000000.0;

            Console.WriteLine($"{width}x{height} => {Math.Round(resolution, 1)}MP");
        }
    }
}
