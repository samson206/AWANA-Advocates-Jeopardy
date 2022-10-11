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
            adminDGV.DataSource = da.GetAllLessonPlans();
            adminDGV.Columns["RefNum"].Visible = false;

            adminDGV.Columns["lessonName"].HeaderText = "Lesson Name";
            adminDGV.Columns["cell"].HeaderText = "Cell";
            adminDGV.Columns["question"].HeaderText = "Question";
            adminDGV.Columns["answer"].HeaderText = "Answer";
            adminDGV.Columns["topic"].HeaderText = "Topic";
            adminDGV.Columns["scripture"].HeaderText = "Scripture";

            lessonNameList.DataSource =da.GetLessonNames();
        }

        private void adminSaveBtn_Click(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            da.UpdateQuestion(adminDGV);
            this.Hide();
        }

        private void adminCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lessonNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            adminDGV.DataSource = da.GetLessonPlan(lessonNameList.SelectedItem.ToString());

        }
    }
}
