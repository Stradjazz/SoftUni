using System;

namespace _04._Pascal_Triangle
{
    class PascalTriangle
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            long currentWidth = 1;
            long[][] triangle = new long[height][];
            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new long[currentWidth];
                triangle[currentHeight][0] = 1;
                triangle[currentHeight][currentWidth - 1] = 1;
                

                if (currentHeight >= 2)
                {
                    for (int widthCounter = 1; widthCounter < currentWidth - 1; widthCounter++)
                    {
                        triangle[currentHeight][widthCounter] = triangle[currentHeight - 1][widthCounter - 1] + triangle[currentHeight - 1][widthCounter];
                    }
                }
                currentWidth++;
            }
            for (int rows = 0; rows < triangle.Length; rows++)
            {
                for (int columns = 0; columns < triangle[rows].Length; columns++)
                {
                    Console.Write(triangle[rows][columns]);
                }
                Console.WriteLine();
            }
        }
    }
}
