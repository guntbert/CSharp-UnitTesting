namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsFourOfAKind
    {
        [Test]
        public void IsFourOfAKind_ReturnTrue_IsFourOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.fourOfAKind;
            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ReturnFalse_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [Test]
        public void IsFourOfAKind_ReturnFalse_IsThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.threeOfAKind;
            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }
    }
}
