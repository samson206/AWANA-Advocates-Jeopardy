using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWANA_Advocates_Jeopardy
{
    public partial class AddPlayerForm : Form
    {
        List<Player> players;
        public AddPlayerForm(ref List<Player> players)
        {
            this.players = players; 
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

            players.Add(new Player(newPlayerTb.Text));
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
