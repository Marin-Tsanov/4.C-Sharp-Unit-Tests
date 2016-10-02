using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._TDD_Homework
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool result = true;

            if (hand.Cards.Count < 5)
            {
                throw new NotImplementedException
                    ("Hand is not valid, it must have 5 cards in it");
            }
            else if (hand.Cards.Count > 5)
            {
                throw new NotImplementedException
                    ("Hand is not valid, it must have 5 cards in it");
            }
            else if (hand.Cards.Count == 5)
            {
                for (int i = 0, j = 1; i <= 3; i++, j++)
                {
                    while (j <= 4)
                    {
                        if (hand.Cards[i].Face == hand.Cards[j].Face &&
                            hand.Cards[i].Suit == hand.Cards[j].Suit
                            /*object.Equals(hand.Cards[i], hand.Cards[j]) == true*/)
                        {
                            result = false;
                            break;
                        }
                        j++;
                    }
                }
            }
            return result;
        }


        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }





















        //private int ValidHandCount = 5;

        //public bool IsValidHand(IHand hand)
        //{
        //    if (hand.Cards.Count != ValidHandCount)
        //    {
        //        return false;
        //    }

        //    for (int i = 0; i < ValidHandCount - 1; i++)
        //    {
        //        for (int j = i + 1; j < ValidHandCount; j++)
        //        {
        //            if (hand.Cards[i].Face == hand.Cards[j].Face &&
        //                    hand.Cards[i].Suit == hand.Cards[j].Suit)
        //            {
        //                return false;
        //            }
        //        }
        //    }

        //    return true;
        //}

        //public bool IsStraightFlush(IHand hand)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsFourOfAKind(IHand hand)
        //{
        //    var counter = new int[14];

        //    foreach (var card in hand.Cards)
        //    {
        //        counter[(int)card.Face]++;
        //    }

        //    if (Array.IndexOf(counter, 4) != -1)
        //    {
        //        return true;
        //    }

        //    return false;

        //}

        //public bool IsFullHouse(IHand hand)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsFlush(IHand hand)
        //{
        //    var firstCard = hand.Cards[0];

        //    foreach (var card in hand.Cards)
        //    {
        //        if (card.Suit != firstCard.Suit)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        //public bool IsStraight(IHand hand)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsThreeOfAKind(IHand hand)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsTwoPair(IHand hand)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsOnePair(IHand hand)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsHighCard(IHand hand)
        //{
        //    throw new NotImplementedException();
        //}

        //public int CompareHands(IHand firstHand, IHand secondHand)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
