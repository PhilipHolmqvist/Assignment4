using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class Dealer
    {
        private readonly int nbrOfCardDecks = 5;
        private GameDeck gameDeck;
        private ListManager<Player> players;

        public Dealer()
        {
            this.players = new ListManager<Player>();
            instansiatePlayers();
            this.gameDeck = new GameDeck(nbrOfCardDecks);
        }

        private void instansiatePlayers()
        {
            players.Add(new Player(0)); //<-- This player is the dealer. 
            Player dealer = new Player(0);
            dealer.addHand(0);
            players.Add(dealer);

            players.Add(new Player(1));
            players.Add(new Player(2));
            players.Add(new Player(3));
            players.Add(new Player(4));
        }

        public ListManager<Player> GetPlayers()
        {
            return players;
        }

        private Player getPlayer(int playerNbr)
        {
            foreach (Player p in players)
            {
                if(playerNbr == p.getPlayerId())
                {
                    return p;
                }
            }

            return null;
        }

        private List<Hand> getAllPlayersHands()
        {
            List<Hand> hands = new List<Hand>();

            for (int i = 0; i < players.Count(); i++)
            {
                Player p = players.GetAt(i);
                List<Hand> playerHands = p.GetHands();
                foreach (Hand hand in playerHands)
                {
                    hands.Add(hand);
                }
            }
            return hands;
        }

        //Assigns a player to a seat if its empty.
        public Boolean playerWantsSeat(int playerNbr, int seatNbr)
        {
        
            List<Hand> playerHands = getAllPlayersHands();
            foreach(Hand hand in playerHands)
            {
                if(hand.getSeatNbr() == seatNbr)
                {
                    return false;
                }
            }

            getPlayer(playerNbr).addHand(seatNbr);
            return true;
        }

        public void playerHit(int seatNbr)
        {
            throw new NotImplementedException();
        }

        public void playerStand(int seatNbr)
        {
            throw new NotImplementedException();
        }

        private void clearAllHands() //This includes the dealer hand.
        {

            List<Hand> hands = getAllPlayersHands();
            foreach (Hand hand in hands)
            {
                hand.clearHand();
            }
        }

        public List<Hand> startNewRound()
        {
            clearAllHands();
            clearScores();
            return giveEachHandTwoCards();
        }

        private void clearScores()
        {

        }

        private List<Hand> giveEachHandTwoCards()
        {
            //Give all players and the dealer one card each. 
            List<Hand> hands = getAllPlayersHands();
            for(int i = 0; i < 2; i++) //Do the inside loop twice.
            {
                for (int j = hands.Count - 1; j >= 0; j--) //We are iterating from right to left.
                {
                    Card card = gameDeck.drawCard();
                    hands[i].addCard(card);
                }
            }

            return hands;
        }
    }
}
