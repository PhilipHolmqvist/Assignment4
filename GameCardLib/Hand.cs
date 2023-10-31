﻿using System;
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

        public Hand(int seatNbr)
        {
            this.seatNbr = seatNbr;
            this.cards = new List<Card>();
            this.score = 0;
        }

        public List<Card> getCards()
        {
            return cards;
        }

        public int getCurrentHandValue()
        {
            int result = 0;

            foreach(Card card in cards)
            {
                result += card.getCardIntValue();
            }

            return result;
        }

        public int nbrOfCards()
        {
            return cards.Count;
        }

        public void handHit()
        {

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

        public int getScore()
        {
            return score;
        }
    }
}
