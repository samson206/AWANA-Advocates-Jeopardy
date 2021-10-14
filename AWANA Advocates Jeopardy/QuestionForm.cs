using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWANA_Advocates_Jeopardy
{
    public partial class QuestionForm : Form
    {
        string question;
        int points;
        List<Player> players;
        public QuestionForm(string question, int points, ref List<Player> players)
        {
            this.question = question;
            this.points = points;
            this.players = players;
            InitializeComponent();
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            pointLbl.Text = points.ToString();
            questionLbl.Text = question;
            int i = players.Count;
            foreach (Control c in Controls)
            {
                Button b = c as Button;
                if (b != null && i > 0)
                {
                    b.Visible = true;
                    b.Text = players[i - 1].playerName;
                    i--;
                }
            }

        }
        private void AddPointsToPlayer(Button button)
        {
            foreach (Player player in players)
            {
                if (player.playerName == button.Text)
                {
                    player.playerPoints += points;
                    this.Close();
                }
            }
        }
        private void player1Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player1Btn); }
        private void player2Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player2Btn); }
        private void player3Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player3Btn); }
        private void player4Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player4Btn); }
        private void player5Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player5Btn); }
        private void player6Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player6Btn); }
        private void player7Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player7Btn); }
        private void player8Btn_Click(object sender, EventArgs e) { AddPointsToPlayer(player8Btn); }
    }
}
