using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._TDD_Homework
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            //throw new NotImplementedException();
            var builder = new StringBuilder();

            foreach (var card in this.Cards)
            {
                builder.Append(card.ToString() + " ");
            }

            if (builder.ToString() == "")
            {
                throw new NotImplementedException("Hand is empty");
            }

            return builder.ToString();
        }


















        //public override string ToString()
        //{
        //    string result = string.Empty;

        //    foreach (var card in this.Cards)
        //    {
        //        result += card.ToString() + " ";
        //    }

        //    return result.Trim();
        //}
    }
}
