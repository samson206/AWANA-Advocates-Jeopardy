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
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // adminDGV
            // 
            this.adminDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.adminDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.adminDGV.Location = new System.Drawing.Point(0, 205);
            this.adminDGV.Name = "adminDGV";
            this.adminDGV.RowHeadersWidth = 62;
            this.adminDGV.Size = new System.Drawing.Size(800, 245);
            this.adminDGV.TabIndex = 0;
            this.adminDGV.Text = "dataGridView1";
            // 
            // adminSaveBtn
            // 
            this.adminSaveBtn.BackColor = System.Drawing.Color.Green;
            this.adminSaveBtn.Location = new System.Drawing.Point(673, 161);
            this.adminSaveBtn.Name = "adminSaveBtn";
            this.adminSaveBtn.Size = new System.Drawing.Size(112, 34);
            this.adminSaveBtn.TabIndex = 1;
            this.adminSaveBtn.Text = "Save";
            this.adminSaveBtn.UseVisualStyleBackColor = false;
            this.adminSaveBtn.Click += new System.EventHandler(this.adminSaveBtn_Click);
            // 
            // adminCancelBtn
            // 
            this.adminCancelBtn.BackColor = System.Drawing.Color.Red;
            this.adminCancelBtn.Location = new System.Drawing.Point(530, 161);
            this.adminCancelBtn.Name = "adminCancelBtn";
            this.adminCancelBtn.Size = new System.Drawing.Size(112, 34);
            this.adminCancelBtn.TabIndex = 2;
            this.adminCancelBtn.Text = "Cancel";
            this.adminCancelBtn.UseVisualStyleBackColor = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminCancelBtn);
            this.Controls.Add(this.adminSaveBtn);
            this.Controls.Add(this.adminDGV);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.adminDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminDGV;
        private System.Windows.Forms.Button adminSaveBtn;
        private System.Windows.Forms.Button adminCancelBtn;
    }
}