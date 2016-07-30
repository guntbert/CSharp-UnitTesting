namespace Poker.Tests
{
    using Poker;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class CardTests
    {
        [Test]
        public void Constructor_ShouldThrowArgumentException_ValueOfCardFaceIsNotLegit()
        {
            Assert.Throws<ArgumentException>(() => new Card((CardFace)15, CardSuit.Diamonds));
        }

        [Test]
        public void Constructor_ShouldThrowArgumentException_ValueOfCardSuitIsNotLegit()
        {
            Assert.Throws<ArgumentException>(() => new Card(CardFace.Five, (CardSuit)5));
        }

        [Test, Combinatorial]
        public void ToString_ShouldReturnCardFaceAndCardSuitString_InvokeToString([Values]CardFace face, [Values]CardSuit suit)
        {
            Card card = new Card(face, suit);
            string result = card.ToString();
            string expectedResult = $"Card Face: {face} ; Card Suit: {suit}";
            Assert.AreEqual(expectedResult, result);
        }
    }
}
