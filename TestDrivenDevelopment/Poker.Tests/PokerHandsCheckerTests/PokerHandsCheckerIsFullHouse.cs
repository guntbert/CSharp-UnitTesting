namespace Poker.Tests.PokerHandsCheckerTests
{
    using NUnit.Framework;

    [TestFixture]
    internal class PokerHandsCheckerIsFullHouse
    {
        [Test]
        public void IsFullHouse_ReturnTrue_IsFullHouse()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.fullHouse;
            Assert.IsTrue(checker.IsFullHouse(hand));
        }

        [Test]
        public void IsFullHouse_ReturnFalse_IsThreeOfAKind()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.threeOfAKind;
            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [Test]
        public void IsFullHouse_ReturnFalse_IsTwoPair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.twoPairs;
            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [Test]
        public void IsFullHouse_ReturnFalse_IsOnePair()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.onePair;
            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [Test]
        public void IsFullHouse_ReturnFalse_IsHighCard()
        {
            PokerHandsChecker checker = new PokerHandsChecker();
            IHand hand = PokerHandsCheckerSetup.highCard;
            Assert.IsFalse(checker.IsFullHouse(hand));
        }
    }
}
