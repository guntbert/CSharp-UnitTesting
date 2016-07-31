namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsHighCard
    {
        [Test]
        public void IsHighCard_ReturnTrue_IsHighCard()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.highCard;

            Assert.IsTrue(checker.IsHighCard(hand));
        }

        [Test]
        public void IsHighCard_ReturnFalse_IsFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.flush;
            Assert.IsFalse(checker.IsHighCard(hand));
        }

        [Test]
        public void IsHighCard_ReturnFalse_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsFalse(checker.IsHighCard(hand));
        }
    }
}
