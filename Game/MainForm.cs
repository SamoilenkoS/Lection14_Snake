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
        SnakeGameGrid snakeGameGrid
            = SnakeGameGrid.Initialize(10);
        private Color color = Color.Black;

        public MainForm()
        {
            InitializeComponent();
        }

        private void numericUpDownEndY_ValueChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        bool _clicked = false;

        private void MainForm_MouseMove(
            object sender, MouseEventArgs e)
        {
            if (_clicked)
            {
                Brush pen = new SolidBrush(color);
                Control control = sender as Control;
                var graphics = control.CreateGraphics();
                graphics.FillRectangle(
                    pen,
                    e.X,
                    e.Y,
                    trackBarWidth.Value,
                    trackBarWidth.Value);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _clicked = true;
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _clicked = false;
        }

        private void buttonChooseColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            int size = 10;

            int width = (sender as Control).Width;
            int height = (sender as Control).Height;
            int elHeight = height / size;
            int elWidth = width / size;
            for (int j = 0; j < size; j++)
            {
                graphics.DrawLine(
                    Pens.Black,
                    0,
                    j * elHeight,
                    width,
                    j * elHeight);
                graphics.DrawLine(
                    Pens.Black,
                    j * elWidth,
                    0,
                    j * elWidth,
                    height);
            }
            var snakePart = snakeGameGrid.Snake.BodyCells.First;
            while(snakePart != null)
            {
                graphics.FillRectangle(Brushes.Red,
                    snakePart.Value.X * elWidth,
                    snakePart.Value.Y * elHeight,
                    elWidth, elHeight);
                snakePart = snakePart.Next;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            snakeGameGrid.Move();
            Refresh();
        }
    }
}
