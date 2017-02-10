﻿using System;

class PriceChangeAlert
{
    /*  You are assigned to rework a given piece of code which is working without bugs but is not properly formatted. 
        The given program tracks stock prices and gives updates about the significance in each price change. 
        Based on the significance, there are four kind of changes: no change at all (price is equal to the previous), 
        minor (difference is below the significance threshold), price up and price down. */
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double treshhold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = percentage(lastPrice, currentPrice);
            bool significantDifference = checkDifference(difference, treshhold);
            string message = Get(currentPrice, lastPrice, difference, significantDifference);
            Console.WriteLine(message);

            lastPrice = currentPrice;
        }
    }

    private static string Get(double currentPrice, double lastPrice, double difference, bool check)
    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!check)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (check && (difference > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (check && (difference < 0))
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        return to;
    }
    private static bool checkDifference(double treshhold, double isDiff)
    {
        if (Math.Abs(treshhold) >= isDiff)
        {
            return true;
        }
        return false;
    }

    private static double percentage(double lastPrice, double currentPrice)
    {
        double result = (currentPrice - lastPrice) / lastPrice;
        return result;
    }
}
