using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace TDD_Poker.Test
{
    [TestClass]
    public class HandTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestHandTrowsExceptionWhenListOfCardsIsNull()
        {
            IList<ICard> cards = null;
            Hand Hand = new Hand(cards);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestHandTrowsExceptionWhenListOfCardsContainsNull()
        {
            IList<ICard> cards = new List<ICard>() { new Card(CardFace.Jack, CardSuit.Clubs), null };
            Hand Hand = new Hand(cards);
        }

        [TestMethod]
        public void TestHandToString()
        {
            IList<ICard> cards = new List<ICard> { new Card(CardFace.Ace, CardSuit.Hearts), new Card(CardFace.Queen, CardSuit.Diamonds) };
            Hand hand = new Hand(cards);
            string expected = "Ace of Hearts | Queen of Diamonds";

            Assert.AreEqual(expected, hand.ToString());
        }
    }
}
