using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Tetris
{
    /*  You will receive an integer N. On the next several lines, you will receive commands in the form of directions – left, right, up and down
        Your task is to print the famous Tetris block – the T-shape, facing the given direction, with a size of N.
        When you receive the command “exit”, you should stop the program execution.  */
    class Tetris
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "up":
                        Up(n);
                        break;
                    case "right":
                        Right(n);
                        break;
                    case "down":
                        Down(n);
                        break;
                    case "left":
                        Left(n);
                        break;
                }

                currentDirection = Console.ReadLine();
            }
        }

        static void Left(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n)
                    + new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n)
                    + new string('*', n));
            }
        }

        static void Right(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n)
                    + new string('.', n)
                    );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n)
                    + new string('.', n)
                    );
            }
        }

        static void Up(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('.', n)
                        + new string('*', n)
                        + new string('.', n)
                        );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('*', n * 3)
                        );
            }
        }

        static void Down(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('*', n * 3)
                        );
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('.', n)
                        + new string('*', n)
                        + new string('.', n)
                        );
            }
        }
    }
}
