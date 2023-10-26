using GameCardLib;

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
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
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

        private void nextRoundButton_Click(object sender, EventArgs e)
        {
            // If there is atleast one seat picked. Start a new round.
            // Dealer deals 1 own cards then gives 2 cards for each active hand. 
            // player hits or stand for each hand. When its a new players turn change the current playing player to that
            // of the active hand. 

            List<Card> cards = dealer.startNewRound();


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