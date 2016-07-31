namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsThreeOfAKind
    {
        [Test]
        public void IsThreeOfAKind_ReturnTrue_IsThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.threeOfAKind;
            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsThreeOfAKind_ReturnFalse_IsFourOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.fourOfAKind;
            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [Test]
        public void IsThreeOfAKind_ReturnFalse_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }
    }
}
