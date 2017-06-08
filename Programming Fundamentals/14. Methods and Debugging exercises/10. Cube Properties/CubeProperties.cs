using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    /*Write a program that can calculate the length of the face diagonals, space diagonals, volume and surface area of a cube by a given side. 
    On the first line you will get the side of the cube. On the second line is given the parameter (face, space, volume or area).
    Output should be rounded to the second digit after the decimal point. */
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double sideOfTheCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine().ToLower();//face, space, volume, area

            double valueToPrint = 0;

            switch (parameter)
            {
                case "face":
                    valueToPrint = FaceDiagonalOfTheCube(sideOfTheCube);
                    break;
                case "space":
                    valueToPrint = SpaceDiagonalOfTheCube(sideOfTheCube);
                    break;
                case "volume":
                    valueToPrint = VolumeOfTheCube(sideOfTheCube);
                    break;
                case "area":
                    valueToPrint = AreaOfTheCube(sideOfTheCube);
                    break;
            }
            Console.WriteLine("{0:F2}", valueToPrint);
        }
        public static double FaceDiagonalOfTheCube(double side)
        {
            return Math.Sqrt(2 * Math.Pow(side, 2));
        }
        public static double SpaceDiagonalOfTheCube(double side)
        {
            return Math.Sqrt(3 * Math.Pow(side, 2));
        }
        public static double VolumeOfTheCube(double side)
        {
            return Math.Pow(side, 3);
        }
        public static double AreaOfTheCube(double side)
        {
            return 6 * Math.Pow(side, 2);
        }
    }
}
