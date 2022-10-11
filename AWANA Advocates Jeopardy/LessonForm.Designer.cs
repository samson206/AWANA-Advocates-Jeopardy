namespace AWANA_Advocates_Jeopardy
{
    partial class LessonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonForm));
            this.lessonName = new System.Windows.Forms.Label();
            this.scriptureTextBox = new System.Windows.Forms.TextBox();
            this.gameBtn = new AWANA_Advocates_Jeopardy.MenuButtons();
            this.videoBtn = new AWANA_Advocates_Jeopardy.MenuButtons();
            this.powerPointBtn = new AWANA_Advocates_Jeopardy.MenuButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lessonName
            // 
            this.lessonName.AutoSize = true;
            this.lessonName.BackColor = System.Drawing.Color.Transparent;
            this.lessonName.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.lessonName.Location = new System.Drawing.Point(388, 8);
            this.lessonName.Name = "lessonName";
            this.lessonName.Size = new System.Drawing.Size(118, 65);
            this.lessonName.TabIndex = 2;
            this.lessonName.Text = "Title";
            // 
            // scriptureTextBox
            // 
            this.scriptureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptureTextBox.Location = new System.Drawing.Point(513, 183);
            this.scriptureTextBox.Multiline = true;
            this.scriptureTextBox.Name = "scriptureTextBox";
            this.scriptureTextBox.Size = new System.Drawing.Size(389, 272);
            this.scriptureTextBox.TabIndex = 5;
            this.scriptureTextBox.Text = "TEST";
            // 
            // gameBtn
            // 
            this.gameBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.gameBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.gameBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.gameBtn.BorderRadius = 35;
            this.gameBtn.BorderSize = 0;
            this.gameBtn.FlatAppearance.BorderSize = 0;
            this.gameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameBtn.ForeColor = System.Drawing.Color.White;
            this.gameBtn.Location = new System.Drawing.Point(215, 317);
            this.gameBtn.Name = "gameBtn";
            this.gameBtn.Size = new System.Drawing.Size(129, 35);
            this.gameBtn.TabIndex = 4;
            this.gameBtn.Text = "Play Game";
            this.gameBtn.TextColor = System.Drawing.Color.White;
            this.gameBtn.UseVisualStyleBackColor = false;
            this.gameBtn.Click += new System.EventHandler(this.gameBtn_Click);
            // 
            // videoBtn
            // 
            this.videoBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.videoBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.videoBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.videoBtn.BorderRadius = 35;
            this.videoBtn.BorderSize = 0;
            this.videoBtn.FlatAppearance.BorderSize = 0;
            this.videoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videoBtn.ForeColor = System.Drawing.Color.White;
            this.videoBtn.Location = new System.Drawing.Point(321, 138);
            this.videoBtn.Name = "videoBtn";
            this.videoBtn.Size = new System.Drawing.Size(129, 35);
            this.videoBtn.TabIndex = 3;
            this.videoBtn.Text = "Video";
            this.videoBtn.TextColor = System.Drawing.Color.White;
            this.videoBtn.UseVisualStyleBackColor = false;
            this.videoBtn.Click += new System.EventHandler(this.videoBtn_Click);
            // 
            // powerPointBtn
            // 
            this.powerPointBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.powerPointBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.powerPointBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.powerPointBtn.BorderRadius = 35;
            this.powerPointBtn.BorderSize = 0;
            this.powerPointBtn.FlatAppearance.BorderSize = 0;
            this.powerPointBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerPointBtn.ForeColor = System.Drawing.Color.White;
            this.powerPointBtn.Location = new System.Drawing.Point(52, 139);
            this.powerPointBtn.Name = "powerPointBtn";
            this.powerPointBtn.Size = new System.Drawing.Size(129, 35);
            this.powerPointBtn.TabIndex = 1;
            this.powerPointBtn.Text = "PowerPoint";
            this.powerPointBtn.TextColor = System.Drawing.Color.White;
            this.powerPointBtn.UseVisualStyleBackColor = false;
            this.powerPointBtn.Click += new System.EventHandler(this.powerPointBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scripture";
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(940, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scriptureTextBox);
            this.Controls.Add(this.gameBtn);
            this.Controls.Add(this.videoBtn);
            this.Controls.Add(this.lessonName);
            this.Controls.Add(this.powerPointBtn);
            this.Name = "LessonForm";
            this.Text = "LessonForm";
            this.Load += new System.EventHandler(this.LessonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuButtons powerPointBtn;
        private System.Windows.Forms.Label lessonName;
        private MenuButtons videoBtn;
        private MenuButtons gameBtn;
        private System.Windows.Forms.TextBox scriptureTextBox;
        private System.Windows.Forms.Label label1;
    }
}