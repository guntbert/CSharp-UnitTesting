namespace Poker.Tests.PokerHandsCheckerTests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsFourOfAKind
    {
        [Test]
        public void IsFourOfAKind_ReturnsTrue_FourCardsHaveTheSameFace()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs)
            });

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ReturnsFalse_IsTwoPairs()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs)
            });

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ReturnsFalse_IsThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs)
            });

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }
    }
}
