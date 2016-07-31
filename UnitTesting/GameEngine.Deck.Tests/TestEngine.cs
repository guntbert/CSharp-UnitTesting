namespace GameEngine.Deck.Tests
{
    using NUnit.Framework;
    using Santase.Logic;
    using Santase.Logic.Cards;

    [TestFixture]
    public class TestEngine
    {
        private const int TotalCards = 24;
        private const int Rounds = 3;

        [Test]
        public void StaticConstructor_HaveExactAmmountOfCards_CreateANewDeck()
        {
            Deck deck = new Deck();
            Assert.AreEqual(TotalCards, deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_ThrowInternalGameException_DeckIsEmpty()
        {
            Assert.Throws<InternalGameException>(() =>
            {
                Deck deck = new Deck();
                int defaultCount = deck.CardsLeft;
                for (int i = 0; i <= defaultCount; i++)
                {
                    deck.GetNextCard();
                }
            });
        }

        [Test]
        public void GetNextCard_HaveExactNumberOfCards_CertainAmmountOfRoundsHavePassed()
        {
            Deck deck = new Deck();
            for (int i = 0; i < Rounds; i++)
            {
                deck.GetNextCard();
            }

            Assert.AreEqual(TotalCards - Rounds, deck.CardsLeft);
        }

        [Test, Combinatorial]
        public void ChangeTrumpCard_ShouldChangeTrumpCard_SettingNewTrumpCard([Values]CardSuit suit, [Values]CardType type)
        {
            Deck deck = new Deck();
            deck.ChangeTrumpCard(new Card(suit, type));
            Assert.AreEqual(new Card(suit, type), deck.TrumpCard);
        }
    }
}
