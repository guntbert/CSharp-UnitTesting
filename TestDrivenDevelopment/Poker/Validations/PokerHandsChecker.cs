namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }

            if (hand.Cards.Count != hand.Cards.Distinct().ToList().Count)
            {
                return false;
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            if (hand.Cards.Select(x => x.Face).ToList().Distinct().ToList().Count() == 2)
            {
                List<ICard> ordered = hand.Cards.OrderBy(x => x.Face).ToList();
                if (ordered[0].Face == ordered[3].Face ||
                    ordered[1].Face == ordered[4].Face)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var suit = hand.Cards[0].Suit;

            for (int i = 1; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            if(this.IsValidHand(hand))
            {
                HashSet<CardFace> set = new HashSet<CardFace>();
                foreach (ICard card in hand.Cards)
                {
                    set.Add(card.Face);
                }

                if(set.Count == 4)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
