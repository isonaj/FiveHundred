using FiveHundred.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FiveHundred.Core.Tests.Model
{
    public class DeckTests
    {
        [Fact]
        public void CanCreateDeck()
        {
            var deck = new FiveHundredDeck();

            Assert.Equal(43, deck.Cards);
        }

        [Fact]
        public void CanShuffleDeck()
        {
            var deck = new FiveHundredDeck();
            var oldCount = deck.Cards;

            deck.Shuffle();

            Assert.Equal(oldCount, deck.Cards);
        }

    }
}
