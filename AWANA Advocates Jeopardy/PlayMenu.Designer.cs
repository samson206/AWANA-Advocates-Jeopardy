namespace AWANA_Advocates_Jeopardy
{
    partial class PlayMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.worldviewBtn = new System.Windows.Forms.Button();
            this.naturalismBtn = new System.Windows.Forms.Button();
            this.pantheismBtn = new System.Windows.Forms.Button();
            this.monotheismBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(839, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lessons";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // worldviewBtn
            // 
            this.worldviewBtn.Location = new System.Drawing.Point(12, 89);
            this.worldviewBtn.Name = "worldviewBtn";
            this.worldviewBtn.Size = new System.Drawing.Size(200, 54);
            this.worldviewBtn.TabIndex = 1;
            this.worldviewBtn.Text = "Worldview";
            this.worldviewBtn.UseVisualStyleBackColor = true;
            this.worldviewBtn.Click += new System.EventHandler(this.worldviewBtn_Click);
            // 
            // naturalismBtn
            // 
            this.naturalismBtn.Location = new System.Drawing.Point(218, 89);
            this.naturalismBtn.Name = "naturalismBtn";
            this.naturalismBtn.Size = new System.Drawing.Size(200, 54);
            this.naturalismBtn.TabIndex = 1;
            this.naturalismBtn.Text = "Naturalism";
            this.naturalismBtn.UseVisualStyleBackColor = true;
            this.naturalismBtn.Click += new System.EventHandler(this.naturalismBtn_Click);
            // 
            // pantheismBtn
            // 
            this.pantheismBtn.Location = new System.Drawing.Point(424, 89);
            this.pantheismBtn.Name = "pantheismBtn";
            this.pantheismBtn.Size = new System.Drawing.Size(200, 54);
            this.pantheismBtn.TabIndex = 1;
            this.pantheismBtn.Text = "Pantheism";
            this.pantheismBtn.UseVisualStyleBackColor = true;
            this.pantheismBtn.Click += new System.EventHandler(this.pantheismBtn_Click);
            // 
            // monotheismBtn
            // 
            this.monotheismBtn.Location = new System.Drawing.Point(630, 89);
            this.monotheismBtn.Name = "monotheismBtn";
            this.monotheismBtn.Size = new System.Drawing.Size(200, 54);
            this.monotheismBtn.TabIndex = 1;
            this.monotheismBtn.Text = "Monotheism";
            this.monotheismBtn.UseVisualStyleBackColor = true;
            this.monotheismBtn.Click += new System.EventHandler(this.monotheismBtn_Click);
            // 
            // PlayMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.monotheismBtn);
            this.Controls.Add(this.pantheismBtn);
            this.Controls.Add(this.naturalismBtn);
            this.Controls.Add(this.worldviewBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PlayMenu";
            this.Text = "Play";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button worldviewBtn;
        private System.Windows.Forms.Button naturalismBtn;
        private System.Windows.Forms.Button pantheismBtn;
        private System.Windows.Forms.Button monotheismBtn;
    }
}