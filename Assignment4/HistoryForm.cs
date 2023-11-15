using Assignment4;
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
        
        public HistoryForm(List<Player> playerHistory)
        {
            
            InitializeComponent();

            //Lägger till rätt columner i datagridview
            dataGridView1.Columns.Add("playerId", "ID");
            dataGridView1.Columns.Add("playerName", "Name");
            dataGridView1.Columns.Add("playerWinner", "Winner");
            dataGridView1.Columns.Add("playerScore", "Score");

            //Populera datagridview med information från history.
            foreach (Player player in playerHistory)
            {
                dataGridView1.Rows.Add(player.id, player.playerName, player.winner, 12);
            }

           
            
        }
    }
}
