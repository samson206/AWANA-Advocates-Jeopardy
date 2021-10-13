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
        public PlayMenu()
        {
            InitializeComponent();
        }

        private void worldviewBtn_Click(object sender, EventArgs e)
        {
            Lesson_Selected(worldviewBtn);
        }

        private void naturalismBtn_Click(object sender, EventArgs e)
        {
            Lesson_Selected(naturalismBtn);
        }

        private void pantheismBtn_Click(object sender, EventArgs e)
        {
            Lesson_Selected(pantheismBtn);
        }

        private void monotheismBtn_Click(object sender, EventArgs e)
        {
            Lesson_Selected(monotheismBtn);
        }

        private void Lesson_Selected(Button button)
        {
            GameboardMenu gameboard = new GameboardMenu(button.Text);
            this.Hide();
            gameboard.ShowDialog();
            this.Show();
        }
    }
}
