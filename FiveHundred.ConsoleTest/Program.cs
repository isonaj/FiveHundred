using FiveHundred.Core.Model;
using System;

namespace FiveHundred.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new FiveHundredDeck();
            deck.Shuffle();

            while (deck.Cards > 0)
            {
                var card = deck.DealCard();
                Console.Write(card.ToString() + " ");
            }

            Console.ReadLine();
        }
    }
}
