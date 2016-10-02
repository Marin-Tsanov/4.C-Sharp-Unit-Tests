using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using _2._TDD_Homework;

namespace PokerTestsByMarin
{
    [TestFixture]
   public class HandTests
    {
        [Test]
        //[TestCase(IList < ICard > cards = new List<ICard>
        //    { new Card(CardFace.Ace, CardSuit.Clubs),
        //      new Card(CardFace.King, CardSuit.Diamonds),
        //      new Card(CardFace.Queen, CardSuit.Hearts) };)]
        public void CreatingCardHand_ShouldGiveCorrectDataAboutTheCards(/*IList<ICard> cards*/)
        {
            List<ICard> cards = new List<ICard>
            { new Card(CardFace.Ace, CardSuit.Clubs),
              new Card(CardFace.King, CardSuit.Diamonds),
              new Card(CardFace.Queen, CardSuit.Hearts) };

            IHand hand = new Hand(cards);
            string result = hand.ToString();

            Assert.AreEqual(string.Format("{0} {1} {2} {3} {4} {5} ", 
                cards[0].Face, cards[0].Suit,
                cards[1].Face, cards[1].Suit, 
                cards[2].Face, cards[2].Suit ), 
                result);
        } 

        [Test]
        public void CreatingCardHandWithNoCardsInIt_ShouldThrowAnException()
        {
            List<ICard> cards = new List<ICard>();
            Hand hand = new Hand(cards);
            
            Assert.Throws(typeof(NotImplementedException), () => hand.ToString());
        }
    }
}
