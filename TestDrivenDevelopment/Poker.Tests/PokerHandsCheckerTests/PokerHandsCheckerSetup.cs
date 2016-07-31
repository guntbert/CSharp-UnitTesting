namespace Poker.Tests.PokerHandsCheckerTests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    [SetUpFixture]
    internal class PokerHandsCheckerSetup
    {
        public static IHand highCard = new Hand(new List<ICard>()
        {
            new Card(CardFace.Five, CardSuit.Hearts),
            new Card(CardFace.Six, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Diamonds),
            new Card(CardFace.Nine, CardSuit.Diamonds)
        });

        public static IHand onePair = new Hand(new List<ICard>()
        {
            new Card(CardFace.Six, CardSuit.Diamonds),
            new Card(CardFace.Six, CardSuit.Clubs),
            new Card(CardFace.Seven, CardSuit.Spades),
            new Card(CardFace.Eight, CardSuit.Diamonds),
            new Card(CardFace.Nine, CardSuit.Hearts)
        });

        public static IHand twoPairs = new Hand(new List<ICard>()
        {
            new Card(CardFace.Six, CardSuit.Diamonds),
            new Card(CardFace.Six, CardSuit.Clubs),
            new Card(CardFace.Eight, CardSuit.Spades),
            new Card(CardFace.Eight, CardSuit.Diamonds),
            new Card(CardFace.Nine, CardSuit.Hearts)
        });

        public static IHand threeOfAKind = new Hand(new List<ICard>()
        {
            new Card(CardFace.Seven, CardSuit.Hearts),
            new Card(CardFace.Six, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Spades),
            new Card(CardFace.Eight, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Clubs)
        });

        public static IHand straight = new Hand(new List<ICard>()
        {
            new Card(CardFace.Five, CardSuit.Hearts),
            new Card(CardFace.Six, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Spades),
            new Card(CardFace.Eight, CardSuit.Spades),
            new Card(CardFace.Nine, CardSuit.Clubs)
        });

        public static IHand flush = new Hand(new List<ICard>()
        {
            new Card(CardFace.Five, CardSuit.Diamonds),
            new Card(CardFace.Ace, CardSuit.Diamonds),
            new Card(CardFace.Seven, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Diamonds),
            new Card(CardFace.Nine, CardSuit.Diamonds)
        });

        public static IHand fullHouse = new Hand(new List<ICard>()
        {
            new Card(CardFace.Eight, CardSuit.Hearts),
            new Card(CardFace.Six, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Spades),
            new Card(CardFace.Eight, CardSuit.Diamonds),
            new Card(CardFace.Six, CardSuit.Clubs)
        });

        public static IHand fourOfAKind = new Hand(new List<ICard>()
        {
            new Card(CardFace.Eight, CardSuit.Hearts),
            new Card(CardFace.Six, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Spades),
            new Card(CardFace.Eight, CardSuit.Diamonds),
            new Card(CardFace.Eight, CardSuit.Clubs)
        });

        public static IHand straightFlush = new Hand(new List<ICard>()
        {
            new Card(CardFace.Five, CardSuit.Hearts),
            new Card(CardFace.Six, CardSuit.Hearts),
            new Card(CardFace.Seven, CardSuit.Hearts),
            new Card(CardFace.Eight, CardSuit.Hearts),
            new Card(CardFace.Nine, CardSuit.Hearts)
        });
    }
}
