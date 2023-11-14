using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Player
    {
        public Hand hand;
        public event EventHandler<PlayerEvent> playerHit;
        public event EventHandler<PlayerEvent> playerStand;
        public event EventHandler<PlayerEvent> playerBust;

        public int playerId
        { get; set;  }
        public Boolean isFinished
        { get; set; }
        public Boolean winner 
        { get; set; }
        public string playerName
        { get; set; }

        public Player(string playername, int playerId) {
            this.playerId = playerId;
            this.isFinished = false;
            this.winner = false;
            this.playerName = playername;
            this.hand = new Hand();

        }

        public void hit(Card card) //Player wants to hit. 
        {
            hand.addCard(card);
            PlayerEvent action = new PlayerEvent(true, false);
            OnPlayerHit(action);
        }

        //Player wants to stand. 
        public void stand()
        {
            this.isFinished = true;
            PlayerEvent action = new PlayerEvent(false, false);
            OnPlayerStand(action);
        }

        public void bust()
        {
            this.isFinished = true;
            PlayerEvent action = new PlayerEvent(false, true);
            OnPlayerBust(action);
        }

        private void OnPlayerBust(PlayerEvent e)
        {
            if(playerBust != null)
            {
                playerBust(this, e);
            }
        }

        //Raise event
        private void OnPlayerStand(PlayerEvent e)
        {
            if (playerStand != null)
            {
                playerStand(this, e);
            }
        }

        //Raise event
        private void OnPlayerHit(PlayerEvent e)
        {
            if (playerHit != null)
            {
                playerHit(this, e);
            }
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
