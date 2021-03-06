﻿using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return String.Format("{0} of {1}", this.Face, this.Suit);
        }

        public override bool Equals(object otherCard)
        {
            var card = otherCard as Card;
            if (card == null)
                return false;

            return this.Face == card.Face && this.Suit == card.Suit;
        }

        public override int GetHashCode()
        {
            return this.Face.GetHashCode() ^ this.Suit.GetHashCode();
        }
    }
}
