using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace BJGameEL
{
    public class Hand
    {
        [Key]
        public int id { get; set; } //This is the ID for identifying the hand in the database.

        [NotMapped]
        public List<Card> cards { get; set; } //We dont want to save the cards to the database.
        public int score { get; set; }
        public Boolean isBust { get; set; }

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

        public int nbrOfCards()
        {
            return cards.Count;
        }

        public Boolean addCard(Card card)
        {
            cards.Add(card);
            this.score += card.getCardIntValue();
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
            int score = 0;

            foreach(Card card in cards)
            {
                score += card.getCardIntValue();
            }

            return score;
        }
    }
}
