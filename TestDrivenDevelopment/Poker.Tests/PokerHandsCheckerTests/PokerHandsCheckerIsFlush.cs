namespace Poker.Tests.HandsChecker
{
    using System.Collections.Generic;
    using NUnit.Framework;
    
    [TestFixture]
    public class PokerHandsCheckerIsFlush
    {
        [Test]
        public void IsFlush_ReturnsTrue_AllCardsAreFromTheSameSuit()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ReturnsFalse_OneCardIsFromOtherSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ReturnsFalse_TwoCardsAreFromOtherSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ReturnsFalse_ThreeCardsAreFromOtherSuits()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds)
            });

            Assert.IsFalse(checker.IsFlush(hand));
        }
    }
}
