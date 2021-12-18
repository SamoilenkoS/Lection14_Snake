using SnakeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class MainForm : Form
    {
        SnakeGameGrid snakeGameGrid;

        public MainForm()
        {
            InitializeComponent();
            snakeGameGrid = SnakeGameGrid.Initialize(10, SnakeIsDead);
        }

        private void SnakeIsDead()
        {
            MessageBox.Show("Snake is dead!");
            //TODO add restart!
        }

        private void button1_Click(object sender, EventArgs e)
        {
            snakeGameGrid.Move();
            Refresh();
        }

        private void buttonChangeDirection_Click(object sender, EventArgs e)
        {
            MoveDirection moveDirection;
            switch (comboBoxDirections.SelectedItem)
            {
                case "Up":
                    moveDirection = MoveDirection.Up;
                    break;
                case "Down":
                    moveDirection = MoveDirection.Down;
                    break;
                case "Left":
                    moveDirection = MoveDirection.Left;
                    break;
                default:
                    moveDirection = MoveDirection.Right;
                    break;
            }

            snakeGameGrid.Snake.ChangeDirection(moveDirection);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxDirections.SelectedIndex = 3;
        }

        private void pictureBoxSnakePictureBox_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            int size = 10;

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
            var snakePart = snakeGameGrid.Snake.BodyCells.First;
            while (snakePart != null)
            {
                graphics.FillRectangle(Brushes.Green,
                    snakePart.Value.X * elWidth,
                    snakePart.Value.Y * elHeight,
                    elWidth, elHeight);
                snakePart = snakePart.Next;
            }

            graphics.FillRectangle(Brushes.Red,
                snakeGameGrid.Apple.X * elWidth,
                snakeGameGrid.Apple.Y * elHeight,
                elWidth, elHeight);
        }
    }
}
