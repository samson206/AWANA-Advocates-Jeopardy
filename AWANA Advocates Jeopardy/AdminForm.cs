using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWANA_Advocates_Jeopardy
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            DataAccess da = new DataAccess();
            adminDGV.DataSource = da.GetLessonPlan("Pantheism");
            adminDGV.Columns["FullInfo"].Visible = false;
            adminDGV.Columns["RefNum"].Visible = false;

            adminDGV.Columns["lessonName"].HeaderText = "Lesson Name";
            adminDGV.Columns["cell"].HeaderText = "Cell";
            adminDGV.Columns["question"].HeaderText = "Question";
        }

        private void adminSaveBtn_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            da.UpdateQuestion(adminDGV);
            this.Hide();
        }
    }
}
