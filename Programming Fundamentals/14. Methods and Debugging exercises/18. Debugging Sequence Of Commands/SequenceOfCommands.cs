﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Debugging_Sequence_Of_Commands
{
    class SequenceOfCommands
    {
        private const char ArgumentsDelimiter = ' ';
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] numbers = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

            string[] command = Console.ReadLine().Split(' ').ToArray();

            while (command[0] != "stop")
            {

                int[] args = new int[2];

                if (command[0] == "add" ||
                    command[0] == "subtract" ||
                    command[0] == "multiply")
                {

                    args[0] = int.Parse(command[1]);
                    args[1] = int.Parse(command[2]);
                    PerformAction(numbers, command[0], args);
                }
                else
                {
                    PerformAction(numbers, command[0], args);
                }
                PrintArray(numbers);

                Console.WriteLine();

                command = Console.ReadLine().Split(' ').ToArray();
            }
        }

        static void PerformAction(long[] array, string action, int[] args)
        {

            int position = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[position - 1] *= value;
                    break;
                case "add":
                    array[position - 1] += value;
                    break;
                case "subtract":
                    array[position - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;

            }
        }
        private static void ArrayShiftRight(long[] array)
        {
            long num = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = num;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long num = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = num;

        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
    }
}
