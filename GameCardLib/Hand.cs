using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace GameCardLib
{
    public class Hand
    {
        private int seatNbr;
        private List<Card> cards;
        private int score;

        public Hand()
        {
            this.cards = new List<Card>();
            this.score = 0;
        }

        public int getCurrentHandValue()
        {
            int result = 0;

            foreach(Card card in cards)
            {
                result += card.getValue();
            }

            return result;
        }

        public int nbrOfCards()
        {
            return cards.Count;
        }

        public Boolean addCard(Card card)
        {
            cards.Add(card);
            return true;
        }

        public Boolean clearHand()
        {
            this.cards.Clear();
            this.score = 0;
            return true;
        }


        public int getSeatNbr() {
            return seatNbr;
        }

        public Boolean setSeatNbr(int seatNbr)
        {
            this.seatNbr = seatNbr;
            return true;
        }

    }
}
