namespace AWANA_Advocates_Jeopardy
{
    partial class QuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.pointLbl = new System.Windows.Forms.Label();
            this.questionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pointLbl
            // 
            this.pointLbl.BackColor = System.Drawing.Color.Transparent;
            this.pointLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pointLbl.Font = new System.Drawing.Font("Malgun Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pointLbl.Location = new System.Drawing.Point(0, 0);
            this.pointLbl.Name = "pointLbl";
            this.pointLbl.Size = new System.Drawing.Size(800, 69);
            this.pointLbl.TabIndex = 0;
            this.pointLbl.Text = "Points";
            this.pointLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // questionLbl
            // 
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Location = new System.Drawing.Point(114, 100);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(588, 167);
            this.questionLbl.TabIndex = 1;
            this.questionLbl.Text = "Question";
            this.questionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.pointLbl);
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.Load += new System.EventHandler(this.QuestionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pointLbl;
        private System.Windows.Forms.Label questionLbl;
    }
}