using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class PlayerControll : UserControl
    {
        public PlayerControll()
        {
            InitializeComponent();
        }

        public void setActionLabel(string actionLabel)
        {
            this.actionLabel.Text = actionLabel;
        }

        private void actionLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = Parent as MainForm;
            mainForm.addOrRemovePlayer(textBox1.Text, actionLabel.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
