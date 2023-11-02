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
        private List<Card> cards;
        private int score;
        private Boolean isBust;

        public Hand()
        {
            this.cards = new List<Card>();
            this.score = 0;
            this.isBust = false;
        }

        public List<Card> getCards()
        {
            return cards;
        }

        public void setHandBust(Boolean isBust)
        {
            this.isBust = isBust;
        }

        public Boolean getHandBust()
        {
            return isBust;
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

        public int getScore()
        {
            return score;
        }
    }
}
