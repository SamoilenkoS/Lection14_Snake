using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SnakeLibrary
{
    public static class HighScoresHelper
    {
        private const int RecordsCount = 3;
        private const string HighScoresPath = "records.txt";

        public static IEnumerable<HighScore> GetHighScores()
        {
            HighScore[] _highScores;
            try
            {
                using (StreamReader streamReader
                    = new StreamReader(HighScoresPath))
                {
                    string input = streamReader.ReadToEnd();
                    _highScores = JsonSerializer.Deserialize<HighScore[]>(input);
                }
            }
            catch (FileNotFoundException)
            {
                _highScores = new HighScore[RecordsCount];
                for (int i = 0; i < RecordsCount; i++)
                {
                    _highScores[i] = new HighScore();
                }

                SaveHighScores(_highScores);
            }

            return _highScores;
        }

        public static void SaveHighScores(IEnumerable<HighScore> highScores)
        {
            using (StreamWriter streamWriter = new StreamWriter(HighScoresPath))
            {
                streamWriter.WriteLine(
                    JsonSerializer.Serialize(highScores));
            }
        }

        public static void SaveHighScore(HighScore highScore)
        {
            var scores = GetHighScores().ToList();
            scores.Add(highScore);

            SaveHighScores(scores
                .OrderBy(x => x.Score)
                .Take(RecordsCount));
        }

        public static bool IsHighScore(int score)
        {
            return GetHighScores().Last().Score < score;
        }
    }
}
