using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._TDD_Homework
{
    /// <summary>
    /// Interface for checking poker hands as defined in http://en.wikipedia.org/wiki/List_of_poker_hands.
    /// </summary>
    public interface IPokerHandsChecker
    {
        bool IsValidHand(IHand hand);
        bool IsStraightFlush(IHand hand);
        bool IsFourOfAKind(IHand hand);
        bool IsFullHouse(IHand hand);
        bool IsFlush(IHand hand);
        bool IsStraight(IHand hand);
        bool IsThreeOfAKind(IHand hand);
        bool IsTwoPair(IHand hand);
        bool IsOnePair(IHand hand);
        bool IsHighCard(IHand hand);
        int CompareHands(IHand firstHand, IHand secondHand);
    }
}
