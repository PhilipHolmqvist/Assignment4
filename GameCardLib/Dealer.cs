using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;


namespace GameCardLib
{

    //This class is the subscriber. 
    public class Dealer
    {
        public Boolean roundStart;
        public Boolean roundEnd;
        private int dealerScore;
        private List<Card> dealerCards;
        private int publishers;

        public Dealer()
        {
            this.dealerCards = new List<Card>();
            this.roundStart = false;
            this.roundEnd = true;
        }


        public List<Card> newRoundStart(Card card)
        {
            roundStart = true;
            roundEnd = false;
            dealerCards.Add(card);
            return dealerCards;
        }


        public void subscribeToPlayer(Player player)
        {
            player.playerHit += OnPlayerHit;
            player.playerStand += OnPlayerStand;
            publishers++;
        }

        private void OnPlayerHit(object? sender, PlayerEvent e) {
        
        }

        private void dealerPlay()
        {

        }

        private void OnPlayerStand(object? sender, PlayerEvent e)
        {
            if(sender != null)
            {
                //Unsubscribe to player
                Player player = sender as Player;
                player.playerHit -= OnPlayerHit;
                player.playerStand -= OnPlayerStand;
                publishers--;

                //Check if all players are stadning..
                if (publishers == 0)
                {
                    dealerPlay();
                }
            }
           
        }



    }
}
