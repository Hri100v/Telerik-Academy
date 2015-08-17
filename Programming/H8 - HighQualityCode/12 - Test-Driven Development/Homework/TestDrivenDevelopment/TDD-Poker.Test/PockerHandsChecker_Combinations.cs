using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace TDD_Poker.Test
{
    [TestClass]
    public class PockerHandsChecker_Combinations
    {
        [TestMethod]
        public void TestIsValidHandShouldReturnTrueWithValidHand()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Eight, CardSuit.Hearts), 
                new Card(CardFace.Jack, CardSuit.Spades), 
                new Card(CardFace.Seven, CardSuit.Clubs) 
            };
            var hand = new Hand(cards);
            checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestIsValidHandShouldThrowExceptionWhenNullHandIsPassed()
        {
            var checker = new PokerHandsChecker();
            IHand hand = null;
            checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsValidHandShouldThrowExceptionWhenHandContainsInsufficientCards()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> { new Card(CardFace.Ace, CardSuit.Diamonds) };
            var hand = new Hand(cards);

            checker.IsValidHand(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsValidHandShouldReturnFalseWithFiveCardsOfSameFace()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Ace, CardSuit.Spades), 
                new Card(CardFace.Ace, CardSuit.Clubs), 
                new Card(CardFace.Ace, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))]
        public void TestIsValidHandShouldReturnFalseWithTwoEqualCards()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.King, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            checker.IsValidHand(hand);
        }

        [TestMethod]
        public void TestIsHighCardShoudReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.King, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Three, CardSuit.Spades), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsHighCard(hand));
        }

        [TestMethod]
        public void TestIsHighCardShoudReturnFalseWhenNotMatchingHandPassed_OnePair()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.King, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Two, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsHighCard(hand));
        }

        [TestMethod]
        public void TestIsOnePairShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.King, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Two, CardSuit.Hearts), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestIsOnePairShouldReturnFalseWhenNotMatchingHandPassed_ThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            {
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Two, CardSuit.Hearts), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestIsTwoPairShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Ace, CardSuit.Hearts), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestIsTwoPairShouldReturnFalseWhenNotMatchingHandPassed_FullHouse()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Ace, CardSuit.Hearts), 
                new Card(CardFace.Two, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestIsTwoPairShouldReturnFalseWhenNotMatchingHandPassed_OnePair()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Ace, CardSuit.Spades), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.King, CardSuit.Hearts), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestIsThreeOfAKindShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Two, CardSuit.Hearts), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestIsThreeOfAKindShouldReturnFalseWhenNotMatchingHandPassed_FullHouse()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Spades), 
                new Card(CardFace.Two, CardSuit.Hearts), 
                new Card(CardFace.Ace, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestIsStraightShouldReturnTrue_AceToFive()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.Two, CardSuit.Diamonds), 
                new Card(CardFace.Three, CardSuit.Spades), 
                new Card(CardFace.Four, CardSuit.Hearts), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestIsStraightShouldReturnTrue_JackToAce()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Ace, CardSuit.Diamonds), 
                new Card(CardFace.King, CardSuit.Diamonds), 
                new Card(CardFace.Queen, CardSuit.Spades), 
                new Card(CardFace.Jack, CardSuit.Hearts), 
                new Card(CardFace.Ten, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestIsStraightShouldReturnTrue_FourToEight()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Six, CardSuit.Spades), 
                new Card(CardFace.Seven, CardSuit.Hearts), 
                new Card(CardFace.Eight, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestIsStraightShouldReturnFalseWhenNotMatchingHandPassed_StraightFlush()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Six, CardSuit.Diamonds), 
                new Card(CardFace.Seven, CardSuit.Diamonds), 
                new Card(CardFace.Eight, CardSuit.Diamonds) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestIsStraightShouldReturnFalseWhenNotMatchingHandPassed_OnePair()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Six, CardSuit.Spades), 
                new Card(CardFace.Seven, CardSuit.Hearts), 
                new Card(CardFace.Seven, CardSuit.Clubs) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestIsFlushShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Five, CardSuit.Clubs), 
                new Card(CardFace.Six, CardSuit.Clubs), 
                new Card(CardFace.Seven, CardSuit.Clubs), 
                new Card(CardFace.Ten, CardSuit.Clubs) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsFlushShouldReturnFalseWhenNotMatchingHandPassed_StraightFlush()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Six, CardSuit.Diamonds), 
                new Card(CardFace.Seven, CardSuit.Diamonds), 
                new Card(CardFace.Eight, CardSuit.Diamonds) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsFlushShouldReturnFalseWhenNotMatchingHandPassed()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Six, CardSuit.Diamonds), 
                new Card(CardFace.Queen, CardSuit.Clubs), 
                new Card(CardFace.Eight, CardSuit.Diamonds) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestIsFullHouseShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Four, CardSuit.Spades), 
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsFullHouse(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsFullHouseShouldThrowException_TwoOfTheSameCards()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Spades), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Four, CardSuit.Spades), 
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Five, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            checker.IsFullHouse(hand);
        }

        [TestMethod]
        public void TestIsFullHouseShouldReturnFalseWhenNotMatchingHandPassed_ThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Spades), 
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Four, CardSuit.Hearts), 
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Six, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestIsFourOfAKindShouldReturnTrue()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds), 
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Four, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsFourOfAKindShouldThrowException_FiveOfAKind()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Four, CardSuit.Hearts), 
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Four, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            checker.IsFullHouse(hand);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestIsValidHandShouldThrowException_FiveOfAKind()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            {
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Four, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            checker.IsValidHand(hand);
        }

        [TestMethod]
        public void TestIsFourOfAKindShouldReturnFalseWhenNotMatchingHandPassed_ThreeOfAKind()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Diamonds), 
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs), 
                new Card(CardFace.Six, CardSuit.Hearts)
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestIsFourOfAKindShouldReturnFalseWhenNotMatchingHandPassed_TwoPairs()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            { 
                new Card(CardFace.Queen, CardSuit.Spades), 
                new Card(CardFace.Queen, CardSuit.Diamonds), 
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs), 
                new Card(CardFace.Four, CardSuit.Hearts) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestIsStraightFlushShouldReturnTrue_AceToFive()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs), 
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs), 
                new Card(CardFace.Five, CardSuit.Clubs)
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestIsStraightFlushShouldReturnTrue_TenToAce()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            {
                new Card(CardFace.Ace, CardSuit.Clubs), 
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.King, CardSuit.Clubs), 
                new Card(CardFace.Jack, CardSuit.Clubs), 
                new Card(CardFace.Queen, CardSuit.Clubs) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestIsStraightFlushShouldReturnTrue_SevenToJack()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard>
            {
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs), 
                new Card(CardFace.Nine, CardSuit.Clubs), 
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.Jack, CardSuit.Clubs) 
            };
            var hand = new Hand(cards);

            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestIsStraightFlushShouldReturnFalseWhenNotMatchingHandPassed_Straight()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            {
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs), 
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Hearts), 
                new Card(CardFace.Jack, CardSuit.Clubs)
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestIsStraightFlushShouldReturnFalseWhenNotMatchingHandPassed_Flush()
        {
            var checker = new PokerHandsChecker();
            var cards = new List<ICard> 
            { 
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs), 
                new Card(CardFace.Nine, CardSuit.Clubs), 
                new Card(CardFace.Ten, CardSuit.Clubs), 
                new Card(CardFace.Jack, CardSuit.Clubs) 
            };
            var hand = new Hand(cards);

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }
    }
}
