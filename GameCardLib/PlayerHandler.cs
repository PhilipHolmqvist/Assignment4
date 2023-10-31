using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;

namespace GameCardLib
{
    public class PlayerHandler
    {
        ListManager<Player> players = new ListManager<Player>();
        GameDeck gameDeck = new GameDeck(5);

        public PlayerHandler() { }


        //This method raises an event in the player object.
        public List<Card> playerHit(int playerId) 
        {
            List<Card> cards = null;

            if (getPlayer(playerId) != null)
            {
                Card card = gameDeck.drawCard();
                getPlayer(playerId).hit(card);

                cards = getPlayer(playerId).getHand().getCards();
            }

            return cards;
        }

        //This method raises an event in the player object.
        public Boolean playerStand(int playerId) 
        {
            Boolean playerHasStand = false;

            if(getPlayer(playerId) != null)
            {
                getPlayer(playerId).stand();
            }

            return playerHasStand;
        }


        public void addPlayer(Player player)
        {
            players.Add(player);
        }

        public void removePlayer(int playerId) {
        
        }

        //Helper methods
        public Player getPlayer(int playerId)
        {
           for(int i = 0; i < players.Count(); i++)
           {
                if(players.GetAt(i).getPlayerId() == playerId)
                {
                    return players.GetAt(i);
                }
           }
            return null;
        }
    }
}
