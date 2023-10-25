using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Player
    {
        private string playerName;
        private int playerId;
        private List<Hand> hands; //each player can have multiple hands.

        public Player(int playerId) {
            this.playerId = playerId;
        }


        public List<Hand> GetHands()
        {
            return hands;
        }

        public String toString()
        {
            return ("Player: " + playerName);
        }
    }
}
