using System;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            if (cards == null)
                throw new ArgumentNullException("List of cards cannot be null");

            foreach (var card in cards)
                if (card == null)
                    throw new ArgumentNullException("Card cannot be null");

            this.Cards = cards;
        }

        public enum Type
        {
            HighCard = 0,
            OnePair = 1,
            TwoPair = 2,
            ThreeOfAKind = 3,
            Straight = 4,
            Flush = 5,
            FullHouse = 6,
            FourOfAKind = 7,
            StraightFlush = 8
        }

        public override string ToString()
        {
            return String.Join(" | ", this.Cards);
        }
    }
}
