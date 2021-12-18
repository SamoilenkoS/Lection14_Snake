using System;
using System.Linq;

namespace SnakeLibrary
{
    public class SnakeGameGrid : GameGrid
    {
        private Random _random;
        private Snake _snake;

        public const int MinimalSize = 3;

        public delegate void Notify();
        public delegate void NotifyScore(int score);

        public event Notify SnakeIsDead;
        public event NotifyScore ScoreChanged;

        public Cell Apple { get; private set; }
        public Cell[] SnakeCells => _snake.BodyCells.ToArray();
        public int Score => _snake.BodyCells.Count - MinimalSize;

        private SnakeGameGrid(int size, Notify snakeIsDead) : base(size)
        {
            _snake = new Snake();
            SnakeIsDead += snakeIsDead;
            _random = new Random();
            CreateApple();
        }

        public static SnakeGameGrid Initialize(
            int size,
            Notify snakeIsDead)
        {
            if (size >= MinimalSize)
            {
                return new SnakeGameGrid(size, snakeIsDead);
            }

            throw new ArgumentException("Size should be greater than zero!");
        }

        public void Move()
        {
            if (!_snake.IsAlive(FieldSize))
            {
                SnakeIsDead?.Invoke();
                return;
            }

            if (_snake.GetNextHeadPosition().Equals(Apple))
            {
                _snake.EatApple(Apple);
                CreateApple();
                ScoreChanged?.Invoke(Score);
            }
            else
            {
                _snake.Move();
            }
        }

        public void Restart()
        {
            _snake = new Snake();
            ScoreChanged?.Invoke(Score);
            CreateApple();
        }

        public void ChangeDirection(MoveDirection moveDirection)
        {
            _snake.ChangeDirection(moveDirection);
        }

        private void CreateApple()
        {
            Cell appleCell;
            do
            {
                appleCell = new Cell
                {
                    X = _random.Next(0, FieldSize),
                    Y = _random.Next(0, FieldSize)
                };
            } while (_snake.BodyCells
                .Any(x => x.Equals(appleCell)));

            Apple = appleCell;
        }
    }
}