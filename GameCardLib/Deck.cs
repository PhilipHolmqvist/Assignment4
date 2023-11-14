
using BJGameEL;
using UtilitiesLib;

namespace BJGameBBL
{

    //This class contains a full set of cards and has methods to allow manipulation of the deck.
    public class Deck 
    {

        private ListManager<Card> cardList;

        //When the deck is instasiated it creates a new card manager and shuffles the deck into a random order.
        public Deck() { 
            cardList = new ListManager<Card>();
            initializeDeck();
            shuffleDeck();
        }

        //This method adds all of the cards to the deck.
        private void initializeDeck()
        {
            //Clubs cards
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.ace));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.two));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.three));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.four));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.five));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.six));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.seven));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.eight));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.nine));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.ten));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.jack));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.queen));
            cardList.Add(new Card(Enums.Suits.clubs, Enums.Values.king));

            //Spades cards
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.ace));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.two));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.three));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.four));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.five));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.six));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.seven));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.eight));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.nine));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.ten));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.jack));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.queen));
            cardList.Add(new Card(Enums.Suits.spades, Enums.Values.king));

            //Heart cards
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.ace));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.two));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.three));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.four));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.five));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.six));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.seven));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.eight));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.nine));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.ten));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.jack));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.queen));
            cardList.Add(new Card(Enums.Suits.hearts, Enums.Values.king));

            //Diamonds cards
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.ace));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.two));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.three));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.four));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.five));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.six));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.seven));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.eight));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.nine));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.ten));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.jack));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.queen));
            cardList.Add(new Card(Enums.Suits.diamonds, Enums.Values.king));
        }

        //This method shuffles the whole card deck and places it into a new order.
        public Boolean shuffleDeck()
        {
            return cardList.shuffleItemsInList();
        }

        //Gets the card and removes it from the deck.
        public Card getCard()
        {
            Card card = cardList.GetAt(0);
            cardList.DeleteAt(0);
            return card;
        }

        //Gets card at an index and removes it from the deck.
        public Card getCardAt(int index)
        {
            Card card = cardList.GetAt(index);
            cardList.DeleteAt(index);
            return card;
        }

        //Deletes the card in the first postion.
        public Boolean removeCard()
        {
            return cardList.DeleteAt(0);
        }

        //Deletes the card at a certain postion.
        public Boolean removeCardAtPos(int index)
        {
            return cardList.DeleteAt(index);
        }

        //Returns the number of cards left in the deck.
        public int nbrOfCardsLeft()
        {
            return cardList.Count();
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
