using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWANA_Advocates_Jeopardy
{
    public partial class GameboardMenu : Form
    {
        private string lessonToUse;
        private Dictionary<string, string[]> questions;
        List<Player> players = new List<Player>();
        private bool teamMode;
        int firstPrize = 3000;
        int secondPrize = 4000;
        int thirdPrize = 5000;
        private void A100_Click(object sender, EventArgs e) { PerformClick(A100); }
        private void A200_Click(object sender, EventArgs e) { PerformClick(A200); }
        private void A300_Click(object sender, EventArgs e) { PerformClick(A300); }
        private void A400_Click(object sender, EventArgs e) { PerformClick(A400); }
        private void A500_Click(object sender, EventArgs e) { PerformClick(A500); }
        private void B100_Click(object sender, EventArgs e) { PerformClick(B100); }
        private void B200_Click(object sender, EventArgs e) { PerformClick(B200); }
        private void B300_Click(object sender, EventArgs e) { PerformClick(B300); }
        private void B400_Click(object sender, EventArgs e) { PerformClick(B400); }
        private void B500_Click(object sender, EventArgs e) { PerformClick(B500); }
        private void C100_Click(object sender, EventArgs e) { PerformClick(C100); }
        private void C200_Click(object sender, EventArgs e) { PerformClick(C200); }
        private void C300_Click(object sender, EventArgs e) { PerformClick(C300); }
        private void C400_Click(object sender, EventArgs e) { PerformClick(C400); }
        private void C500_Click(object sender, EventArgs e) { PerformClick(C500); }
        private void D100_Click(object sender, EventArgs e) { PerformClick(D100); }
        private void D200_Click(object sender, EventArgs e) { PerformClick(D200); }
        private void D300_Click(object sender, EventArgs e) { PerformClick(D300); }
        private void D400_Click(object sender, EventArgs e) { PerformClick(D400); }
        private void D500_Click(object sender, EventArgs e) { PerformClick(D500); }
        private void E100_Click(object sender, EventArgs e) { PerformClick(E100); }
        private void E200_Click(object sender, EventArgs e) { PerformClick(E200); }
        private void E300_Click(object sender, EventArgs e) { PerformClick(E300); }
        private void E400_Click(object sender, EventArgs e) { PerformClick(E400); }
        private void E500_Click(object sender, EventArgs e) { PerformClick(E500); }
        public GameboardMenu(string lessonToUse, bool mode)
        {
            this.lessonToUse = lessonToUse;
            InitializeComponent();
            this.teamMode = mode;
        }

        private void GameboardMenu_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            List<LessonPlan> lessonPlans = da.GetLessonPlan(lessonToUse);
            questions = Helper.ConvertListToMap(lessonPlans);
            lessonNameTitle.Text = lessonToUse;
            if (teamMode == true)
            {
                addPlayerBtn.Visible = false;
                progressGrpBox.Visible = true;

                players.Add(new Player("Team"));
            }
            UpdateListBox();
        }
        private void PerformClick(Button button)
        {
            if (players.Count > 0 && questions.Count > 0)
            {
                button.Hide();
                this.Hide();
                QuestionForm question = new QuestionForm(questions[button.Name][0], questions[button.Name][1], Int32.Parse(button.Text), ref players);
                question.ShowDialog();
                this.Show();
                UpdateListBox();
                if (players[0].playerPoints <= firstPrize) 
                { 
                    candyBar1.Value = players[0].playerPoints; 
                }
                else if (players[0].playerPoints >= firstPrize & players[0].playerPoints <= secondPrize) 
                {
                    candyBar1.Value = firstPrize;
                    candyBar2.Value = players[0].playerPoints; 
                }
                else if (players[0].playerPoints >= secondPrize & players[0].playerPoints <= thirdPrize) 
                {
                    candyBar2.Value = secondPrize;
                    candyBar3.Value = players[0].playerPoints; 
                }
                else if (players[0].playerPoints >= thirdPrize)
                {
                    candyBar3.Value = thirdPrize;
                }

            }
        }
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            AddPlayerForm addForm = new AddPlayerForm(ref players);
            addForm.ShowDialog();

            int listBoxHeight = 200 + ((players.Count-1)*48);
            playersLb.Size = new System.Drawing.Size(272, listBoxHeight);

            UpdateListBox();
        }
        private void UpdateListBox()
        {
            playersLb.DataSource = null;
            playersLb.DataSource = players;
            playersLb.DisplayMember = "FullInfo";
            playersLb.Refresh();
        }
        private void quitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
