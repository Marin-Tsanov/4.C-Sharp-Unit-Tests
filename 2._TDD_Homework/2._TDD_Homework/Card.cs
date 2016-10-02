using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._TDD_Homework
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string face;
            switch ((int)this.Face)
            {
                case 2:  face = "Two"; break;
                case 3:  face = "Three"; break;
                case 4:  face = "Four"; break;
                case 5:  face = "Five"; break;
                case 6:  face = "Six"; break;
                case 7:  face = "Seven"; break;
                case 8:  face = "Eight"; break;
                case 9:  face = "Nine"; break;
                case 10: face = "Ten"; break;
                case 11: face = "Jack"; break;
                case 12: face = "Queen"; break;
                case 13: face = "King"; break;
                case 14: face = "Ace"; break;
                default: throw new NotImplementedException("Card face does not match possible values");
            }

            string suit;
            switch ((int)this.Suit)
            {
                case 1: suit = "Clubs"; break;
                case 2: suit = "Diamonds"; break;
                case 3: suit = "Hearts"; break;
                case 4: suit = "Spades"; break;
                default: throw new NotImplementedException("Card suit does not match possible values");
            }
            return face + " " + suit;
        }









        //public override string ToString()
        //{
        //    string face;
        //    switch ((int)this.Face)
        //    {
        //        case 2:
        //        case 3:
        //        case 4:
        //        case 5:
        //        case 6:
        //        case 7:
        //        case 8:
        //        case 9:
        //        case 10:
        //            face = ((int)this.Face).ToString();
        //            break;
        //        case 11:
        //            face = "J";
        //            break;
        //        case 12:
        //            face = "Q";
        //            break;
        //        case 13:
        //            face = "K";
        //            break;
        //        case 14:
        //            face = "A";
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException("Are you sure you are using right cards ?!?");
        //    }

        //    char suit;
        //    switch ((int)this.Suit)
        //    {
        //        case 1:
        //            suit = (char)9827;
        //            break;
        //        case 2:
        //            suit = (char)9830;
        //            break;
        //        case 3:
        //            suit = (char)9829;
        //            break;
        //        case 4:
        //            suit = (char)9824;
        //            break;
        //        default:
        //            throw new ArgumentOutOfRangeException("Are you sure you are using right cards ?!?");
        //    }

        //    return face + suit;
        //}
    }
}