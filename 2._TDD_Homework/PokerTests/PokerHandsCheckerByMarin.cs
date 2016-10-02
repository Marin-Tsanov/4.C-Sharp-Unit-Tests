using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using _2._TDD_Homework;

namespace PokerTests
{
    [TestFixture]
    public class PokerHandsCheckerByMarin
    {
        [Test]
        public void CreateHandWithLessThan5Cards_ShouldThrowAnExceptions()
        {
            List<ICard> cards = new List<ICard>
            { new Card(CardFace.Ace, CardSuit.Clubs),
              new Card(CardFace.King, CardSuit.Diamonds),
              new Card(CardFace.Queen, CardSuit.Hearts) };

            IHand hand = new Hand(cards);

            var checker = new PokerHandsChecker();
            Assert.Throws(typeof(NotImplementedException), () => checker.IsValidHand(hand));
        }

        [Test]
        public void CreateHandWithMoreThan5Cards_ShouldThrowAnException()
        {
            List<ICard> cards = new List<ICard>
            { new Card(CardFace.Ace, CardSuit.Clubs),
              new Card(CardFace.King, CardSuit.Diamonds),
              new Card(CardFace.Queen, CardSuit.Hearts),
              new Card(CardFace.Ace, CardSuit.Clubs),
              new Card(CardFace.King, CardSuit.Diamonds),
              new Card(CardFace.Queen, CardSuit.Hearts) };

            IHand hand = new Hand(cards);

            var checker = new PokerHandsChecker();
            Assert.Throws(typeof(NotImplementedException), () => checker.IsValidHand(hand));
        }

        [Test]
        public void CreateHandWith5CardsTwoOfThemAreEqual_ShouldReturnFalse()
        {
            List<ICard> cards = new List<ICard>
            { new Card(CardFace.Ace, CardSuit.Clubs),
              new Card(CardFace.King, CardSuit.Diamonds),
              new Card(CardFace.Queen, CardSuit.Hearts),
              new Card(CardFace.Ace, CardSuit.Clubs),
              new Card(CardFace.Jack, CardSuit.Diamonds) };

            IHand hand = new Hand(cards);

            var checker = new PokerHandsChecker();
            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [Test]
        public void CreateHandWith5CardsNonOfThemAreEqual_ShouldReturnTrue()
        {
            List<ICard> cards = new List<ICard>
            { new Card(CardFace.Ace, CardSuit.Clubs),
              new Card(CardFace.King, CardSuit.Diamonds),
              new Card(CardFace.Queen, CardSuit.Hearts),
              new Card(CardFace.Ten, CardSuit.Clubs),
              new Card(CardFace.Jack, CardSuit.Diamonds) };

            IHand hand = new Hand(cards);

            var checker = new PokerHandsChecker();
            Assert.IsTrue(checker.IsValidHand(hand));
        }
    }
}
