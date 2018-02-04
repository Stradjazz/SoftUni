using System;
using System.Collections.Generic;

namespace _09._Stack_Fibbonacci
{
    class StackFibbonacci
    {
        static void Main(string[] args)
        {
            var fibboCount = int.Parse(Console.ReadLine());

            var fibbonacciStack = new Stack<int>();

            fibbonacciStack.Push(0);

            var firstOperand = fibbonacciStack.Pop();
            fibbonacciStack.Push(1);
            var secondOperand = fibbonacciStack.Peek();
            var currentNum = firstOperand + secondOperand; 
            
            for (int counter = 2; counter < fibboCount; counter++)
            {
                firstOperand = fibbonacciStack.Pop();
                fibbonacciStack.Push(currentNum);
                secondOperand = fibbonacciStack.Peek();
                currentNum = firstOperand + secondOperand;
            }
            Console.WriteLine(currentNum);
        }
    }
}
