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
        public QuestionForm(string question, int points)
        {
            this.question = question;
            this.points = points;
            InitializeComponent();
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            pointLbl.Text = points.ToString();
            questionLbl.Text = question;
        }
    }
}
