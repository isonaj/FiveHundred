using FiveHundred.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FiveHundred.Core.Tests.Model
{
    public class HandTests
    {
        [Fact]
        public void CanCreateHand()
        {
            var cards = new List<Card> { new Card(CardTypes.Joker), new Card(CardTypes.Ace, Suits.Clubs), new Card(CardTypes.Eight, Suits.Hearts) };
            var hand = new Hand(cards);

            Assert.Equal(3, hand.Cards);
            Assert.Equal("Joker AC 8H ", hand.ToString());
        }
    }
}
