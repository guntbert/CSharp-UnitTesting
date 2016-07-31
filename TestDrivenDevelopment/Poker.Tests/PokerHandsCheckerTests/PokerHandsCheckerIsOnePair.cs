namespace Poker.Tests.PokerHandsCheckerTests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsOnePair
    {
        [Test]
        public void IsOnePair_ReturnTrue_OnlyTwoCardsHaveTheSameFace()
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

            Assert.IsTrue(checker.IsOnePair(hand));
        }
    }
}
