using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    /*Write a program, which receives image metadata as input and prints information about the image, such as its filename, date taken, 
    size, resolution and aspect ratio. Also, calculate the orientation of the image. The 3 orientations are: portrait, landscape 
    and square.
    Input
    •	First line – the photo’s number – an integer in the range [0…9999]
    •	Second, third, fourth line – the day, month and year the photo was taken – integers forming valid dates in the 
        range [01/01/1990…31/12/2020]
    •	Fifth, sixth line – the hours and minutes the photo was taken – integers in the range [0…23]
    •	Seventh line – the photo’s size in bytes – integer in the range [0…999000000]
    •	Eighth, ninth line – the photo’s resolution (width and height) in pixels – integers in the range [1…10000]
    Output
    •	The name should be printed in the format “DSC_xxxx.jpg”.
    •	The date and time taken should be printed in the format “dd/mm/yyyy hh:mm”.
    •	The size should be printed in standard human-readable format (i.e. 950 bytes = 950B, 500000 bytes = 500KB, 1500000 bytes = 1.5MB).
    •	The resolution should be printed in the following format: “{width}x{height}”.
    •	The orientation can be one of three valid values: portrait, landscape and square.  */
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int picName = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            long bytes = long.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double size = 0;
            string sizeType = string.Empty;
            string orientation = string.Empty;

            if (bytes < 1000)
            {
                sizeType = "B";
                size = bytes;
            }
            else if (bytes >= 1000 && bytes < 1000000)
            {
                sizeType = "KB";
                size = bytes / 1000.0;
            }
            else 
            {
                sizeType = "MB";
                size = bytes / 1000000.0;
            }
            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: DSC_{picName:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours:D2}:{minutes:D2}");
            Console.WriteLine($"Size: {size}{sizeType}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
