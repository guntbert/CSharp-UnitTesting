namespace Poker.Tests
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;

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
            IList<ICard> cards = new List<ICard>()
            {
                new Card(CardFace.Eight, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Diamonds)
            };

            IHand hand = new Hand(cards);
            string result = hand.ToString();
            int expectedResult = cards.Sum(x => x.ToString().Length);
            Assert.AreEqual(expectedResult, result.Length);
        }
    }
}
