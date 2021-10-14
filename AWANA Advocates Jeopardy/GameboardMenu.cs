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
        private Dictionary<string, string> questions;
        List<Player> players = new List<Player>();
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
        public GameboardMenu(string lessonToUse)
        {
            this.lessonToUse = lessonToUse;
            InitializeComponent();
        }

        private void GameboardMenu_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            List<LessonPlan> lessonPlans = da.GetLessonPlan(lessonToUse);
            questions = Helper.ConvertListToMap(lessonPlans);
            lessonNameTitle.Text = lessonToUse;
        }
        private void PerformClick(Button button)
        {
            button.Hide();
            this.Hide();
            QuestionForm question = new QuestionForm(questions[button.Name], Int32.Parse(button.Text),ref players);
            question.ShowDialog();
            this.Show();
            UpdateListBox();

        }
        private void addPlayerBtn_Click(object sender, EventArgs e)
        {
            AddPlayerForm addForm = new AddPlayerForm(ref players);
            addForm.ShowDialog();

            int listBoxHeight = 29 + ((players.Count-1)*25);
            playersLb.Size = new System.Drawing.Size(192, listBoxHeight);

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
    }
}
