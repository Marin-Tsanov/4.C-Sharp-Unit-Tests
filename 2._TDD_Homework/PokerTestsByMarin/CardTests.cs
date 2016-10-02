namespace PokerTestsByMarin
{
    using NUnit.Framework;
    using _2._TDD_Homework;

    [TestFixture]
    public class CardTests
    {
        [Test]
        [TestCase(CardFace.Ace, CardSuit.Clubs)]
        [TestCase(CardFace.King, CardSuit.Diamonds)]
        [TestCase(CardFace.Queen, CardSuit.Clubs)]

        public void CreatingNewCard_ShouldReturnCorrectData(CardFace face, CardSuit suit)
        {
            Card card = new Card(face, suit);
            string result = card.ToString();
            Assert.AreEqual(string.Format("{0} {1}", card.Face, card.Suit), result);

        }
    }
}
