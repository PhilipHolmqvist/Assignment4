using GameCardLib;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;
using static GameCardLib.Enums;

namespace Assignment4
{
    public partial class MainForm : Form
    {

        private Dealer dealer;
        private PlayerHandler playerHandler;

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
            dealer = new Dealer();
            playerHandler = new PlayerHandler();
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

            }
        }

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
            nextRoundButton.Enabled = true;
            addNewPlayerButton.Enabled = true;
            removePlayerButton.Enabled = true;
            playerControll1.Visible = true;
        }

        private void playRound()
        {
            List<int> seatsPlaying = playerHandler.newRoundStart(); //Gets which seats that should preform action.

            //Deal out two cards for each player
            foreach (int seat in seatsPlaying)
            {
                playerHandler.playerHit(seat);
                Hand playerHand = playerHandler.playerHit(seat);
                placePlayerCards(seat, playerHand.getCards());
                MessageBox.Show("Player with id: " + seat + " got two cards", "Lets goo", MessageBoxButtons.OK);
            }

            //Place the dealer card
            List<Card> dealerCards = dealer.newRoundStart(playerHandler.getCardForDealer());
            placeDealerCards(dealerCards);


            int first = seatsPlaying.First();
            RadioButton button = getRadioButton(first);
            button.Enabled = true;
            button.Checked = true;

            
        }

        private void nextRoundButton_Click(object sender, EventArgs e)
        {
            if (dealer.roundEnd == true)
            {
                playRound();

                nextRoundButton.Enabled = false;
                addNewPlayerButton.Enabled = false;
                removePlayerButton.Enabled = false;
                playerControll1.Visible = false;

                MessageBox.Show("New round started", "Lets goo", MessageBoxButtons.OK);
            }


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
            if(dealer.roundEnd != true)
            {
                int playerId = playerHandler.nextPlayer().getPlayerId();
                RadioButton button = getRadioButton(playerId);
                button.Enabled = true;
                button.Checked = true;
            }
            else
            {
                
            }
            
        }

        //Player wants hit on his hand.
        private void playerHitButton_Click(object sender, EventArgs e)
        {
            Hand hand = playerHandler.playerHit(getPlayerId());
            if (hand != null)
            {
                placePlayerCards(getPlayerId(), hand.getCards());
                MessageBox.Show("Player has pressed hit!", "Its a hit!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        //Player wants to stand on the current value of hand.
        private void playerStandButton_Click(object sender, EventArgs e)
        {
            playerHandler.playerStand(getPlayerId());
            nextPlayer();
            MessageBox.Show("Player stands!", "Its a stand!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
                    playerHandler.addPlayer(playerName, playerId);
                    getRadioButton(playerId).Enabled = false;

                }
                else if (action == "Remove player")
                {
                    playerHandler.removePlayer(playerId);
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
    }
}