using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWANA_Advocates_Jeopardy
{
    public partial class MainMenuForm : Form
    {
        List<LessonPlan> lessonPlans = new List<LessonPlan>();

        public MainMenuForm()
        {

            InitializeComponent();

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            mainMenuTitle.BackColor = Color.Transparent;
        }
        
        private void playBtn_Click(object sender, EventArgs e)
        {
            PlayMenu playMenu = new PlayMenu("Play");
            playMenu.ShowDialog();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm admin = new AdminForm();
            admin.ShowDialog();
            this.Show();
        }

        private void learnBtn_Click(object sender, EventArgs e)
        {
            PlayMenu playMenu = new PlayMenu("Learn");
            playMenu.ShowDialog();
        }
    }
}
