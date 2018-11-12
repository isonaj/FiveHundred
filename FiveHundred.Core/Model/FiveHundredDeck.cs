using System;
using System.Collections.Generic;
using System.Text;

namespace FiveHundred.Core.Model
{
    public class FiveHundredDeck: Deck
    {
        List<Card> _cards;
        public int Cards => _cards.Count;

        public FiveHundredDeck()
        {
            _cards = new List<Card>();

            _cards.Add(new Card(CardTypes.Joker));
            foreach (var suit in (Suits[])Enum.GetValues(typeof(Suits)))
            {
                int start = 4;
                if (suit == Suits.Clubs || suit == Suits.Spades)
                    start = 5;
                
                for (var t = start; t <= 14; t++)
                    _cards.Add(new Card((CardTypes)t, suit));
            }
        }

        public void Shuffle()
        {
            var rand = new Random();
            var newDeck = new List<Card>();
            while (_cards.Count > 0)
            {
                var idx = rand.Next(0, _cards.Count - 1);
                newDeck.Add(_cards[idx]);
                _cards.RemoveAt(idx);
            }

            _cards = newDeck;
        }

        public Card DealCard()
        {
            if (Cards == 0)
                throw new Exception("Deck is empty");

            var card = _cards[0];
            _cards.RemoveAt(0);
            return card;
        }
    }
}
