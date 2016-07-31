namespace Poker.Tests.PokerHandsCheckerTests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsThreeOfAKind
    {
        [Test]
        public void IsThreeOfAKind_ReturnsTrue_ThereIsASetOfThreeCardsWithSameFace()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Clubs)
            });

            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsThreeOfAKind_ReturnsFalse_IsFourOfAKind()
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

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsThreeOfAKind_ReturnsFalse_IsTwoPairs()
        {
            PokerHandsChecker checker = new PokerHandsChecker();

            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs)
            });

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }
    }
}
