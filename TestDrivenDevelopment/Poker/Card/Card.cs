using System;
using System.Collections;
using System.Collections.Generic;

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

        public override bool Equals(object obj)
        {
            Card x = obj as Card;
            if(this.Face == x.Face && this.Suit == x.Suit)
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int h = 17;
                h = h * 23 + this.Face.GetHashCode();
                h = h * 23 + this.Suit.GetHashCode();
                return h;
            }
        }
    }
}
