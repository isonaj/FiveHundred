using System;
using System.Collections.Generic;
using System.Text;

namespace FiveHundred.Core.Model
{
    public class Hand
    {
        List<Card> _cards = new List<Card>();
        public int Cards => _cards.Count;

        public Hand(IEnumerable<Card> cards)
        {
            _cards.AddRange(cards);
        }

        public override string ToString()
        {
            var result = "";
            foreach (var card in _cards)
                result += card.ToString() + " ";
            return result;
        }

        public void PlayCard()
        {

        }
    }
}
