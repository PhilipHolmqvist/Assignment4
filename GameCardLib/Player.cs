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
        public event EventHandler<PlayerEvent> playerHit;
        public event EventHandler<PlayerEvent> playerStand;

        public int playerId
        { get; }
        public Boolean isFinished
        { get; set; }
        private Boolean winner 
        { get; set; }
        private string playerName
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
            if(hand.getCurrentHandValue() > 21 )
            {
                this.isFinished = true;
            }
            PlayerEvent action = new PlayerEvent(true);
            OnPlayerHit(action);
        }

        //Player wants to stand. 
        public void stand()
        {
            PlayerEvent action = new PlayerEvent(false);
            OnPlayerStand(action);
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
