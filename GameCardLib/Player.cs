using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Player
    {
        
        private int playerId;
        private List<Hand> hands; //each player can have multiple hands.

        public Player(int playerId) {
            this.playerId = playerId;
            this.hands = new List<Hand>();
        }

        public Boolean addHand(int seatNbr)
        {
            hands.Add(new Hand(seatNbr));
            return true;
        }

        public List<Hand> GetHands()
        {
            return hands;
        }

        public int getPlayerId()
        {
            return playerId;
        }

        public String toString()
        {
            return ("Player: " + playerId);
        }
    }
}
