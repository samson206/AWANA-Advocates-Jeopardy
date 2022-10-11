using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWANA_Advocates_Jeopardy
{

    public partial class PlayMenu : Form
    {
        private Dictionary<int,Button[]> lessonMap;
        private string mode { get; set; }
        
        public PlayMenu(string mode)
        {   
            InitializeComponent();
            this.mode = mode;
        }

        private void worldviewBtn_Click(object sender, EventArgs e) { Lesson_Selected(worldviewBtn); }
        private void naturalismBtn_Click(object sender, EventArgs e) { Lesson_Selected(naturalismBtn); }
        private void pantheismBtn_Click(object sender, EventArgs e) { Lesson_Selected(pantheismBtn); }
        private void monotheismBtn_Click(object sender, EventArgs e) { Lesson_Selected(monotheismBtn); }
        private void apologeticsBtn_Click(object sender, EventArgs e) { Lesson_Selected(apologeticsBtn); }
        private void faithBtn_Click(object sender, EventArgs e) { Lesson_Selected(faithBtn); }
        private void truthBtn_Click(object sender, EventArgs e) { Lesson_Selected(truthBtn); }
        private void logicBtn_Click(object sender, EventArgs e) { Lesson_Selected(logicBtn); }
        private void loveBtn_Click(object sender, EventArgs e) { Lesson_Selected(loveBtn); }
        private void questionsBtn_Click(object sender, EventArgs e) { Lesson_Selected(questionsBtn); }
        private void doubtBtn_Click(object sender, EventArgs e) { Lesson_Selected(doubtBtn); }
        private void challengesBtn_Click(object sender, EventArgs e) { Lesson_Selected(challengesBtn); }
        private void evilBtn_Click(object sender, EventArgs e) { Lesson_Selected(evilBtn); }
        private void falsehoodBtn_Click(object sender, EventArgs e) { Lesson_Selected(falsehoodBtn); }
        private void sufferinBtn_Click(object sender, EventArgs e) { Lesson_Selected(sufferingBtn); }
        private void hellBtn_Click(object sender, EventArgs e) { Lesson_Selected(hellBtn); }
        private void scienceBtn_Click(object sender, EventArgs e) { Lesson_Selected(scienceBtn); }
        private void designerBtn_Click(object sender, EventArgs e) { Lesson_Selected(designerBtn); }
        private void dnaBtn_Click(object sender, EventArgs e) { Lesson_Selected(dnaBtn); }
        private void universeBtn_Click(object sender, EventArgs e) { Lesson_Selected(universeBtn); }
        private void moralityBtn_Click(object sender, EventArgs e) { Lesson_Selected(moralityBtn); }
        private void beautyBtn_Click(object sender, EventArgs e) { Lesson_Selected(beautyBtn); }
        private void agencyBtn_Click(object sender, EventArgs e) { Lesson_Selected(agencyBtn); }
        private void storyBtn_Click(object sender, EventArgs e) { Lesson_Selected(storyBtn); }

        private void Lesson_Selected(Button button)
        {
            if (mode == "Play")
            {
                GameboardMenu gameboard = new GameboardMenu(button.Text, teamBtn.Checked);
                this.Hide();
                gameboard.ShowDialog();
                this.Show();
            }
            else if (mode == "Learn")
            {
                LessonForm lessonForm = new LessonForm(button.Text);
                this.Hide();
                lessonForm.ShowDialog();
                this.Show();
            }
        }

        private void PlayMenu_Load(object sender, EventArgs e)
        {
            if (mode == "Play")
            {
                soloBtn.Select();
            }
            else if (mode == "Learn")
            {
                modeGroup.Visible = false;
            }

        }

        private void PlayMenu_Resize(object sender, EventArgs e)
        {
            int windowWidth = this.Size.Width;
            int windowHeight = this.Size.Height;
            int spacingBetweenBtn = 10;
            Dictionary<int, Button[]> lessonMap = new Dictionary<int, Button[]>();

            lessonMap.Add(1, new Button[] { apologeticsBtn, faithBtn, truthBtn, logicBtn });
            lessonMap.Add(2, new Button[] { worldviewBtn, naturalismBtn, pantheismBtn, monotheismBtn });
            lessonMap.Add(3, new Button[] { scienceBtn, universeBtn, dnaBtn, designerBtn });
            lessonMap.Add(4, new Button[] { moralityBtn, beautyBtn, agencyBtn, storyBtn });
            lessonMap.Add(5, new Button[] { evilBtn, falsehoodBtn, sufferingBtn, hellBtn });
            lessonMap.Add(6, new Button[] { loveBtn, questionsBtn, doubtBtn, challengesBtn });
            
            int lessonRows = lessonMap.Count+2;
            label1.Font = new Font("Arial", windowHeight / 30);
            foreach (var item in lessonMap)
            {
                for (int i = 0; i < 4; i++)
                {
                    item.Value[i].Location = new Point(spacingBetweenBtn * (i+1) + i * (windowWidth - (spacingBetweenBtn * 5)) / 4, (windowHeight / lessonRows) * item.Key);
                    item.Value[i].Width = (windowWidth - (spacingBetweenBtn * 5)) / 4;
                    item.Value[i].Height = (windowHeight - spacingBetweenBtn * 7) / lessonRows;
                    item.Value[i].Font = new Font("Arial", windowHeight / 30);
                }
            }
        }
    }
}
