using BJGameBBL;
using BJGameEL;
using UtilitiesLib;
using static BJGameEL.Enums;

namespace Assignment4
{
    public partial class MainForm : Form
    {

        private GameHandler gameHandler;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();

        public MainForm()
        {
            InitializeComponent();
            setUpMainForm();
        }

        private void setUpMainForm()
        {
            //label1.Parent = pictureBox1;
            //label1.BackColor = Color.Transparent;
            pictureBox1.SendToBack();
            gameHandler = new GameHandler();
            playerControll1.Visible = false;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Force the background image to be sent back each time a new controll is added.
        private void MainForm_ControlAdded(object sender, ControlEventArgs e)
        {
            pictureBox1.SendToBack();
        }



        private void displayScores()
        {

        }


        private void addACard(Card card, int posx, int posy)
        {
            String val = card.getValue().ToString();
            String suit = card.getSuits().ToString();
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(83, 108);
            pictureBox.Margin = new Padding(3, 3, 3, 3);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Visible = true;
            pictureBox.Image = Image.FromFile("./Images/all-cards/" + val + "_of_" + suit + ".png");
            this.pictureBoxes.Add(pictureBox);
            pictureBox.Location = new Point(posx, posy);
            this.Controls.Add(pictureBox);
            pictureBox.BringToFront();
        }

        private void placePlayerCards(int playerId, List<Card> cards) //Places all cards that are in the hands list
        {
            Point point;
            RadioButton button = getRadioButton(playerId);
            if (button != null)
            {
                point = button.Location;

                int score = 0;
                int posx = point.X - 37;
                int posy = point.Y - 130; //offset for the card location.

                for (int i = 0; i < cards.Count; i++)
                {
                    addACard(cards[i], posx, posy);
                    posy -= 24;
                    score += cards[i].getCardIntValue();
                }

                setScoreLabel(playerId, score);
                if(score > 21) {
                    MessageBox.Show("Player bust with score: " + score, "BUST!", MessageBoxButtons.OK);
                }

            }
        }

        //Sets the score label for a player. 
        private void setScoreLabel(int playerId, int playerScore)
        {
            switch (playerId)
            {
                case 0:
                    dealerScoreLabel.Text = "Dealer Score: " + playerScore.ToString();
                    break;

                case 1:
                    scoreLabel1.Text = "Score: " + playerScore.ToString();
                    break;
                case 2:
                    scoreLabel2.Text = "Score: " + playerScore.ToString();
                    break;
                case 3:
                    scoreLabel3.Text = "Score: " + playerScore.ToString();
                    break;
                case 4:
                    scoreLabel4.Text = "Score: " + playerScore.ToString();
                    break;
                case 5:
                    scoreLabel5.Text = "Score: " + playerScore.ToString();
                    break;
                case 6:
                    scoreLabel6.Text = "Score: " + playerScore.ToString();
                    break;
                case 7:
                    scoreLabel7.Text = "Score: " + playerScore.ToString();
                    break;
            }
        }

        //Places the dealer cards on the correct location. If only one card place an upside down next to it.
        private void placeDealerCards(List<Card> cards)
        {
            Point point;
            RadioButton button = getRadioButton(0);
            if (button != null)
            {
                point = button.Location;

                int score = 0;
                int posx = point.X - 37;
                int posy = point.Y - 130; //offset for the card location.

                if (cards.Count == 1)
                {
                    addACard(cards.First(), posx, posy);
                    posx += 100;
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(83, 108);
                    pictureBox.Margin = new Padding(3, 3, 3, 3);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Visible = true;
                    pictureBox.Image = Image.FromFile("./Images/backside.png");
                    this.pictureBoxes.Add(pictureBox);
                    pictureBox.Location = new Point(posx, posy);
                    this.Controls.Add(pictureBox);
                    pictureBox.BringToFront();

                    score = cards.First().getCardIntValue();

                }
                else
                {
                    for (int i = 0; i < cards.Count; i++)
                    {
                        addACard(cards[i], posx, posy);
                        posx += 42;
                        score += cards[i].getCardIntValue();
                    }
                }
                setScoreLabel(0, score);
            }
        }

        private void roundFinished()
        {
            MessageBox.Show("Round finished!", "Yey", MessageBoxButtons.OK);
            nextRoundButton.Enabled = true;
            addNewPlayerButton.Enabled = true;
            removePlayerButton.Enabled = true;
            playerControll1.Visible = true;
            clearHandsButton.Enabled = true;

            List<Player> playerList = gameHandler.whoIsWinner();
            if(playerList.Count > 0 )
            {
                String displayString = "Winners are:";

                foreach (Player player in playerList)
                {
                    displayString += "\n Player: " + player.playerName + ", with seat " + player.playerId;
                }

                MessageBox.Show(displayString, "Winners", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No winners!", "Loser!", MessageBoxButtons.OK);
            }
           

            
        }

        private void playRound()
        {

            ListManager<Player> players = gameHandler.startRound();

            foreach (Player player in players)
            {
                if (player.playerId != 0)
                {
                    List<Card> playerCards = player.getHand().getCards();
                    placePlayerCards(player.getPlayerId(), playerCards);

                }
                else if (player.playerId == 0)
                {
                    List<Card> dealerCards = player.getHand().getCards();
                    placeDealerCards(dealerCards);
                }

            }
            nextPlayer();
        }

        private void nextRoundButton_Click(object sender, EventArgs e)
        {



            playRound();

            nextRoundButton.Enabled = false;
            addNewPlayerButton.Enabled = false;
            removePlayerButton.Enabled = false;
            playerControll1.Visible = false;
            clearHandsButton.Enabled = false;

            MessageBox.Show("New round started", "Lets goo", MessageBoxButtons.OK);



        }

        private void dealerPlay()
        {
            Player dealer = gameHandler.dealerPlay();
            placeDealerCards(dealer.getHand().getCards());

            roundFinished();
        }

        private RadioButton getRadioButton(int playerId)
        {


            switch (playerId)
            {
                case 0:
                    return dealerButton;
                case 1:
                    return radioButton1;
                case 2:
                    return radioButton2;
                case 3:
                    return radioButton3;
                case 4:
                    return radioButton4;
                case 5:
                    return radioButton5;
                case 6:
                    return radioButton6;
                case 7:
                    return radioButton7;

                default: return null;

            }
        }

        private int getPlayerId()
        {
            var checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            if (checkedButton != null)
            {
                switch (checkedButton.Name.ToString())
                {

                    case "radioButton7":
                        return 7;

                    case "radioButton6":
                        return 6;

                    case "radioButton5":
                        return 5;

                    case "radioButton4":
                        return 4;

                    case "radioButton3":
                        return 3;

                    case "radioButton2":
                        return 2;

                    case "radioButton1":
                        return 1;
                    default: return 0;

                }
            }
            else
            {
                return 0;
            }


        }

        private void nextPlayer()
        {

            int playerId = gameHandler.whoIsNextPlayer();

            if (playerId != 0)
            {
                RadioButton button = getRadioButton(playerId);
                button.Enabled = true;
                button.Checked = true;
            }
            else
            {
                dealerPlay();
            }
        }

        //Player wants hit on his hand. Places the cards when they are returned.
        private void playerHitButton_Click(object sender, EventArgs e)
        {
            Hand hand = gameHandler.playerHit(getPlayerId());
            if (hand != null)
            {
                placePlayerCards(getPlayerId(), hand.getCards());
                if (gameHandler.getPlayer(getPlayerId()).isFinished == true)
                {
                    nextPlayer();
                }
               
            }
        }

        //Player wants to stand on the current value of hand.
        private void playerStandButton_Click(object sender, EventArgs e)
        {
            gameHandler.playerStand(getPlayerId());
            nextPlayer();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void addOrRemovePlayer(string playerName, string action)
        {

            int playerId = getPlayerId();

            if (playerId != 0)
            {

                playerControll1.Visible = false;

                if (action == "Add player")
                {
                    gameHandler.addPlayer(playerName, playerId);
                    getRadioButton(playerId).Enabled = false;

                }
                else if (action == "Remove player")
                {
                    gameHandler.removePlayerFromGame(playerId);
                }
            }
            else
            {
                MessageBox.Show("You need to select a seat for the new player!", "Error", MessageBoxButtons.OK);
            }


        }

        private void addNewPlayerButton_Click(object sender, EventArgs e)
        {
            //Show player controll. Set actionLabel to add. 
            //Check that the user has chosen a available seat with radio button. Create new player.
            playerControll1.Visible = true;
            playerControll1.setActionLabel("Add player");

        }

        private void removePlayerButton_Click(object sender, EventArgs e)
        {
            playerControll1.Visible = true;
            playerControll1.setActionLabel("Remove player");
        }

        private void clearHandsButton_Click(object sender, EventArgs e)
        {
           
            //remove cards.
            dealerScoreLabel.Text = "Dealer Score: ";
            scoreLabel1.Text = "Score1";
            scoreLabel2.Text = "Score2";
            scoreLabel3.Text = "Score3";
            scoreLabel4.Text = "Score4";
            scoreLabel5.Text = "Score5";
            scoreLabel6.Text = "Score6";
            scoreLabel7.Text = "Score7";

            

            foreach(PictureBox pictureBox in pictureBoxes)
            {
                this.Controls.Remove(pictureBox);
            }

            pictureBoxes.Clear();
            gameHandler = new GameHandler();

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
            radioButton7.Enabled = true;

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;





        }
    }
}