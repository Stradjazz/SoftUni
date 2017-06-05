using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    /*Write a program, which helps tourists convert imperial units of measurement to metric units. Your program needs to support 
     the following conversions: miles to kilometers, inches to centimeters, feet to centimeters, yards to meters and gallons to liters.
     The input will be on two lines:
     -On the first line, you will receive the imperial unit, which you need to convert
     -On the second line, you will receive the value, which you need to convert
     Print the answer in the following format:
     {initial value} {initial imperial unit} = {converted value} {metric unit}
     Format the converted value to the 2 nd decimal place. Print the initial value as it is given.*/
    class TouristInfo
    {
        static void Main(string[] args)
        {
            string imperialType = Console.ReadLine();
            double imperialValue = double.Parse(Console.ReadLine());
            double convertedValue = 0;

            switch (imperialType)
            {
                case "miles":
                    convertedValue = imperialValue * 1.6;
                    Console.WriteLine($"{imperialValue} {imperialType} = {convertedValue:F2} kilometers");
                    break;
                case "inches":
                    convertedValue = imperialValue * 2.54;
                    Console.WriteLine($"{imperialValue} {imperialType} = {convertedValue:F2} centimeters");
                    break;
                case "feet":
                    convertedValue = imperialValue * 30;
                    Console.WriteLine($"{imperialValue} {imperialType} = {convertedValue:F2} centimeters");
                    break;
                case "yards":
                    convertedValue = imperialValue * 0.91;
                    Console.WriteLine($"{imperialValue} {imperialType} = {convertedValue:F2} meters");
                    break;
                case "gallons":
                    convertedValue = imperialValue * 3.8;
                    Console.WriteLine($"{imperialValue} {imperialType} = {convertedValue:F2} liters");
                    break;
            }
        }
    }
}
