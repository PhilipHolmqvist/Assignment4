using GameCardLib;
using Microsoft.VisualBasic.ApplicationServices;
using System.Collections;
using System.ComponentModel;
using System.Runtime.ExceptionServices;
using System.Xml.Linq;

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
            if(button != null)
            {
                point = button.Location;

                int posx = point.X;
                int posy = point.Y - 130; //offset for the card location.

                for (int i = 0; i < cards.Count; i++)
                {
                    addACard(cards[i], posx, posy);
                    posy -= 24;
                }
            }
        }

        private void nextRoundButton_Click(object sender, EventArgs e)
        {
            dealer.newRoundStart();
            
        }

        private RadioButton getRadioButton(int playerId)
        {

            
            switch (playerId)
            {
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

            switch(checkedButton.Name.ToString()){

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


        //Player wants hit on his hand.
        private void playerHitButton_Click(object sender, EventArgs e)
        {
            List<Card> card = playerHandler.playerHit(getPlayerId());
            if (card != null)
            {
                placePlayerCards(getPlayerId(), card);
                MessageBox.Show("Player has pressed hit!", "Its a hit!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        //Player wants to stand on the current value of hand.
        private void playerStandButton_Click(object sender, EventArgs e)
        {
            playerHandler.playerStand(getPlayerId());
            MessageBox.Show("Player stands!", "Its a stand!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addNewPlayerButton_Click(object sender, EventArgs e)
        {
            //Show player controll. Set actionLabel to add. Check that name isnt already in the player list.
            //Check that the user has chosen a available seat with radio button. Create new player.
        }
    }
}