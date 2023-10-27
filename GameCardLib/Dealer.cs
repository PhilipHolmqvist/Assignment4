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
        private int playerTurnIndex;

        public Dealer()
        {
            this.playerTurnIndex = 7;
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

        private Hand getHand(int seatNbr)
        {
            foreach(Hand hand in getAllPlayersHands())
            { 
                if(hand.getSeatNbr() == seatNbr)
                {
                    return hand;
                }
            }
            return null;
        }

        public List<Hand> playerHit(int seatNbr)
        {
            if (seatNbr != 0) //Ignore if its the dealer.
            {
                Hand playerHand = getHand(seatNbr);
                Card card = gameDeck.drawCard();
                playerHand.addCard(card);
                return getAllPlayersHands();
            }
            return null;
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
                    hands[j].addCard(card);
                }
            }

            return hands;
        }

        private Boolean checkIfDealersTurn()
        {
            return false;
        }

        public int playerTurn()
        {

            switch (playerTurnIndex)
            {
                case 0:
                    if (checkIfDealersTurn())
                    {
                        dealersTurn();
                    }
                    else
                    {
                        return 7;
                    }
                    break;

                case 1:
                    playerTurnIndex -= 1;
                    return 1;
                    break;
                case 2:
                    playerTurnIndex -= 1;
                    return 2;
                    break;
                case 3:
                    playerTurnIndex -= 1;
                    return 3;
                    break;
                case 4:
                    playerTurnIndex -= 1;
                    return 4;
                    break;
                case 5:
                    playerTurnIndex -= 1;
                    return 5;
                    break;
                case 6:
                    playerTurnIndex -= 1;
                    return 6;
                    break;
                case 7:
                    playerTurnIndex -= 1;
                    return 7;
                    break;

            }

            if (playerTurnIndex == 0)
            {
                playerTurnIndex = 7;
                return 0;
            }else if(playerTurnIndex == 7)
            {
                playerTurnIndex -= 1;
                return 7;
            }

            return playerTurnIndex;

            
        }

        private void dealersTurn()
        {
            throw new NotImplementedException();
        }

      
    }
}
