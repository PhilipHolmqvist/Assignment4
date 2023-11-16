using Assignment4;
using BJGameBBL;
using BJGameEL;
using Elsa.Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BJGameApp
{
    public partial class HistoryForm : Form
    {

        public GameHandler GameHandler;

        public HistoryForm(GameHandler gameHandler, List<Player> playerHistory)
        {
            this.GameHandler = gameHandler;

            InitializeComponent();

            //Lägger till rätt columner i datagridview
            dataGridView1.Columns.Add("playerId", "ID");
            dataGridView1.Columns.Add("playerName", "Name");
            dataGridView1.Columns.Add("playerWinner", "Winner");
            dataGridView1.Columns.Add("playerScore", "Score");

            //Populera datagridview med information från history.
            foreach (Player player in playerHistory)
            {
                dataGridView1.Rows.Add(player.id, player.playerName, player.winner, player.hand.score);
            }



        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int id = Convert.ToInt32(selectedRow.Cells["playerId"].Value);
            GameHandler.deleteEntryFromDatabase(id);

            dataGridView1.Rows.RemoveAt(selectedrowindex);
            MessageBox.Show("Delete entry with id:" + id, "Delete", MessageBoxButtons.OK);
        }
    }
}
