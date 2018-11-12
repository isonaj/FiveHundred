using System;
using Xunit;

namespace FiveHundred.Core.Tests
{
    public class CardTests
    {
        [Fact]
        public void CanCreateCard()
        {
            var card = new Card(CardTypes.Seven, Suits.Hearts);

            Assert.Equal("7H", card.ToString());
        }

        [Fact]
        public void CanCreateJoker()
        {
            var card = new Card(CardTypes.Joker);

            Assert.Equal("Joker", card.ToString());
        }

        [Fact]
        public void CannotCreateJokerWithSuit()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var card = new Card(CardTypes.Joker, Suits.Hearts);
            });
        }

        [Fact]
        public void CannotCreateNonJokerWithNoSuit()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var card = new Card(CardTypes.Jack);
            });
        }
    }
}
