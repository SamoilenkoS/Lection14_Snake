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
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            var highScores = HighScoresHelper.GetHighScores();
            int number = 1;
            foreach (var highScore in highScores)
            {
                dataGridViewHighScores.Rows.Add(
                    number++,
                    highScore.PlayerName,
                    highScore.Score);
            }
        }
    }
}
