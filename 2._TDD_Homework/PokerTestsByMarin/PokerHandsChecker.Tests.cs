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
    public class PokerHandsChecker
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
			
        }
    }
}
