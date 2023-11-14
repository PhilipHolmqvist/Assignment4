using BJGameEL;
using Microsoft.Extensions.Options;
using BJGameDAL;
using UtilitiesLib;

namespace BJGameBBL
{
    public class GameHandler
    {
        private ListManager<Player> players = new ListManager<Player>();
        private GameDeck gameDeck = new GameDeck(5);
        private Player dealer = new Player("Dealer", 0);
        private Boolean roundStart = false;
        private Boolean roundEnd = true;
        private int publishers;

        public GameHandler() {
            int publishers = 0;
        }


        //Saving to db
        public void savePlayersToDatabase()
        {
            using DbConnection context = new DbConnection();
          
            int count = players.Count();

            for(int i = 0; i < count; i++)
            {
                Player p = players.GetAt(i);
                context.Players.Add(p);
            }
            context.SaveChanges();
        }

        //Getting from DB
        public List<String> getPlayerHistory()
        {
            List<String> history = new List<String>();

            using DbConnection context = new DbConnection();

            var players = (from player in context.Players
                           select new
                           {
                               Name = player.playerName,
                               Score = player.hand.score,
                               Winner = player.winner
                           }).ToList();

            foreach (var player in players)
            {
                history.Add("Name: " + player.Name + " score: " + player.Score + " winner: " + player.Winner);
            }

            return null;
        }


        public ListManager<Player> startRound()
        {
            this.roundStart = true;
            this.roundEnd = false;
            players.Add(dealer);
           

            foreach(Player player in players)
            {
                if(player.getPlayerId() != 0)
                {
                    int id = player.getPlayerId();
                    playerHit(id);
                    playerHit(id);
                }
                else
                {
                    playerHit(0); //Dealer hits once.
                }

                
            }

            return players;
        }

        public List<Player> whoIsWinner()
        {
            List<Player> winners = new List<Player> ();
            foreach(Player player in players)
            {
                if(player.playerId != 0)
                {
                    int score = player.getHand().getCurrentHandValue();
                    if (score >= dealer.getHand().getCurrentHandValue() && score <= 21 ||  dealer.getHand().getCurrentHandValue() > 21 && score <= 21)
                    {
                        player.winner = true;
                        winners.Add(player);
                    }
                }
                
            }

            return winners;
        }

        public Player dealerPlay()
        {

            while (dealer.getHand().getCurrentHandValue() <= 16)
            {
                playerHit(0);
            }
            roundEnd = true;
            
            return dealer;
        }

        //Returns the next player that has to make a move. If empty, no players left.
        public int whoIsNextPlayer()
        {
            List<Player> sortedPlayers = new List<Player> ();
            foreach (Player player in players) { 
                if(player.isFinished == false)
                {
                    sortedPlayers.Add(player);
                }
               
            }

            sortedPlayers.OrderByDescending(p => p.playerId).ToList();

            if (sortedPlayers.Count == 0)
            {
                return 0;
            }

            return sortedPlayers.First().playerId;
        }


        //This method raises an event in the player object and is called by the GUI.
        public Hand playerHit(int playerId) 
        {
            Hand hand = null;

            if (getPlayer(playerId) != null)
            {
                Card card = gameDeck.drawCard();
                getPlayer(playerId).hit(card);
                isPlayerBust(playerId);

                hand = getPlayer(playerId).getHand();
            }

            return hand;
        }

        //This method checks if the player is bust. If he is, raise an event.
        private void isPlayerBust(int playerId)
        {
            if(getPlayer(playerId) != null)
            {
                if(getPlayer(playerId).getHand().getCurrentHandValue() > 21) {
                    getPlayer(playerId).bust();
                    
                }
            }
        }

        //This method raises an event in the player object and is called by the GUI.
        public void playerStand(int playerId) 
        {
            if(getPlayer(playerId) != null)
            {
                getPlayer(playerId).stand();
            }
        }

        //Adds a player to the list of players and subscribes to the player.
        public void addPlayer(string playerName, int playerId)
        {
            
            Player player = new Player(playerName, playerId);
            
            player.playerHit += OnPlayerHit;
            player.playerStand += OnPlayerStand;
            player.playerBust += OnPlayerBust;
            this.publishers++;

            players.Add(player);
        }

        //Unsubscribes to player.
        private void removePlayer(int playerId) {
            
            foreach(Player player in players)
            {
                if(player.playerId == playerId)
                {
                    player.playerHit -= OnPlayerHit;
                    player.playerStand -= OnPlayerStand;
                    player.playerBust -= OnPlayerBust;
                    this.publishers--;
                }
            }

        }

        //Returns the player from the list.
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

        //Remvoes player from the game.
        public void removePlayerFromGame(int playerId)
        {
            for(int i = 0; i < players.Count(); i++)
            {
                if (players.GetAt(i).getPlayerId() == playerId) { 
                    players.DeleteAt(i);
                }
            }

        }


        //Event
        private void OnPlayerHit(object? sender, PlayerEvent e)
        {

        }

        //Event
        private void OnPlayerStand(object? sender, PlayerEvent e)
        {
            if (!(sender is Player player)) throw new ArgumentException();

            removePlayer(player.getPlayerId());

        }

        //Event
        private void OnPlayerBust(object? sender, PlayerEvent e)
        {
            if (!(sender is Player player)) throw new ArgumentException();
            player.getHand().setHandBust(true);
            removePlayer(player.getPlayerId());
        }


        public Card getCardForDealer()
        {
            return gameDeck.drawCard();
        }
    }
}
