using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            var amountOfCash = decimal.Parse(Console.ReadLine());
            var numberOfGuests = long.Parse(Console.ReadLine());
            var pricePerBanana = decimal.Parse(Console.ReadLine());
            var pricePerEgg = decimal.Parse(Console.ReadLine());
            var pricePerKgBerries = decimal.Parse(Console.ReadLine());

            var portions = 6;
            var portionSets = 1;
            while (numberOfGuests > portions)
            {
                portions += 6;
                portionSets++;
            }
            if (numberOfGuests < 1)
            {
                portions = 0;
                portionSets = 0;
            }

            var totalBananas = (pricePerBanana * 2) * portionSets;
            var totalEggs = (pricePerEgg * 4) * portionSets;
            var totalBerries = (pricePerKgBerries * 2 / 10) * portionSets;

            var totalPrice = totalBananas + totalEggs + totalBerries;

            if (amountOfCash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - amountOfCash):F2}lv more.");
            }
        }
    }
}
