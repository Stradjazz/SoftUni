using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var sortedDemons = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                int health = 0;
                double damage = 0.0;
                health = CalculateHealth(demon, health);
                damage = CalculateDamage(demon, damage);

                sortedDemons.Add(demon, new Demon
                {
                    Name = demon,
                    Health = health,
                    Damage = damage
                });
            }

            foreach (var demon in sortedDemons)
            {
                var name = demon.Key;
                var stats = demon.Value;
                Console.WriteLine($"{name} - {stats.Health} health, {stats.Damage:F2} damage");
            }
        }

        private static double CalculateDamage(string demon, double damage)
        {
            var pattern = @"-?\d+\.?\d*";
            var regex = new Regex(pattern);

            MatchCollection damageSymbols = Regex.Matches(demon, pattern);
            

            foreach (Match number in damageSymbols)
            {
                var damageValue = double.Parse(number.Value);
                damage += damageValue;
            }
            var modifyers = demon.Where(s => s == '*' || s == '/');

            foreach (var modifyer in modifyers)
            {
                if (modifyer == '*')
                {
                    damage *= 2;
                }
                else if (modifyer == '/')
                {
                    damage /= 2;
                }
            }
            return damage;
        }

        private static int CalculateHealth(string demon, int health)
        {
            var healthSymbols = demon.Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.').ToArray();
            
            foreach (var symbol in healthSymbols)
            {
                health += symbol;
            }
            return health;
        }
    }
}
