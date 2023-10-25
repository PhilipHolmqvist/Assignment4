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
            players.Add(new Player())
        }

        public ListManager<Player> GetPlayers()
        {
            return players;
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

        public Boolean playerWantsSeat(int playerNbr, int seatNbr)
        {
            Boolean result = false;

            List<Hand> playerHands = getAllPlayersHands();
            foreach(Hand hand in playerHands)
            {
                if(hand.getSeatNbr() == seatNbr)
                {
                    return result = false;
                }
            }
            

            
            return result;
        }

        
    }
}
