using FiveHundred.Core;
using FiveHundred.Core.Model;
using System;
using System.Collections.Generic;

namespace FiveHundred.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new FiveHundredDeck();
            deck.Shuffle();

            var cards = new List<List<Card>> {
                new List<Card>(),
                new List<Card>(),
                new List<Card>(),
                new List<Card>(),
                new List<Card>()
            };

            var cardCounts = new int[3] { 3, 4, 3 };
            for (var round = 0; round < 3; round++)
            {
                var cardCount = cardCounts[round];
                for (var player = 0; player <= 3; player++)
                    for (var i = 0; i < cardCount; i++)
                        cards[player].Add(deck.DealCard());

                cards[4].Add(deck.DealCard());
            }

            var hands = new List<Hand>
            {
                new Hand(cards[0]),
                new Hand(cards[1]),
                new Hand(cards[2]),
                new Hand(cards[3]),
                new Hand(cards[4])
            };

            foreach (var hand in hands)
                Console.WriteLine($"Hand: {hand.ToString()}");

            Console.ReadLine();
        }
    }
}
