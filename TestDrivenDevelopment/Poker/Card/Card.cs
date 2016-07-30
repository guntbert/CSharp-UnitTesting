using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            if (((int)face < 15 && (int)face > 1))
            {
                if((int)suit < 5 && (int)suit > 0)
                {
                    this.Face = face;
                    this.Suit = suit;
                }
                else
                {
                    throw new ArgumentException("Invalid card suit.");
                }
            }
            else
            {
                throw new ArgumentException("Invalid card face.");
            }
        }

        public override string ToString()
        {
            return $"{this.Face} of {this.Suit}";
        }
    }
}
