namespace Poker.Tests.PokerHandsCheckerTests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsValid
    {
        [Test]
        public void IsValidHand_ReturnTrue_IsHighCard()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.highCard;

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ReturnFalse_ThereAreTwoSameCards()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
            });
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ReturnFalse_ThereAreMoreThanFiveCardsInHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Diamonds)
            });

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void IsValidHand_ReturnFalse_ThereAreLessThanFiveCardsInHand()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = new Hand(new List<ICard>()
            {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Diamonds),
                new Card(CardFace.Eight, CardSuit.Diamonds)
            });

            Assert.IsFalse(checker.IsValidHand(hand));
        }
    }
}
