﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    /*You are given a sequence of people and for every person what cards he draws from the deck. The input will be separate lines in the format: {personName}: {PT, PT, PT,… PT}
    Where P (2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A) is the power of the card and T (S, H, D, C) is the type. The input ends when a "JOKER" is drawn. The name can contain any ASCII symbol except ':'. 
    The input will always be valid and in the format described, there is no need to check it.
    A single person cannot have more than one card with the same power and type, if they draw such a card they discard it. The people are playing with multiple decks. Each card has a value 
    that is calculated by the power multiplied by the type. Powers 2 to 10 have the same value and J to A are 11 to 14. Types are mapped to multipliers the following way (S -> 4, H-> 3, D -> 2, C -> 1).
    Finally print out the total value each player has in his hand in the format: {personName}: {value} */
    class HandsOfCards
    {
        static void Main(string[] args)
        {
            var namesCards = new Dictionary<string, List<int>>();

            var line = Console.ReadLine();
            while (line != "JOKER")
            {
                var tokens = line.Split(':');
                var name = tokens[0];
                var cards = tokens[1]
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(CalculateCardValue)
                    .ToArray();

                if (!namesCards.ContainsKey(name))
                {
                    namesCards[name] = new List<int>();
                }
                namesCards[name].AddRange(cards);

                line = Console.ReadLine();
            }

            foreach (var nameCards in namesCards)
            {
                var name = nameCards.Key;
                var cards = nameCards.Value;

                var totalSumCards = cards.Distinct().Sum();

                Console.WriteLine($"{name}: {totalSumCards}");
            }
        }

        static int CalculateCardValue(string card)
        {
            var cardPowers = new Dictionary<string, int>();

            cardPowers["J"] = 11;
            cardPowers["Q"] = 12;
            cardPowers["K"] = 13;
            cardPowers["A"] = 14;

            for (int i = 2; i <= 10; i++)
            {
                cardPowers[i.ToString()] = i;
            }
            var cardTypes = new Dictionary<string, int>();

            cardTypes["S"] = 4;
            cardTypes["H"] = 3;
            cardTypes["D"] = 2;
            cardTypes["C"] = 1;

            var power = card.Substring(0, card.Length - 1);
            var type = card.Substring(card.Length - 1);

            var value = cardPowers[power] * cardTypes[type];
            return value;
        }
    }
}
