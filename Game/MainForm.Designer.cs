
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
            this.buttonHighScores = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnakePictureBox)).BeginInit();
            this.groupBoxControls.SuspendLayout();
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
            // buttonHighScores
            // 
            this.buttonHighScores.Location = new System.Drawing.Point(6, 30);
            this.buttonHighScores.Name = "buttonHighScores";
            this.buttonHighScores.Size = new System.Drawing.Size(115, 53);
            this.buttonHighScores.TabIndex = 7;
            this.buttonHighScores.Text = "High scores";
            this.buttonHighScores.UseVisualStyleBackColor = true;
            this.buttonHighScores.Click += new System.EventHandler(this.buttonHighScores_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 90);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 44);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonHighScores);
            this.groupBoxControls.Controls.Add(this.buttonStart);
            this.groupBoxControls.Location = new System.Drawing.Point(569, 44);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(129, 143);
            this.groupBoxControls.TabIndex = 9;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.pictureBoxSnakePictureBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake v.0.0.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnakePictureBox)).EndInit();
            this.groupBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxSnakePictureBox;
        private System.Windows.Forms.Timer timerSnakeMove;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonHighScores;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxControls;
    }
}

