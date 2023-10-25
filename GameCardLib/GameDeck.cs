using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{

    //The gamedeck class contains a set amount of card decks.
    public class GameDeck
    {
        private int nbrOfCardDecks;
        private ListManager<Deck> deckManager;
        private Random rng = new Random();

        public GameDeck(int nbrOfCardDecks ) {

            this.nbrOfCardDecks = nbrOfCardDecks;
            deckManager = new ListManager<Deck>();

            for(int i = 0; i <  nbrOfCardDecks; i++)
            {
                deckManager.Add(new Deck() { });
            }

        }

        //Shuffles all the decks in the game deck.
        public Boolean shuffleGameDeck()
        {
            for(int i = 0; i < nbrOfCardDecks; i++)
            {
                deckManager.shuffleItemsInList();
            }

            return true;
        }

        //Draws a card from a random deck and returns it. 
        public Card drawCard()
        {
            int deckIndex = rng.Next(0, (nbrOfCardDecks-1));
            return deckManager.GetAt(deckIndex).getCard();
        }

        //Draws two cards from a random deck and returns it.
        public List<Card> drawTwoCards()
        {
            int deckIndex = rng.Next(0, (nbrOfCardDecks - 1));
            return deckManager.GetAt(deckIndex).getTwoCards();
        }

        //Returns how many cards are left in the game deck.
        public int cardsLeft() {
            int nbrCards = 0;

            //Count the cards left in each deck.
            for(int i = 0; i < deckManager.Count(); i++)
            {
                nbrCards += deckManager.GetAt(i).nbrOfCardsLeft();
            }

            return nbrCards;
        }
    }
}
