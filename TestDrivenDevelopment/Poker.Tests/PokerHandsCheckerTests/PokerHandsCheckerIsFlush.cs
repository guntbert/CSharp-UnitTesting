namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;
    
    [TestFixture]
    internal class PokerHandsCheckerIsFlush
    {
        [Test]
        public void IsFlush_ReturnTrue_IsFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.flush;
            Assert.IsTrue(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ReturnFalse_IsStraightFlush()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.straightFlush;
            Assert.IsFalse(checker.IsFlush(hand));
        }

        [Test]
        public void IsFlush_ReturnFalse_IsStraight()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.straight;
            Assert.IsFalse(checker.IsFlush(hand));
        }
    }
}
