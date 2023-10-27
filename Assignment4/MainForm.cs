using GameCardLib;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.Runtime.ExceptionServices;

namespace Assignment4
{
    public partial class MainForm : Form
    {

        private Dealer dealer;
        private readonly int cardOffsetY = 24;
        private List<Hand> hands;
        



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
           
        }

        //Returns which player is playing. If noone is playing it returns -1.
        private int whoIsPlaying()
        {
            if (player1RadioButton.Checked)
            {
                return 1;
            }

            if (player2RadioButton.Checked)
            {
                return 2;
            }

            if (player3RadioButton.Checked)
            {
                return 3;
            }

            if (player4RadioButton.Checked)
            {
                return 4;
            }

            return -1;
        }


        //A player wants a seat. Check with dealer for availabilty. 
        private void seatButtonClick(Button btn)
        {

            string btnText = btn.Text;
            int playerId = whoIsPlaying();

            int seatNbr = Int32.Parse(btnText);

            if (dealer.playerWantsSeat(playerId, seatNbr))
            {
                btn.Enabled = false;
                btn.Text = "Player " + playerId;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        /* Summary seat clicks.*/
        private void seatButton1_Click(object sender, EventArgs e)
        {
            seatButtonClick(sender as Button);
        }

        private void seatButton2_Click(object sender, EventArgs e)
        {
            seatButtonClick(sender as Button);
        }

        private void seatButton3_Click(object sender, EventArgs e)
        {
            seatButtonClick(sender as Button);
        }

        private void seatButton4_Click(object sender, EventArgs e)
        {
            seatButtonClick(sender as Button);
        }

        private void seatButton5_Click(object sender, EventArgs e)
        {
            seatButtonClick(sender as Button);
        }

        private void seatButton6_Click(object sender, EventArgs e)
        {
            seatButtonClick(sender as Button);
        }

        private void seatButton7_Click(object sender, EventArgs e)
        {
            seatButtonClick(sender as Button);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Force the background image to be sent back each time a new controll is added.
        private void MainForm_ControlAdded(object sender, ControlEventArgs e)
        {
            pictureBox1.SendToBack();
        }

        private Hand getDealerHand() //Returns the dealer hand. If the hand is not found, returns null.
        {

            foreach (Hand hand in hands)
            {
                int seatNbr = hand.getSeatNbr();
                if (getSeatButton(seatNbr) == null)//Find the dealer hand.
                {
                    return hand;
                }
            }

            return null;
        }

        private void displayScores()
        {
            dealerScoreLabel.Text = "Dealer Score " + getDealerHand().getScore();
        }

        private void placeDealerCards()
        {
            int posx = 430;
            int posy = 200;

            
            List<Card> dealerCards = getDealerHand().getCards();

            for (int i = 0; i < dealerCards.Count; i++)
            {
                addACard(dealerCards[i], posx, posy);
                posx += 100; //When a new card is added to the frame, offset the pos for the next car                   }
            }   
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

        private void placePlayerCards() //Places all cards that are in the hands list
        {
            foreach (Hand hand in hands)
            {
                List<Card> cards = hand.getCards(); //Get the cards in the hand.
                int seatNbr = hand.getSeatNbr(); //Get the seat nbr of the hand.
                Button seatButton = getSeatButton(seatNbr);
                Point point;

                if (seatButton != null) //Ignore if seatButton is null, that is the dealer hand.
                {
                    point = seatButton.Location; //get the location of the seat button.

                    int posx = point.X;
                    int posy = point.Y - 130; //offset for the card location.

                    for (int i = 0; i < cards.Count; i++)
                    {
                        addACard(cards[i], posx, posy);
                        posy -= cardOffsetY;
                    }
                }
            }
        }

        private void nextRoundButton_Click(object sender, EventArgs e)
        {
            // If there is atleast one seat picked. Start a new round.
            // Dealer deals 1 own cards then gives 2 cards for each active hand. 
            // player hits or stand for each hand. When its a new players turn change the current playing player to that
            // of the active hand. 
          

            this.hands = dealer.startNewRound();
            placePlayerCards();
            placeDealerCards();
            displayScores();
        }

        private Button getSeatButton(int seatNbr)
        {

            switch (seatNbr)
            {
                case 1:
                    return seatButton1;
                case 2:
                    return seatButton2;
                case 3:
                    return seatButton3;
                case 4:
                    return seatButton4;
                case 5:
                    return seatButton5;
                case 6:
                    return seatButton6;
                case 7:
                    return seatButton7;
            }
            return null;
        }

        //Player wants hit on his hand.
        private void playerHitButton_Click(object sender, EventArgs e)
        {
            int seatNbr = dealer.playerTurn();
            this.hands = dealer.playerHit(seatNbr);
            placePlayerCards();

        }

        //Player wants to stand on the current value of hand.
        private void playerStandButton_Click(object sender, EventArgs e)
        {
            int seatNbr = 0;
            dealer.playerStand(seatNbr);
        }
    }
}