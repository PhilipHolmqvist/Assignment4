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


        public Player nextPlayer()
        {
            List<Player> list = players.toList(); 
            list = list.OrderByDescending(i => i.playerId).ToList(); //Make sure the list is sorted before checking.

            foreach (Player player in list) {
                if(player.isFinished == false)
                {
                    return player;
                }
            }
            return null;
        }

        //This method raises an event in the player object.
        public Hand playerHit(int playerId) 
        {
            Hand hand = null;

            if (getPlayer(playerId) != null)
            {
                Card card = gameDeck.drawCard();
                getPlayer(playerId).hit(card);

                hand = getPlayer(playerId).getHand();
            }

            return hand;
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

        public void addPlayer(string playerName, int playerId)
        {
            players.Add(new Player(playerName, playerId));
        }

        public void removePlayer(int playerId) {
        
        }

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

        public List<int> newRoundStart() //A new round is started. View needs to know which seats are playing.
        {
            List<int> playingSeats = new List <int>();

            foreach(Player player in players) //Return each players id. 
            {
                playingSeats.Add(player.playerId);
            }

            return playingSeats.OrderByDescending(id => id).ToList();
        }

        public Card getCardForDealer()
        {
            return gameDeck.drawCard();
        }
    }
}
