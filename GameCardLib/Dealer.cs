using System;
using System.Collections.Generic;
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

            Player p = getPlayer(playerNbr);
            p.addHand(seatNbr);
            return true;
        }

        
    }
}
