namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsOnePair
    {
        [Test]
        public void IsOnePair_ReturnTrue_IsOnePair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.onePair;
            Assert.IsTrue(checker.IsOnePair(hand));
        }

        [Test]
        public void IsOnePair_ReturnFalse_IsThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.threeOfAKind;
            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [Test]
        public void IsOnePair_ReturnFalse_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsFalse(checker.IsOnePair(hand));
        }
    }
}
