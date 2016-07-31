namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;
    
    [TestFixture]
    internal class PokerHandsCheckerIsTwoPair
    {
        [Test]
        public void IsTwoPair_ReturnTrue_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsTrue(checker.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ReturnFalse_IsOnePair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.onePair;
            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ReturnFalse_IsThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.threeOfAKind;
            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [Test]
        public void IsTwoPair_ReturnFalse_IsFourOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.fourOfAKind;
            Assert.IsFalse(checker.IsTwoPair(hand));
        }
    }
}
