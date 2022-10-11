namespace AWANA_Advocates_Jeopardy
{
    partial class AdminForm
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
            this.adminDGV = new System.Windows.Forms.DataGridView();
            this.adminSaveBtn = new System.Windows.Forms.Button();
            this.adminCancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lessonNameList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDGV
            // 
            this.adminDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.adminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDGV.Location = new System.Drawing.Point(0, 31);
            this.adminDGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminDGV.Name = "adminDGV";
            this.adminDGV.RowHeadersWidth = 62;
            this.adminDGV.Size = new System.Drawing.Size(659, 277);
            this.adminDGV.TabIndex = 0;
            this.adminDGV.Text = "dataGridView1";
            // 
            // adminSaveBtn
            // 
            this.adminSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminSaveBtn.BackColor = System.Drawing.Color.Green;
            this.adminSaveBtn.Location = new System.Drawing.Point(473, 7);
            this.adminSaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminSaveBtn.Name = "adminSaveBtn";
            this.adminSaveBtn.Size = new System.Drawing.Size(78, 20);
            this.adminSaveBtn.TabIndex = 1;
            this.adminSaveBtn.Text = "Save";
            this.adminSaveBtn.UseVisualStyleBackColor = false;
            this.adminSaveBtn.Click += new System.EventHandler(this.adminSaveBtn_Click);
            // 
            // adminCancelBtn
            // 
            this.adminCancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminCancelBtn.BackColor = System.Drawing.Color.Red;
            this.adminCancelBtn.Location = new System.Drawing.Point(373, 7);
            this.adminCancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adminCancelBtn.Name = "adminCancelBtn";
            this.adminCancelBtn.Size = new System.Drawing.Size(78, 20);
            this.adminCancelBtn.TabIndex = 2;
            this.adminCancelBtn.Text = "Cancel";
            this.adminCancelBtn.UseVisualStyleBackColor = false;
            this.adminCancelBtn.Click += new System.EventHandler(this.adminCancelBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // lessonNameList
            // 
            this.lessonNameList.FormattingEnabled = true;
            this.lessonNameList.Location = new System.Drawing.Point(120, 7);
            this.lessonNameList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lessonNameList.Name = "lessonNameList";
            this.lessonNameList.Size = new System.Drawing.Size(129, 23);
            this.lessonNameList.TabIndex = 4;
            this.lessonNameList.SelectedIndexChanged += new System.EventHandler(this.lessonNameList_SelectedIndexChanged);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 305);
            this.Controls.Add(this.lessonNameList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminCancelBtn);
            this.Controls.Add(this.adminSaveBtn);
            this.Controls.Add(this.adminDGV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDGV;
        private System.Windows.Forms.Button adminSaveBtn;
        private System.Windows.Forms.Button adminCancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lessonNameList;
    }
}