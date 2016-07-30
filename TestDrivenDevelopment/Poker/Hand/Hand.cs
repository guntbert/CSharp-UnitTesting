namespace Poker
{
    using System.Collections.Generic;
    using System.Text;

    public class Hand : IHand
    {
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            if (this.Cards.Count > 0)
            {
                int cardPosition = 1;
                builder.AppendLine("Your hand contains: ");
                foreach (ICard card in this.Cards)
                {
                    builder.AppendLine(cardPosition + " " + card.ToString());
                    cardPosition++;
                }

                return builder.ToString();
            }
            else
            {
                return "Your hand is empty.";
            }
        }
    }
}
