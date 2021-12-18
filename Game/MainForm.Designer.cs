
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
            this.buttonMove = new System.Windows.Forms.Button();
            this.comboBoxDirections = new System.Windows.Forms.ComboBox();
            this.buttonChangeDirection = new System.Windows.Forms.Button();
            this.pictureBoxSnakePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnakePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(688, 12);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(100, 41);
            this.buttonMove.TabIndex = 2;
            this.buttonMove.Text = "Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxDirections
            // 
            this.comboBoxDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirections.FormattingEnabled = true;
            this.comboBoxDirections.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right"});
            this.comboBoxDirections.Location = new System.Drawing.Point(598, 59);
            this.comboBoxDirections.Name = "comboBoxDirections";
            this.comboBoxDirections.Size = new System.Drawing.Size(84, 24);
            this.comboBoxDirections.TabIndex = 3;
            // 
            // buttonChangeDirection
            // 
            this.buttonChangeDirection.Location = new System.Drawing.Point(688, 59);
            this.buttonChangeDirection.Name = "buttonChangeDirection";
            this.buttonChangeDirection.Size = new System.Drawing.Size(100, 44);
            this.buttonChangeDirection.TabIndex = 4;
            this.buttonChangeDirection.Text = "Change direction";
            this.buttonChangeDirection.UseVisualStyleBackColor = true;
            this.buttonChangeDirection.Click += new System.EventHandler(this.buttonChangeDirection_Click);
            // 
            // pictureBoxSnakePictureBox
            // 
            this.pictureBoxSnakePictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxSnakePictureBox.Name = "pictureBoxSnakePictureBox";
            this.pictureBoxSnakePictureBox.Size = new System.Drawing.Size(551, 426);
            this.pictureBoxSnakePictureBox.TabIndex = 5;
            this.pictureBoxSnakePictureBox.TabStop = false;
            this.pictureBoxSnakePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxSnakePictureBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxSnakePictureBox);
            this.Controls.Add(this.buttonChangeDirection);
            this.Controls.Add(this.comboBoxDirections);
            this.Controls.Add(this.buttonMove);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSnakePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.ComboBox comboBoxDirections;
        private System.Windows.Forms.Button buttonChangeDirection;
        private System.Windows.Forms.PictureBox pictureBoxSnakePictureBox;
    }
}

