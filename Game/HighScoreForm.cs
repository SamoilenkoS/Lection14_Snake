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
    public partial class HighScoreForm : Form
    {
        private int _score;
        public HighScoreForm(int score = 0)
        {
            _score = score;

            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
            {
                HighScore highScore = new HighScore
                {
                    PlayerName = textBoxName.Text,
                    Score = _score
                };

                HighScoresHelper.SaveHighScore(highScore);
                Close();
            }
        }
    }
}
