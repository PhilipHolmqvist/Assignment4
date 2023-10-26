using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{

    //This class contains a full set of cards and has methods to allow manipulation of the deck.
    public class Deck 
    {

        private ListManager<Card> cardManager;

        //When the deck is instasiated it creates a new card manager and shuffles the deck into a random order.
        public Deck() { 
            cardManager = new ListManager<Card>();
            initializeDeck();
            shuffleDeck();
        }

        //This method adds all of the cards to the deck.
        private void initializeDeck()
        {
            //Clubs cards
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.ace));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.two));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.three));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.four));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.five));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.six));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.seven));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.eight));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.nine));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.ten));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.jack));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.queen));
            cardManager.Add(new Card(Enums.Suits.clubs, Enums.Values.king));

            //Spades cards
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.ace));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.two));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.three));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.four));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.five));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.six));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.seven));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.eight));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.nine));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.ten));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.jack));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.queen));
            cardManager.Add(new Card(Enums.Suits.spades, Enums.Values.king));

            //Heart cards
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.ace));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.two));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.three));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.four));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.five));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.six));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.seven));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.eight));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.nine));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.ten));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.jack));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.queen));
            cardManager.Add(new Card(Enums.Suits.hearts, Enums.Values.king));

            //Diamonds cards
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.ace));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.two));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.three));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.four));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.five));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.six));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.seven));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.eight));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.nine));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.ten));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.jack));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.queen));
            cardManager.Add(new Card(Enums.Suits.diamonds, Enums.Values.king));
        }

        //This method shuffles the whole card deck and places it into a new order.
        private Boolean shuffleDeck()
        {
            return cardManager.shuffleItemsInList();
        }

        //Gets the card and removes it from the deck.
        public Card getCard()
        {
            Card card = cardManager.GetAt(0);
            cardManager.DeleteAt(0);
            return card;
        }

        //Gets card at an index and removes it from the deck.
        public Card getCardAt(int index)
        {
            Card card = cardManager.GetAt(index);
            cardManager.DeleteAt(index);
            return card;
        }

        //Deletes the card in the first postion.
        public Boolean removeCard()
        {
            return cardManager.DeleteAt(0);
        }

        //Deletes the card at a certain postion.
        public Boolean removeCardAtPos(int index)
        {
            return cardManager.DeleteAt(index);
        }

        //Returns the number of cards left in the deck.
        public int nbrOfCardsLeft()
        {
            return cardManager.Count();
        }

        //Returns two cards from the deck. The method also removes the card at the positions.
        public List<Card> getTwoCards()
        {
            List<Card> cards = new List<Card>();
            cards.Add(getCard());
            cards.Add(getCard());
            return cards;
        }
    }
}
