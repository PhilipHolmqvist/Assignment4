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
        
        public HistoryForm(List<String> playerHistory)
        {
            //Test med data grid view
            List<Player> history = new List<Player>();
            Player p = new Player("Holmen", 1);
            p.winner = true;
            p.hand.score = 21;
            history.Add(p);
            
            InitializeComponent();
            dataGridView1.DataSource = history;
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }
    }
}
