namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsStraightFlush
    {
        [Test]
        public void IsStraightFlush_ReturnTrue_IsStraightFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.straightFlush;
            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        [Test]
        public void IsStraightFlush_ReturnFalse_IsFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.flush;
            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [Test]
        public void IsStraightFlush_ReturnFalse_IsStraight()
        {              
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.straight;
            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [Test]
        public void IsStraightFlush_ReturnFalse_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsFalse(checker.IsStraightFlush(hand));
        }
    }
}
