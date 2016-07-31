namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        // Additional XML documentation will be created later. 

        /// <summary>
        /// Determines whether the selected IHand object is valid. The method checks ammount of Card object in IHand object and determines if equal objects are present.
        /// </summary>
        /// <param name="hand">The specified IHand object.</param>
        /// <returns>
        ///   <c>true</c> if the IHand has no duplicate Card entries and Card count in hand is exactly 5; otherwise, <c>false</c>.
        /// </returns>
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

        /// <summary>
        /// Determines whether the specified IHand object is Straight Flush. Method implements IsFlush() and IsStraight() logic to assure correct representation of results.
        /// </summary>
        /// <param name="hand">The specified IHand object.</param>
        /// <returns>
        ///   <c>true</c> if the object is straight flush only; otherwise, <c>false</c>.
        /// </returns>
        public bool IsStraightFlush(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                byte cardFaceSum = 0;
                byte straightSum = 0;

                List<ICard> ordered = hand.Cards.OrderByDescending(x => x.Face).ToList();

                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    cardFaceSum += (byte)ordered[i].Face;
                }

                for (byte i = (byte)ordered[straightSum].Face; i > (byte)(ordered[0].Face - 5); i--)
                {
                    straightSum += i;
                }

                byte numberOfGroupsByCardSuit = (byte)hand.Cards.GroupBy(x => x.Suit).ToList().Count;

                if (numberOfGroupsByCardSuit == 1 && cardFaceSum == straightSum)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified IHand object is is four of a kind hand. The method uses GroupBy() filtering to check the duplicated values.
        /// </summary>
        /// <param name="hand">The specified IHand object.</param>
        /// <returns>
        ///   <c>true</c> if [is four of a kind] [the specified hand]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFourOfAKind(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                int numberOfGroups = hand.Cards.GroupBy(x => x.Face).Count();
                int moreThanThreeCardsInGroup = hand.Cards.GroupBy(x => x.Face).Where(g => g.Count() > 3).Count();

                if (numberOfGroups == 2 && moreThanThreeCardsInGroup == 1)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                int numberOfGroups = hand.Cards.GroupBy(x => x.Face).Count();
                int moreThanTwoCardsInGroup = hand.Cards.GroupBy(x => x.Face).Where(g => g.Count() > 2).Count();

                if (numberOfGroups == 2 && moreThanTwoCardsInGroup == 1)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsFlush(IHand hand)
        {
            if (this.IsValidHand(hand) && !this.IsStraightFlush(hand))
            {
                byte numberOfGroupsByCardSuit = (byte)hand.Cards.GroupBy(x => x.Suit).ToList().Count;

                if (numberOfGroupsByCardSuit == 1)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsStraight(IHand hand)
        {
            if (this.IsValidHand(hand) && !this.IsStraightFlush(hand))
            {
                byte cardFaceSum = 0;
                byte straightSum = 0;

                List<ICard> ordered = hand.Cards.OrderByDescending(x => x.Face).ToList();

                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    cardFaceSum += (byte)ordered[i].Face;
                }

                for (byte i = (byte)ordered[straightSum].Face; i > (byte)(ordered[0].Face - 5); i--)
                {
                    straightSum += i;
                }

                if (cardFaceSum == straightSum)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                int numberOfGroups = hand.Cards.GroupBy(x => x.Face).Count();
                int moreThanTwoCardsInGroup = hand.Cards.GroupBy(x => x.Face).Where(g => g.Count() > 2).Count();

                if (numberOfGroups == 3 && moreThanTwoCardsInGroup == 1)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsTwoPair(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                byte numberOfGroups = (byte)hand.Cards.GroupBy(x => x.Face).Count();
                byte moreThanTwoCardsInGroup = (byte)hand.Cards.GroupBy(x => x.Face).Where(g => g.Count() > 2).Count();

                if (numberOfGroups == 3 && moreThanTwoCardsInGroup == 0)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsOnePair(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                byte numberOfGroups = (byte)hand.Cards.GroupBy(x => x.Face).ToList().Count;

                if (numberOfGroups == 4)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            if (this.IsValidHand(hand))
            {
                int numberOfGroupsByCardFace = hand.Cards.GroupBy(x => x.Face).ToList().Count;
                int numberOfGroupsByCardSuit = hand.Cards.GroupBy(x => x.Suit).ToList().Count;

                if (numberOfGroupsByCardFace == hand.Cards.Count && numberOfGroupsByCardSuit != 1)
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        /// <summary>
        /// The method compares different hands. Future implementation waiting.
        /// </summary>
        /// <param name="firstHand">First hand.</param>
        /// <param name="secondHand">Second hand.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
