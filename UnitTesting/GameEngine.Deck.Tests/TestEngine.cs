namespace GameEngine.Deck.Tests
{
    using Santase.Logic;
    using Santase.Logic.Cards;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class TestEngine
    {
        const int totalCards = 24;
        const int rounds = 3;

        [Test]
        public void StaticDeck_CreateNewDeck_ShouldHaveExactAmmountOfCards()
        {
            Deck deck = new Deck();
            Assert.AreEqual(totalCards, deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_EmptyDeck_ShouldThrowInternalGameException()
        {
            Assert.Throws<InternalGameException>(() => ThrowingInternalGameException());
        }

        public void ThrowingInternalGameException()
        {
            Deck deck = new Deck();
            int defaultCount = deck.CardsLeft;
            for (int i = 0; i <= defaultCount; i++)
            {
                deck.GetNextCard();
            }
        }

        [Test]
        public void GetNextCard_DeckStateAfterThreeRounds_ShouldHaveExactNumberOfCards()
        {
            Deck deck = new Deck();
            for (int i = 0; i < rounds; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(totalCards - rounds, deck.CardsLeft);
        }

        [Test, Combinatorial]
        public void ChangeTrumpCard_ChangeWithDifferentCards_ShouldChangeTrumpCard([Values]CardSuit suit, [Values]CardType type)
        {
            Deck deck = new Deck();
            deck.ChangeTrumpCard(new Card(suit, type));
            Assert.AreEqual(new Card(suit, type), deck.TrumpCard);
        }
    }
}
