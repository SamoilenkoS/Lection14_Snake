using SnakeLibrary;
using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        private readonly SnakeGameGrid _snakeGameGrid;

        public MainForm()
        {
            InitializeComponent();
            _snakeGameGrid = SnakeGameGrid.Initialize(8, SnakeIsDead);
            _snakeGameGrid.ScoreChanged += SnakeGameGrid_ScoreChanged;
        }

        private void SnakeGameGrid_ScoreChanged(int score)
        {
            labelScore.Text = $"Score: {score}";
        }

        private void SnakeIsDead()
        {
            timerSnakeMove.Enabled = false;
            MessageBox.Show("Snake is dead!");
            if (HighScoresHelper.IsHighScore(_snakeGameGrid.Score))
            {
                Hide();
                HighScoreForm highScoreForm = new HighScoreForm(_snakeGameGrid.Score);
                highScoreForm.ShowDialog();

                Show();
            }

            _snakeGameGrid.Restart();
            groupBoxControls.Enabled = true;
            buttonStart.Focus();
        }

        private void PictureBoxSnakePictureBox_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            int size = _snakeGameGrid.FieldSize;

            int width = (sender as Control).Width;
            int height = (sender as Control).Height;
            int elHeight = height / size;
            int elWidth = width / size;
            for (int j = 0; j <= size; j++)
            {
                graphics.DrawLine(
                    Pens.Black,
                    0,
                    j * elHeight,
                    elWidth * size,
                    j * elHeight);
                graphics.DrawLine(
                    Pens.Black,
                    j * elWidth,
                    0,
                    j * elWidth,
                    elHeight * size);
            }
            var cells = _snakeGameGrid.SnakeCells;
            foreach (var snakePart in cells)
            {
                graphics.FillRectangle(Brushes.Green,
                  snakePart.X * elWidth,
                  snakePart.Y * elHeight,
                  elWidth, elHeight);
            }

            graphics.FillRectangle(Brushes.Red,
                _snakeGameGrid.Apple.X * elWidth,
                _snakeGameGrid.Apple.Y * elHeight,
                elWidth, elHeight);
        }

        private void TimerSnakeMove_Tick(object sender, EventArgs e)
        {
            _snakeGameGrid.Move();
            Refresh();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            MoveDirection? moveDirection = null;

            switch (e.KeyValue)
            {
                case (char)Keys.W:
                    moveDirection = MoveDirection.Up;
                    break;
                case (char)Keys.A:
                    moveDirection = MoveDirection.Left;
                    break;
                case (char)Keys.S:
                    moveDirection = MoveDirection.Down;
                    break;
                case (char)Keys.D:
                    moveDirection = MoveDirection.Right;
                    break;
            }

            if(moveDirection != null)
            {
                _snakeGameGrid.ChangeDirection(moveDirection.Value);
            }
        }

        private void buttonHighScores_Click(object sender, EventArgs e)
        {
            Hide();

            HighScores highScores = new HighScores();
            highScores.ShowDialog();

            Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBoxSnakePictureBox.Focus();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerSnakeMove.Enabled = true;
            groupBoxControls.Enabled = false;
        }
    }
}
