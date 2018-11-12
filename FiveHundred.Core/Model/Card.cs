using System;

namespace FiveHundred.Core
{
    public enum CardTypes { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace, Joker };
    public enum Suits { Spades, Clubs, Diamonds, Hearts };

    public class Card
    {
        CardTypes _type;
        Suits _suit;
        public Card(CardTypes type)
        {
            if (type != CardTypes.Joker)
                throw new ArgumentException("Invalid Card Type", "type");

            _type = type;
        }
        public Card(CardTypes type, Suits suit)
        {
            if (type == CardTypes.Joker)
                throw new ArgumentException("Invalid Card Type", "type");

            _type = type;
            _suit = suit;
        }

        public override string ToString()
        {
            var result = "";
            switch (_type)
            {
                case CardTypes.Two: result = "2"; break;
                case CardTypes.Three: result = "3"; break;
                case CardTypes.Four: result = "4"; break;
                case CardTypes.Five: result = "5"; break;
                case CardTypes.Six: result = "6"; break;
                case CardTypes.Seven: result = "7"; break;
                case CardTypes.Eight: result = "8"; break;
                case CardTypes.Nine: result = "9"; break;
                case CardTypes.Ten: result = "10"; break;
                case CardTypes.Jack: result = "J"; break;
                case CardTypes.Queen: result = "Q"; break;
                case CardTypes.King: result = "K"; break;
                case CardTypes.Ace: result = "A"; break;
                case CardTypes.Joker: return "Joker";
            }

            switch (_suit)
            {
                case Suits.Spades: return result += "S";
                case Suits.Clubs: return result += "C";
                case Suits.Diamonds: return result += "D";
                case Suits.Hearts: return result += "H";
            }

            throw new Exception("Invalid Card");
        }
    }
}
