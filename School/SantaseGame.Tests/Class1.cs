using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
 
namespace SantaseGame.Tests
{
    [TestFixture]

    public class SantaseGameTests
    {
        [Test]
        public void TestCreatingNewDeck_ShouldGiveDeckWith24Cards()
        {
            Deck deck = new Deck();
            var numberOfCards = deck.CardsLeft;

            Assert.AreEqual(24, numberOfCards);
        }

        [Test]
        public void ApplyingGetNextCard_ShouldGiveDeckCountWithCorrectResult()
        {
            Deck deck = new Deck();

            deck.GetNextCard();

            var numberOfCards = deck.CardsLeft;

            Assert.AreEqual(23, numberOfCards);
        }

        [Test]
        [ExpectedException(typeof(InternalGameException))]
        public void CallingMethodGetNextCard24Times_ShouldThrowAnException()
        {
            Deck deck = new Deck();
            for (int i = 0; i < 24; i++)
            {
                deck.GetNextCard();
            }
        }

        [Test]
        public void ChangeTrumpCard_ShouldProperlyChangeTheTrumpCard()
        {
            Deck deck = new Deck();
            var card = new Card(CardSuit.Heart, CardType.Jack);
            deck.ChangeTrumpCard(card);

            Assert.AreEqual(card, deck.TrumpCard);
        }
    }
}
