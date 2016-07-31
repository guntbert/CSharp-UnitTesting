namespace Poker.Tests.PokerHandsCheckerTests
{
    using System.Collections.Generic;
    using NUnit.Framework;
    
    [TestFixture]
    internal class PokerHandsCheckerIsTwoPair
    {
        [Test]
        public void IsTwoPair_ReturnsTrue_TwoSetsOfOnePairsArePresent()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts)
            });

            Assert.IsTrue(checker.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ReturnsFalse_OnlyOnePairIsPresent()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts)
            });

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ReturnsFalse_IsThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Hearts)
            });

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ReturnsFalse_IsFourOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Hearts)
            });

            Assert.IsFalse(checker.IsTwoPair(hand));
        }
    }
}
