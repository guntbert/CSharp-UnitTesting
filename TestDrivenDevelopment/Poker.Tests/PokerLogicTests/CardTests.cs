namespace PokerLogic.Tests
{
    using System;
    using NUnit.Framework;
    using Poker;
    using Poker.Tests.PokerHandsCheckerTests;

    [TestFixture]
    public class CardTests
    {
        [Test]
        public void Constructor_ThrowArgumentException_ValueOfCardFaceIsNotLegit()
        {
            Assert.Throws<ArgumentException>(() => new Card((CardFace)15, CardSuit.Diamonds));
        }

        [Test]
        public void Constructor_ThrowArgumentException_ValueOfCardSuitIsNotLegit()
        {
            Assert.Throws<ArgumentException>(() => new Card(CardFace.Five, (CardSuit)5));
        }

        [Test, Combinatorial]
        public void ToString_ReturnCardFaceAndCardSuitString_InvokeToString([Values]CardFace face, [Values]CardSuit suit)
        {
            Card card = new Card(face, suit);
            string result = card.ToString();
            string expectedResult = $"{face} of {suit}";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
