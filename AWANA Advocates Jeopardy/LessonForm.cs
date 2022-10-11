using System.Windows.Forms;
using System.Diagnostics;

namespace AWANA_Advocates_Jeopardy
{
    public partial class LessonForm : Form
    {
        private string lessonToUse;
        public LessonForm(string lesson)
        {
            InitializeComponent();
            this.lessonToUse = lesson;
        }


        private void LessonForm_Load(object sender, System.EventArgs e)
        {
            DataAccess DA = new DataAccess();
            lessonName.Text = lessonToUse;
            scriptureTextBox.Text = DA.GetScriptureReading(lessonToUse);
        }

        private void powerPointBtn_Click(object sender, System.EventArgs e)
        {

            string appDirectory = System.IO.Directory.GetCurrentDirectory();
            string fileName = appDirectory   + "\\PowerPoints\\" + lessonToUse + ".pptx";

            var process = new System.Diagnostics.Process();

            process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = fileName };

            process.Start();
        }

        private void videoBtn_Click(object sender, System.EventArgs e)
        {
            string appDirectory = System.IO.Directory.GetCurrentDirectory();
            string fileName = appDirectory + "\\Videos\\" + lessonToUse + ".mp4";

            var process = new System.Diagnostics.Process();

            process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = fileName };

            process.Start();
        }

        private void gameBtn_Click(object sender, System.EventArgs e)
        {
            GameboardMenu gameboard = new GameboardMenu(lessonToUse, true);
            this.Hide();
            gameboard.ShowDialog();
            this.Show();
        }
    }
}
