namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsStraight
    {
        [Test]
        public void IsStraight_ReturnTrue_IsStraight()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.straight;
            Assert.IsTrue(checker.IsStraight(hand));
        }

        [Test]
        public void IsStraight_ReturnFalse_CardsAreStraightFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.straightFlush;
            Assert.IsFalse(checker.IsStraight(hand));
        }

        [Test]
        public void IsStraight_ReturnFalse_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsFalse(checker.IsStraight(hand));
        }
    }
}
