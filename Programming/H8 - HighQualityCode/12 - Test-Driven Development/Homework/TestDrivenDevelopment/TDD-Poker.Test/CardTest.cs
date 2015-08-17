using System;
using Poker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD_Poker.Test
{
    [TestClass]
    public class CardTest
    {
        [TestMethod]
        public void TestCardShouldCompareCorrectly_EqualCards()
        {
            var cardA = new Card(CardFace.Jack, CardSuit.Clubs);
            var cardB = new Card(CardFace.Jack, CardSuit.Clubs);

            Assert.IsTrue(cardA.Equals(cardB));
        }

        [TestMethod]
        public void TestCardShouldCompareCorrectly_DifferentCards()
        {
            var cardA = new Card(CardFace.Jack, CardSuit.Clubs);
            var cardB = new Card(CardFace.Ace, CardSuit.Hearts);

            Assert.IsFalse(cardA.Equals(cardB));
        }

        [TestMethod]
        public void TestCardToString()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Hearts);
            string expected = "Ace of Hearts";

            Assert.AreEqual(expected, card.ToString());
        }
    }
}
