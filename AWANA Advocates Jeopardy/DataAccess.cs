using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dapper;

namespace AWANA_Advocates_Jeopardy
{
    public class DataAccess
    {
        public List<LessonPlan> GetLessonPlan(string lesson)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectionValue("AdvocatesDB")))
            {
                //var output = connection.Query<LessonPlan>("dbo.Lesson_GetAllData").ToList();
                var output = connection.Query<LessonPlan>("dbo.Lesson_GetLessonData @LessonPlan", new { LessonPlan = lesson}).ToList();
                return output;
            }
        }
        public void UpdateQuestion(DataGridView dgv)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.connectionValue("AdvocatesDB")))
            {
                List<LessonPlan> lessonPlans = new List<LessonPlan>();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    int refNumIn = (int)row.Cells[0].Value;
                    string lessonNameIn = (string)row.Cells[1].Value;
                    string cellIn = (string)row.Cells[2].Value;
                    string questionIn = (string)row.Cells[3].Value;
                    lessonPlans.Add(new LessonPlan { refNum = refNumIn, lessonName = lessonNameIn, cell = cellIn, question = questionIn });
                }
                connection.Execute("dbo.Lesson_Update @refNum, @lessonName, @cell, @question", lessonPlans);
            }
        }
    }
}
