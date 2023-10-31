using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Player
    {
        private Hand hand;

        private int playerId
        { get; }
        private Boolean isFinished
        { get; set; }
        private Boolean winner 
        { get; set; }

        public Player(int playerId) {
            this.playerId = playerId;
            this.isFinished = false;
            this.winner = false;

        }


        public void onPlayerAction(Player player, Enums.Actions action) {
            if (player == this)
            {
                if(action == Enums.Actions.hit)
                {
                    hand.
                }
            }
        }

        public Boolean addHand(int seatNbr)
        {
            this.hand = new Hand(seatNbr);
            return true;
        }

        public Hand getHand()
        {
            return hand;
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
