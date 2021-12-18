
namespace Game
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxSnakePictureBox = new System.Windows.Forms.PictureBox();
            this.timerSnakeMove = new System.Windows.Forms.Timer(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnakePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxSnakePictureBox
            // 
            this.pictureBoxSnakePictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSnakePictureBox.Name = "pictureBoxSnakePictureBox";
            this.pictureBoxSnakePictureBox.Size = new System.Drawing.Size(551, 426);
            this.pictureBoxSnakePictureBox.TabIndex = 5;
            this.pictureBoxSnakePictureBox.TabStop = false;
            this.pictureBoxSnakePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBoxSnakePictureBox_Paint);
            // 
            // timerSnakeMove
            // 
            this.timerSnakeMove.Tick += new System.EventHandler(this.TimerSnakeMove_Tick);
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(582, 12);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(102, 29);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Score: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxSnakePictureBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake v.0.0.1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnakePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSnakePictureBox;
        private System.Windows.Forms.Timer timerSnakeMove;
        private System.Windows.Forms.Label labelScore;
    }
}

