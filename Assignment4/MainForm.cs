using GameCardLib;
using Microsoft.VisualBasic.ApplicationServices;

namespace Assignment4
{
    public partial class MainForm : Form
    {

        private Dealer dealer;

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

        private void nextRoundButton_Click(object sender, EventArgs e)
        {
            // If there is atleast one seat picked. Start a new round.
            // Dealer deals 1 own cards then gives 2 cards for each active hand. 
            // player hits or stand for each hand. When its a new players turn change the current playing player to that
            // of the active hand. 

            List<Hand> hands = dealer.startNewRound();
            foreach (Hand hand in hands)
            {
                int seatNbr = hand.getSeatNbr();
                List<Card> cards = hand.getCards();

                foreach (Card card in cards)
                {
                    String val = card.getValue().ToString();
                    String suit = card.getSuits().ToString();

                    PictureBox pictureBox5 = new PictureBox();
                    pictureBox5.Size = new Size(83, 108);
                    pictureBox5.Margin = new Padding(3, 3, 3, 3);
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Visible = true;
                    pictureBox5.Image = Image.FromFile("./Images/all-cards/" + val + "_of_" + suit + ".png");

                    //Base the card location on the button location.
                    Point buttonLocation = getSeatButton(seatNbr).Location; // ger null pointer.

                    int x;
                    int y;

                    if(buttonLocation != null) //Player card.
                    {
                        x = buttonLocation.X;
                        y = buttonLocation.Y - 150;
                    }
                    else //Dealer card
                    {
                        x = 490;
                        y = 200;
                    }

                    pictureBox5.Location = new Point(x, y);
                    this.Controls.Add(pictureBox5);
                    pictureBox5.BringToFront();

                }
            }
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
            int seatNbr = 0;
            dealer.playerHit(seatNbr);
        }

        //Player wants to stand on the current value of hand.
        private void playerStandButton_Click(object sender, EventArgs e)
        {
            int seatNbr = 0;
            dealer.playerStand(seatNbr);
        }
    }
}