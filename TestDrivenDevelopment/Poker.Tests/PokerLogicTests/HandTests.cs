namespace PokerLogic.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using NUnit.Framework;
    using Poker;
    using Poker.Tests.PokerHandsCheckerTests;

    [TestFixture]
    public class HandTests
    {
        [Test]
        public void ToString_ReturnStringForEmptyHand_CreateHandWithEmptyCollectionOfCards()
        {
            IList<ICard> cards = new List<ICard>() { };
            Hand hand = new Hand(cards);
            string result = hand.ToString();
            string expectedResult = "Your hand is empty.";
            Assert.AreEqual(expectedResult, result);
        }

        public void ToString_ReturnStringOfAllCards_CreateHandFromCollectionOfCards()
        {
            IHand hand = PokerHandsCheckerSetup.highCard;
            string result = hand.ToString();
            int expectedResult = hand.Cards.Sum(x => x.ToString().Length);
            Assert.AreEqual(expectedResult, result.Length);
        }
    }
}
