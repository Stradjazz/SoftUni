using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    /*You invented a new groundbreaking technology to predict the weather, using numerology. You will be given a number from the console 
     and with it, you can predict tomorrow’s weather. Your system works in the following way:
    -If the number can fit in sbyte (for C#) or byte (for Java) – the weather will be “Sunny”
    -If the numbers can fit in int – the weather will be “Cloudy”
    -If the number fits in long – the weather will be “Windy”
    -If it is floating point number – the weather will be “Rainy”
     Always print the smallest possible option.*/
    class WeatherForecast
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            string weather = String.Empty;
            input = Math.Abs(input);

            if (input != Math.Truncate(input))
            {
                weather = "Rainy";
            }
            else
            {
                if (input <= sbyte.MaxValue)
                {
                    weather = "Sunny";
                }
                else if (input > sbyte.MaxValue && input <= int.MaxValue)
                {
                    weather = "Cloudy";
                }
                else 
                {
                    weather = "Windy";
                }
            }
            Console.WriteLine(weather);
        }
    }
}
