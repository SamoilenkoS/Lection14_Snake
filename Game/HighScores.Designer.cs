
namespace Game
{
    partial class HighScores
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
            this.dataGridViewHighScores = new System.Windows.Forms.DataGridView();
            this.ColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHighScores
            // 
            this.dataGridViewHighScores.AllowUserToAddRows = false;
            this.dataGridViewHighScores.AllowUserToDeleteRows = false;
            this.dataGridViewHighScores.AllowUserToResizeColumns = false;
            this.dataGridViewHighScores.AllowUserToResizeRows = false;
            this.dataGridViewHighScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHighScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber,
            this.ColumnPlayerName,
            this.ColumnScore});
            this.dataGridViewHighScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHighScores.EnableHeadersVisualStyles = false;
            this.dataGridViewHighScores.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHighScores.Name = "dataGridViewHighScores";
            this.dataGridViewHighScores.ReadOnly = true;
            this.dataGridViewHighScores.RowHeadersVisible = false;
            this.dataGridViewHighScores.RowHeadersWidth = 51;
            this.dataGridViewHighScores.RowTemplate.Height = 24;
            this.dataGridViewHighScores.Size = new System.Drawing.Size(513, 298);
            this.dataGridViewHighScores.TabIndex = 0;
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.FillWeight = 50F;
            this.ColumnNumber.HeaderText = "#";
            this.ColumnNumber.MinimumWidth = 6;
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.ReadOnly = true;
            this.ColumnNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNumber.Width = 50;
            // 
            // ColumnPlayerName
            // 
            this.ColumnPlayerName.HeaderText = "Name";
            this.ColumnPlayerName.MinimumWidth = 6;
            this.ColumnPlayerName.Name = "ColumnPlayerName";
            this.ColumnPlayerName.ReadOnly = true;
            this.ColumnPlayerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPlayerName.Width = 200;
            // 
            // ColumnScore
            // 
            this.ColumnScore.HeaderText = "Score";
            this.ColumnScore.MinimumWidth = 6;
            this.ColumnScore.Name = "ColumnScore";
            this.ColumnScore.ReadOnly = true;
            this.ColumnScore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnScore.Width = 125;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 298);
            this.Controls.Add(this.dataGridViewHighScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HighScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHighScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHighScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnScore;
    }
}