using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJGameEL
{
    public class Player
    {
        public Hand hand;
        public event EventHandler<PlayerEvent> playerHit;
        public event EventHandler<PlayerEvent> playerStand;
        public event EventHandler<PlayerEvent> playerBust;

        [Key]
        public int id //This is the id that is used to uniquely identify a user in the database. 
        { get; set; }
        public int playerId //This is the in game id that is used during the game to keep track of which seat the player is using.
        { get; set;  }
        public Boolean isFinished
        { get; set; }

        [Required]
        public Boolean winner 
        { get; set; }

        public string playerName
        { get; set; }

        public Player()
        {
            // db needs this constructor even though it is never called by 
            // my code in the application. DB needs it to set up the contexts

            // Failure to have it will result in a 
            //  No suitable constructor found for entity type 'Company'. exception
        }

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
