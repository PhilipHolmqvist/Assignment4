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
            if(player1RadioButton.Checked)
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

        private void seatButton1_Click(object sender, EventArgs e)
        {
            if(dealer.playerWantsSeat(whoIsPlaying(), 1))
            {
                seatButton1.Enabled = false;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seatButton2_Click(object sender, EventArgs e)
        {
            if (dealer.playerWantsSeat(whoIsPlaying(), 2))
            {
                seatButton2.Enabled = false;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seatButton3_Click(object sender, EventArgs e)
        {
            if (dealer.playerWantsSeat(whoIsPlaying(), 3))
            {
                seatButton3.Enabled = false;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seatButton4_Click(object sender, EventArgs e)
        {
            if (dealer.playerWantsSeat(whoIsPlaying(), 4))
            {
                seatButton4.Enabled = false;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seatButton5_Click(object sender, EventArgs e)
        {
            if (dealer.playerWantsSeat(whoIsPlaying(), 5))
            {
                seatButton5.Enabled = false;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seatButton6_Click(object sender, EventArgs e)
        {
            if (dealer.playerWantsSeat(whoIsPlaying(), 6))
            {
                seatButton6.Enabled = false;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void seatButton7_Click(object sender, EventArgs e)
        {
            if (dealer.playerWantsSeat(whoIsPlaying(), 7))
            {
                seatButton7.Enabled = false;
            }
            else
            {
                MessageBox.Show("That seat is already taken!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}