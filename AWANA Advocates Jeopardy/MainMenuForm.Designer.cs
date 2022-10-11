namespace AWANA_Advocates_Jeopardy
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.playBtn = new AWANA_Advocates_Jeopardy.MenuButtons();
            this.mainMenuTitle = new System.Windows.Forms.Label();
            this.adminBtn = new AWANA_Advocates_Jeopardy.MenuButtons();
            this.learnBtn = new AWANA_Advocates_Jeopardy.MenuButtons();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.AccessibleDescription = "playBtn";
            this.playBtn.AccessibleName = "playBtn";
            this.playBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.playBtn.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.playBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.playBtn.BorderRadius = 40;
            this.playBtn.BorderSize = 0;
            this.playBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playBtn.ForeColor = System.Drawing.Color.White;
            this.playBtn.Location = new System.Drawing.Point(0, 464);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(1166, 189);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play";
            this.playBtn.TextColor = System.Drawing.Color.White;
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // mainMenuTitle
            // 
            this.mainMenuTitle.AccessibleDescription = "mainMenuTitle";
            this.mainMenuTitle.AccessibleName = "mainMenuTitle";
            this.mainMenuTitle.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainMenuTitle.Font = new System.Drawing.Font("Showcard Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainMenuTitle.Location = new System.Drawing.Point(0, 0);
            this.mainMenuTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainMenuTitle.Name = "mainMenuTitle";
            this.mainMenuTitle.Size = new System.Drawing.Size(1166, 201);
            this.mainMenuTitle.TabIndex = 1;
            this.mainMenuTitle.Text = "Advocates";
            this.mainMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adminBtn
            // 
            this.adminBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adminBtn.BackColor = System.Drawing.Color.Navy;
            this.adminBtn.BackgroundColor = System.Drawing.Color.Navy;
            this.adminBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adminBtn.BorderRadius = 26;
            this.adminBtn.BorderSize = 0;
            this.adminBtn.FlatAppearance.BorderSize = 0;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminBtn.ForeColor = System.Drawing.Color.White;
            this.adminBtn.Location = new System.Drawing.Point(1026, 217);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(128, 34);
            this.adminBtn.TabIndex = 3;
            this.adminBtn.Text = "Admin";
            this.adminBtn.TextColor = System.Drawing.Color.White;
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // learnBtn
            // 
            this.learnBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.learnBtn.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.learnBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.learnBtn.BorderRadius = 40;
            this.learnBtn.BorderSize = 0;
            this.learnBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.learnBtn.FlatAppearance.BorderSize = 0;
            this.learnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.learnBtn.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.learnBtn.ForeColor = System.Drawing.Color.White;
            this.learnBtn.Location = new System.Drawing.Point(0, 281);
            this.learnBtn.Name = "learnBtn";
            this.learnBtn.Size = new System.Drawing.Size(1166, 183);
            this.learnBtn.TabIndex = 4;
            this.learnBtn.Text = "Learn\r\n";
            this.learnBtn.TextColor = System.Drawing.Color.White;
            this.learnBtn.UseVisualStyleBackColor = false;
            this.learnBtn.Click += new System.EventHandler(this.learnBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AccessibleDescription = "mainMenuForm";
            this.AccessibleName = "mainMenuForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1166, 653);
            this.Controls.Add(this.learnBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.mainMenuTitle);
            this.Controls.Add(this.playBtn);
            this.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainMenuForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MenuButtons playBtn;
        private System.Windows.Forms.Label mainMenuTitle;
        private MenuButtons adminBtn;
        private MenuButtons learnBtn;
    }
}